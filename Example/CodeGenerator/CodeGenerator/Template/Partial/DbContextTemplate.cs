using CodeGenerator.Models;
/* ------------------------------------------------------------------------
* 【本类功能概述】
* 
* 创建人：俊涵(JunHan)
* 创建时间：2014/6/3 22:40:06
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

namespace CodeGenerator.Template
{
    public partial class DbContextTemplate
    {
        public List<TableModel> tableList { get; set; }

        public string tableName { get; set; }

        public DbContextTemplate(List<TableModel> _tableList)
        {
            this.tableList = _tableList;
        }
    }
}