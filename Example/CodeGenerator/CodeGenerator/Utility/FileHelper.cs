/* ------------------------------------------------------------------------
* 【本类功能概述】
* 
* 创建人：俊涵(JunHan)
* 创建时间：2014/6/3 21:52:44
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
using System.IO;

namespace CodeGenerator.Utility
{
    public class FileHelper
    {
        public static string PathExists(string path, string tableName, Enums.GenerateType generateType)
        {
            string[] pArr = tableName.Split('_');
            string _path = path + "\\" + (pArr.Length >= 3 ? pArr[1] : tableName) + "\\AutoCode";
            if (!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
            }
            if (generateType == Enums.GenerateType.DataAccess)
            {
                return _path + "\\" + tableName + Config.DataAccessSuffix + ".cs";
            }
            else if (generateType == Enums.GenerateType.Logic)
            {
                return _path + "\\" + tableName + Config.BusinessLogicSuffix + ".cs";
            }
            else if (generateType == Enums.GenerateType.Model)
            {
                return _path + "\\" + tableName + Config.BusinessEntitiesSuffix + ".cs";
            }
            else if (generateType == Enums.GenerateType.DbContext)
            {
                return _path + "\\" + tableName + Config.BusinessEntitiesSuffix + ".cs";
            }
            else
            {
                return string.Empty;
            }
        }
    }
}