using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    internal class BulasikMakinesi : BeyazEsya
    {
        public BulasikMakinesi() { }
        public BulasikMakinesi(string isim, string marka, double fiyat, string enerjisinifi, int kisisayisi)
            :base(isim,marka,fiyat)
        {
            this.EnerjiSinifi = enerjisinifi;
            this.KisiSayisi = kisisayisi;
        }
        public string EnerjiSinifi { get; set; }
        public int KisiSayisi  { get; set; }
    }
}
