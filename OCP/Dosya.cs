using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    /// <summary>
    ///  abstract Dosya sınıfı
    /// </summary>
    internal abstract class Dosya
    {
        public abstract string Oku(); // türeyen sınıfta override edilmesi zorunludur, burada gövdesi yoktur. Çünkü abstract bir metod
    }
}
