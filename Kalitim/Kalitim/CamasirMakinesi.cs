using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class CamasirMakinesi : BeyazEsya
    {
        public CamasirMakinesi () { }
        public CamasirMakinesi(string isim, string marka, double fiyat, int progamsayisi, bool kurutma)
        {
            base.Fiyat=fiyat;
            base.Marka = marka;
            base.Fiyat = fiyat;
            this.ProgramSayisi = progamsayisi;
            this.Kurutma = kurutma;
        }
        //c# Çoklu kalıtım kabul etmez
        public bool Kurutma { get; set; }
        public int ProgramSayisi { get; set; }
    }
}
