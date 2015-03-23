/*
 * -------------------------------------------------------------------------------
 * 版权信息：	奥鹏远程教育中心	版权所有	2013
 * 功能描述：	
 * 
 * 创建人：　	韩天伟(HanTw)
 * 创建日期：	2014/6/3 17:17:46
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
using System.Web;
using System.Xml.Linq;

namespace CodeGenerator.Utility
{
    public class XMLHelper
    {
        public static Dictionary<string, string> GetSqlToCSharp()
        {
            Dictionary<string, string> disc = new Dictionary<string, string>();
            XElement root = XElement.Load(HttpContext.Current.Server.MapPath("~/Config/Languages.xml"));

            var custs = (from c in root.Elements("Language")
                         where c.Attribute("From").Value.Equals("SQL") && c.Attribute("To").Value.Equals("C#")
                         select c).ToList();

            foreach (XElement node in custs.Elements("Type"))
            {
                disc.Add(node.Attribute("From").Value, node.Attribute("To").Value);
            }

            return disc;
        }
    }
}