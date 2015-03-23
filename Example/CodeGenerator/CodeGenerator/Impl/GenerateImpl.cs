using CodeGenerator.DataAccess;
using CodeGenerator.Template;
using CodeGenerator.Utility;
/*
 * -------------------------------------------------------------------------------
 * 版权信息：	奥鹏远程教育中心	版权所有	2013
 * 功能描述：	
 * 
 * 创建人：　	韩天伟(HanTw)
 * 创建日期：	2014/6/3 16:47:18
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
using System.Linq;
using System.Text;
using System.Web;

namespace CodeGenerator.Impl
{
    public class GenerateImpl
    {
        static GenerateDataAccess generateDal = new GenerateDataAccess();

        public static void GenerateDbContext()
        {
            var tableList = generateDal.GetTableList();
            DbContextTemplate dbContextTemplate = new DbContextTemplate(tableList);
            String contentDbContext = dbContextTemplate.TransformText();
            System.IO.File.WriteAllText(Config.DataAccessPath + "\\" + Config.DBContextName, contentDbContext, Encoding.UTF8);
        }

        public static void GenerateDataAccess(string tableName)
        {
            var fieldList = generateDal.GetFieldList(tableName);
            var tableModel = generateDal.GetTableList().Single(o => o.Name == tableName);

            ModelTemplate modelTemplate = new ModelTemplate(fieldList, tableModel);
            String contentModel = modelTemplate.TransformText();
            System.IO.File.WriteAllText(Utility.FileHelper.PathExists(Config.BusinessEntitiesPath, tableName, Enums.GenerateType.Model), contentModel, Encoding.UTF8);

            DataAccessTemplate dataAccessTemplate = new DataAccessTemplate(fieldList, tableModel);
            String contentDataAccess = dataAccessTemplate.TransformText();
            System.IO.File.WriteAllText(Utility.FileHelper.PathExists(Config.DataAccessPath, tableName, Enums.GenerateType.DataAccess), contentDataAccess, Encoding.UTF8);

            LogicTemplate logicTemplate = new LogicTemplate(fieldList, tableModel);
            String contentLogic = logicTemplate.TransformText();
            System.IO.File.WriteAllText(Utility.FileHelper.PathExists(Config.BusinessLogicPath, tableName, Enums.GenerateType.Logic), contentLogic, Encoding.UTF8);

            //业务逻辑层接口
            if(Utility.Config.IBusinessLogicEnable==true)
            {
                IDataAccessTemplate idataAccessTemplate = new IDataAccessTemplate(fieldList, tableModel);
                String icontentDataAccess = idataAccessTemplate.TransformText();
                System.IO.File.WriteAllText(Utility.FileHelper.PathExists(Config.IDataAccessPath, "I"+tableName, Enums.GenerateType.DataAccess), icontentDataAccess, Encoding.UTF8);
            }

            //数据访问层接口
            if (Utility.Config.IDataAccessEnable == true)
            {
                ILogicTemplate ilogicTemplate = new ILogicTemplate(fieldList, tableModel);
                String icontentLogic = ilogicTemplate.TransformText();
                System.IO.File.WriteAllText(Utility.FileHelper.PathExists(Config.IBusinessLogicPath, "I" + tableName, Enums.GenerateType.Logic), icontentLogic, Encoding.UTF8);
            }

        }

        public static void GenerateModel(string tableName)
        {
            var fieldList = generateDal.GetFieldList(tableName);
            var tableModel = generateDal.GetTableList().Single(o => o.Name == tableName);

            ModelTemplate modelTemplate = new ModelTemplate(fieldList, tableModel);
            String contentModel = modelTemplate.TransformText();
            System.IO.File.WriteAllText(Utility.FileHelper.PathExists(Config.BusinessEntitiesPath, tableName, Enums.GenerateType.Model), contentModel, Encoding.UTF8);
        }

    }
}