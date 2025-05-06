using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    /// <summary>
    ///  tamamlayan dosya yoneticisi sınıfı
    /// </summary>
    internal class DosyaYoneticisi
    {
        public string DosyadanOku(Dosya dosya) // dosya json beklemiyor.
        {
            return dosya.Oku();
        }
    }
}
