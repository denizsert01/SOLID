using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.KotuYontem
{
    internal class VeritabaniYoneticisi
    {
        // Problem: Tightly-coupling (sıkı bağlı)
        SqlVeritabani vt = new SqlVeritabani();

        // Oracle ile çalışmak istersek?
        // Çözüm: Sınıfı loosely-coupled (gevşek bağlı) hale getirmek
        

    }
}
