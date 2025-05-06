using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.IyiYontem
{
    internal class SqlDatabase : ICRUD
    {
        public List<string> Listele()
        {
            return new List<string>
            {
                "SQL 1",
                "SQL 2",
                "SQL 3"
            };
        }
    }
}
