using CodeGenerator.Models;
/*
 * -------------------------------------------------------------------------------
 * 版权信息：	奥鹏远程教育中心	版权所有	2013
 * 功能描述：	
 * 
 * 创建人：　	韩天伟(HanTw)
 * 创建日期：	2014/6/3 16:43:17
 * 创建说明：	
 * 
 * 修改人：　	
 * 修改日期：	
 * 修改说明：	
 *    
 * -------------------------------------------------------------------------------
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CodeGenerator.DataAccess
{
    public class GenerateDataAccess
    {
        #region SQL-SqlServer
        private string SqlTableList = @"SELECT 
	                                                so.name,
	                                                Convert( VARCHAR(10), ep.[value]) AS [description]
                                                FROM 
	                                                sysobjects so(NOLOCK)
	                                                LEFT JOIN sys.extended_properties ep(NOLOCK) ON ep.major_id=so.id AND ep.minor_id=0
                                                WHERE  
	                                                so.[type]='U' AND so.name<>'sysdiagrams' 
                                                ORDER BY 
	                                                so.name";

        private string SqlFieldList = @"SELECT  
                                            c.name,
                                            t.name AS [type],
                                            CONVERT(INT,c.length) AS maxLength,
                                            c.isnullable AS isNullable,
                                            (
                                                SELECT COUNT(1) FROM sys.identity_columns ic(NOLOCK) WHERE ic.[object_id]=c.id AND ic.column_id=c.colid 
                                            ) AS isIdentity,
                                            (
                                                SELECT VALUE FROM   sys.extended_properties ep(NOLOCK) WHERE  ep.major_id = c.id AND ep.minor_id=c.colid
                                            ) AS [description],
                                            [IsPk]=CASE WHEN EXISTS (SELECT 1 FROM sysobjects WHERE xtype='PK' and parent_obj=c.id and name IN (
                                                SELECT name FROM sysindexes WHERE indid in(SELECT indid FROM sysindexkeys WHERE id = c.id AND colid=c.colid))) THEN 1 ELSE 0 END
                                        FROM 
                                            syscolumns c(NOLOCK)
                                            INNER JOIN sys.tables ts(NOLOCK) ON ts.[object_id] = c.id
                                            INNER JOIN sys.types t(NOLOCK) ON t.system_type_id=c.xtype
                                            INNER JOIN systypes st(NOLOCK) ON st.name=t.name AND st.name<>'sysname'
                                            INNER JOIN sysusers su(NOLOCK) ON st.uid=su.uid AND su.name='sys'
                                            --INNER JOIN syscolumns s(NOLOCK) ON c.[object_id]=s.id
                                        WHERE 
                                            ts.name='{0}'
                                        ORDER BY
                                            c.id ASC";
        #endregion

        #region SQL-MySql
        private string SqlTableList_MySql = @"SELECT 
	                                            TABLE_NAME as name,
	                                            TABLE_COMMENT as description 
                                            FROM 
	                                            information_schema.TABLES 
                                            WHERE 
	                                            TABLE_SCHEMA='{0}'";

        private string SqlFieldList_MySql = @"SELECT 
	                                            COLUMN_NAME as name,
	                                            DATA_TYPE as type,
	                                            IFNULL(CHARACTER_MAXIMUM_LENGTH,0) as maxLength,
	                                            (CASE IS_NULLABLE WHEN 'NO' THEN 0 ELSE 1 END) as isNullable,
	                                            0 as isIdentity,
	                                            COLUMN_COMMENT as description,
	                                            (CASE COLUMN_KEY WHEN 'PRI' THEN 1 ELSE 0 END) as IsPk
                                            FROM 
	                                            information_schema.COLUMNS  
                                            WHERE 
	                                            TABLE_SCHEMA='{0}' 
	                                            AND TABLE_NAME='{1}'
                                            ORDER BY
	                                            ORDINAL_POSITION ASC";
        #endregion


        public List<TableModel> GetTableList()
        {
            List<TableModel> tableList = new List<TableModel>();

            string Sql = string.Empty;

            using (BaseContext context = new BaseContext())
            {
                if (Utility.Config.DataBaseType == Utility.Enums.DataBaseType.SqlServer)
                {
                    Sql = SqlTableList;
                }
                else if (Utility.Config.DataBaseType == Utility.Enums.DataBaseType.MySql)
                {
                    Sql = string.Format(SqlTableList_MySql, context.Database.Connection.Database);
                }

                tableList = context.Database.SqlQuery<TableModel>(Sql).ToList();

                if (Utility.Config.DataBaseType == Utility.Enums.DataBaseType.MySql)
                {
                    tableList.ForEach(item =>
                    {
                        item.Name = Utility.StringHelper.StringMysqlToUpper(item.Name);
                        if (Utility.Config.NoCreateList.Any(o => item.Name.ToLower().Contains(o.ToLower())))
                        {
                            tableList.Remove(item);
                        }
                    });
                }
            }
            Utility.Config.NoCreateList.ForEach(item =>
            {
                tableList = tableList.Where(o => !o.Name.ToLower().Contains(item.ToLower())).ToList();
            });
            return tableList;
        }

        public List<FieldModel> GetFieldList(string tableName)
        {
            List<FieldModel> fieldList = new List<FieldModel>();

            string Sql = string.Empty;

            using (BaseContext context = new BaseContext())
            {
                if (Utility.Config.DataBaseType == Utility.Enums.DataBaseType.SqlServer)
                {
                    Sql = string.Format(SqlFieldList, tableName);
                }
                else if (Utility.Config.DataBaseType == Utility.Enums.DataBaseType.MySql)
                {
                    Sql = string.Format(SqlFieldList_MySql, context.Database.Connection.Database, tableName);
                }

                fieldList = context.Database.SqlQuery<FieldModel>(Sql).ToList();
            }
            return fieldList;
        }
    }
}