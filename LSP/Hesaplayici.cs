using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    /// <summary>
    ///  statik yonetici sinifi
    /// </summary>
    internal static class Hesaplayici
    {
        public static double Hesapla(Daire daire)
        {
            return daire.Hesapla();
        }
    }
}
