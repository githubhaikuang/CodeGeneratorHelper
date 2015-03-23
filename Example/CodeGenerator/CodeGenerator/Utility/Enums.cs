/* ------------------------------------------------------------------------
* 【本类功能概述】
* 
* 创建人：俊涵(JunHan)
* 创建时间：2014/6/3 22:21:25
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

namespace CodeGenerator.Utility
{
    public class Enums
    {
        public enum GenerateType
        {
            Model = 0,
            DataAccess = 1,
            Logic = 2,
            DbContext = 3
        }

        public enum DataBaseType
        {
            SqlServer = 0,
            MySql = 1
        }
    }
}