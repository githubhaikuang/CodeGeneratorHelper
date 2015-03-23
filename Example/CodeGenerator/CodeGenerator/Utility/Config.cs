/* ------------------------------------------------------------------------
* 【本类功能概述】
* 
* 创建人：俊涵(JunHan)
* 创建时间：2014/6/3 21:33:50
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
using System.Configuration;
using Spring.Context;
using Spring.Context.Support;

namespace CodeGenerator.Utility
{
    public class Config
    {
        public static string NameSpace
        {
            get
            {
                return ConfigurationManager.AppSettings["NameSpace"].ToString();
            }
        }


        public static string BusinessEntitiesPath
        {
            get
            {
                return HttpContext.Current.Server.MapPath("~/" + ConfigurationManager.AppSettings["BusinessEntitiesPath"].ToString()).Replace("\\CodeGenerator\\", "\\");
            }
        }

        public static string BusinessEntitiesClass
        {
            get
            {
                return ConfigurationManager.AppSettings["BusinessEntitiesClass"].ToString();
            }
        }

        public static string DataAccessPath
        {
            get
            {
                return HttpContext.Current.Server.MapPath("~/" + ConfigurationManager.AppSettings["DataAccessPath"].ToString()).Replace("\\CodeGenerator\\", "\\");
            }
        }

        public static string DataAccessClass
        {
            get
            {
                return ConfigurationManager.AppSettings["DataAccessClass"].ToString();
            }
        }

        public static string BusinessLogicPath
        {
            get
            {
                return HttpContext.Current.Server.MapPath("~/" + ConfigurationManager.AppSettings["BusinessLogicPath"].ToString()).Replace("\\CodeGenerator\\", "\\");
            }
        }

        public static string BusinessLogicClass
        {
            get
            {
                return ConfigurationManager.AppSettings["BusinessLogicClass"].ToString();
            }
        }

        public static string BusinessLogicSuffix
        {
            get
            {
                return ConfigurationManager.AppSettings["BusinessLogicSuffix"].ToString();
            }
        }

        public static string BusinessEntitiesSuffix
        {
            get
            {
                return ConfigurationManager.AppSettings["BusinessEntitiesSuffix"].ToString();
            }
        }

        public static string DataAccessSuffix
        {
            get
            {
                return ConfigurationManager.AppSettings["DataAccessSuffix"].ToString();
            }
        }
        public static string DBContextName
        {
            get
            {
                return ConfigurationManager.AppSettings["DBContextName"].ToString() + ".cs";
            }
        }

        public static string DBContext
        {
            get
            {
                return ConfigurationManager.AppSettings["DBContextName"].ToString();
            }
        }

        public static Enums.DataBaseType DataBaseType
        {
            get
            {
                return (Enums.DataBaseType)Enum.Parse(typeof(Enums.DataBaseType), ConfigurationManager.AppSettings["DataBaseType"].ToString());
            }
        }

        public static bool IDataAccessEnable
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["IDataAccessEnable"]) == 1;
            }
        }

        public static string IDataAccessPath
        {
            get
            {
                return HttpContext.Current.Server.MapPath("~/" + ConfigurationManager.AppSettings["IDataAccessPath"].ToString()).Replace("\\CodeGenerator\\", "\\");
            }
        }

        public static string IDataAccessClass
        {
            get
            {
                return ConfigurationManager.AppSettings["IDataAccessClass"].ToString();
            }
        }

        public static bool IBusinessLogicEnable
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["IBusinessLogicEnable"]) == 1;
            }
        }

        public static string IBusinessLogicPath
        {
            get
            {
                return HttpContext.Current.Server.MapPath("~/" + ConfigurationManager.AppSettings["IBusinessLogicPath"].ToString()).Replace("\\CodeGenerator\\", "\\");
            }
        }

        public static string IBusinessLogicClass
        {
            get
            {
                return ConfigurationManager.AppSettings["IBusinessLogicClass"].ToString();
            }
        }

        public static bool IoCEnable
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["IoCEnable"]) == 1;
            }
        }

        public static Dictionary<string, string> LanguagesConvert
        {
            get
            {
                IApplicationContext ctx = ContextRegistry.GetContext();
                var languagesConvert = ctx.GetObject("SqlToCSharp") as Models.LanguagesConvert;
                var dics = Config.DataBaseType == Enums.DataBaseType.SqlServer ? languagesConvert.SqlServerToCSharp : languagesConvert.MySqlToCSharp;
                return dics;
            }
        }

        public static List<string> NoCreateList
        {
            get
            {
                IApplicationContext ctx = ContextRegistry.GetContext();
                var noCreateList = ctx.GetObject("NoCreateList") as List<string>;
                return noCreateList;
            }
        }

    }
}