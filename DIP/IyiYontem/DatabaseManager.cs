using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.IyiYontem
{
    internal class DatabaseManager
    {
        // readonly sadece ctorda değiştirilebilirdi. bu yüzden readonly yapmadık. çünkü method injection da var
        private ICRUD _veritabani;

        // Constructor injection
        // Loosely-coupled oldu. 
        public DatabaseManager(ICRUD veritabani)
        {
            _veritabani = veritabani;
        }

        public DatabaseManager()
        {
            // Default constructor - return tipi yoktur.
        }

        // Method injection
        public void MethodInjection(ICRUD db)
        {
            _veritabani = db;
        }

        // Property injection
        public ICRUD PropertyInjection {
            get { return _veritabani; }
            set { _veritabani = value; }
        }


        public List<string> VerileriListele()
        {
            return _veritabani.Listele();
        }

    }
}
