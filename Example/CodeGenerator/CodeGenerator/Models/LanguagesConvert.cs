using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeGenerator.Models
{
    [Serializable]
	public class LanguagesConvert
	{
        public Dictionary<string, string> SqlServerToCSharp { get; set; }

        public Dictionary<string, string> MySqlToCSharp { get; set; }
	}
}