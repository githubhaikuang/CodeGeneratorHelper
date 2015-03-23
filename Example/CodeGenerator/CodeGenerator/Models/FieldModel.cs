﻿/*
 * -------------------------------------------------------------------------------
 * 版权信息：	奥鹏远程教育中心	版权所有	2013
 * 功能描述：	
 * 
 * 创建人：　	韩天伟(HanTw)
 * 创建日期：	2014/6/3 16:19:51
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
    [Serializable]
    public class FieldModel
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public int MaxLength { get; set; }

        public int IsNullable { get; set; }

        public int IsIdentity { get; set; }

        public string Description { get; set; }

        public int IsPk { get; set; }

    }
}