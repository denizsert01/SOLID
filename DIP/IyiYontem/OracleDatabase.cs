using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.IyiYontem
{
    internal class OracleDatabase : ICRUD
    {
        public List<string> Listele()
        {
            return new List<string>
            {
                "Oracle 1",
                "Oracle 2",
                "Oracle 3"
            };
        }
    }
}
