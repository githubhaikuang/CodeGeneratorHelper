/* ------------------------------------------------------------------------
* 【本类功能概述】
* 
* 创建人：俊涵(JunHan)
* 创建时间：2014/6/3 23:06:29
* 创建说明：
*
* 修改人： 
* 修改时间： 
* 修改说明：
* ------------------------------------------------------------------------
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Spring.Context.Support;
using Spring.Context;

namespace CodeGenerator.Utility
{
    public class StringHelper
    {
        public static string GetCSharpType(string sqlType)
        {
            var dics = Config.LanguagesConvert;
            return dics[sqlType];
        }

        public static string TableNameToLower(string tableName)
        {
            string[] tableNameArr = tableName.Split('_');
            if (tableNameArr.Length <= 1)
            {
                return tableName.ToLower();
            }
            else
            {
                return tableName.Replace(tableNameArr[0] + "_", tableNameArr[0].ToLower() + "_");
            }
        }

        public static string GetKeyToCondition(List<Models.FieldModel> fieldList)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (fieldList != null)
            {
                var _fieldList = fieldList.Where(o => o.IsPk == 1);
                foreach (var item in _fieldList)
                {
                    stringBuilder.AppendFormat("{0} {1},", GetCSharpType(item.Type), TableNameToLower(item.Name));
                }
            }
            return string.IsNullOrEmpty(stringBuilder.ToString()) ? string.Empty : stringBuilder.ToString().Substring(0, stringBuilder.ToString().Length - 1);
        }

        public static string GetKeyToFindConditon(List<Models.FieldModel> fieldList)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (fieldList != null)
            {
                var _fieldList = fieldList.Where(o => o.IsPk == 1);
                foreach (var item in _fieldList)
                {
                    stringBuilder.AppendFormat("{0},", TableNameToLower(item.Name));
                }
            }
            return string.IsNullOrEmpty(stringBuilder.ToString()) ? string.Empty : stringBuilder.ToString().Substring(0, stringBuilder.ToString().Length - 1);
        }

        public static string GetIsNullString(Models.FieldModel fieldModel)
        {
            string _type = GetCSharpType(fieldModel.Type).ToLower(); ;
            if ((_type == "long" || _type == "datetime" || _type == "decimal" || _type == "double" || _type == "int" || _type == "float" || _type == "short" || _type == "uniqueidentifier") && fieldModel.IsNullable == 1)
            {
                return "?";
            }
            return "";
        }

        public static string GetKeyAndValue(List<Models.FieldModel> fieldList, string tableName)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (fieldList != null)
            {
                var _fieldList = fieldList.Where(o => o.IsPk == 1);
                foreach (var item in _fieldList)
                {
                    stringBuilder.AppendFormat("\"{0} = \" + {1}.{2} +\" ,\" + ", item.Name, TableNameToLower(tableName), item.Name);
                }
            }
            return string.IsNullOrEmpty(stringBuilder.ToString()) ? string.Empty : stringBuilder.ToString().Substring(0, stringBuilder.ToString().Length - 8);
        }

        public static string StringMysqlToUpper(string value)
        {
            string[] valueArr = value.Split('_');
            if (valueArr.Length <= 1)
            {
                if (value.Length <= 3)
                {
                    return value.ToUpper();
                }
                else
                {
                    return value.Substring(0, 1).ToUpper() + value.Substring(1, value.Length - 1);
                }
            }
            for (int i = 0; i < valueArr.Length; i++)
            {
                if (i == 0)
                {
                    value = value.Replace(valueArr[i] + "_", valueArr[0].ToUpper() + "_");
                }
                else
                {
                    if (valueArr[i].Length <= 3)
                    {
                        value = value.Replace("_" + valueArr[i], "_" + valueArr[i].ToUpper());
                    }
                    else
                    {
                        value = value.Replace("_" + valueArr[i].Substring(0, 1), "_" + valueArr[i].Substring(0, 1).ToUpper());
                    }
                }
            }
            return value;
        }
    }
}