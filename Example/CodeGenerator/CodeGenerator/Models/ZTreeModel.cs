/*
 * -------------------------------------------------------------------------------
 * 版权信息：	奥鹏远程教育中心	版权所有	2013
 * 功能描述：	
 * 
 * 创建人：　	韩天伟(HanTw)
 * 创建日期：	2014/6/3 17:42:46
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

namespace CodeGenerator.Models
{
    public class ZTreeModel
    {
        public string id { get; set; }
        public string pId { get; set; }
        public string name { get; set; }
        public bool @checked { get; set; }
    }
}