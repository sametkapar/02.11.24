using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public abstract class BeyazEsya
    {
        public BeyazEsya() { }
        public BeyazEsya(string isim, string marka, double fiyat) 
        {
            this.Isim = isim;
            this.Marka = marka;
            this.Fiyat = fiyat;
        }
        public string Isim { get; set; }
        public string Marka { get; set; }
        public double Fiyat { get; set; }
    }
}
