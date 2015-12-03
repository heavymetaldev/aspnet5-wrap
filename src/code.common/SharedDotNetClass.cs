using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Common
{
    public class SharedDotNetClass
    {
        public static string DoSomething()
        {
            var t = System.Configuration.ConfigurationManager.AppSettings["test"];
            return t;
        }      
    }
}
