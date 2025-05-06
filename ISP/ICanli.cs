using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal interface ICanli
    {
        // Yanlis, ISP ilkesine uymaz
        void Yuru();
        void Kos();
        void Uc();
        void Yuz();
    }
}
