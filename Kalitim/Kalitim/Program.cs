using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BeyazEsya esya = new BeyazEsya();
            //esya.Isim = "Deneme";
            //esya.Marka = "Deneme";
            //esya.Fiyat = 50;

            CamasirMakinesi cm = new CamasirMakinesi();
            cm.Marka = "Bosch";
            cm.ProgramSayisi = 3;
            cm.Kurutma = true;
            cm.Isim = "BO159";
            cm.Fiyat = 9999.99;

            BulasikMakinesi bm = new BulasikMakinesi();

            bm.Marka = "Arçelik";
            bm.Isim = "AR999";
            bm.KisiSayisi = 6;
            bm.Fiyat = 93939;
            bm.EnerjiSinifi = "G";

            List<BeyazEsya> esyalar = new List<BeyazEsya>();
            esyalar.Add(cm);
            esyalar.Add(bm);
            for (int i = 0; i < esyalar.Count; i++) 
            {
                Console.WriteLine($"{esyalar[i].Isim} {esyalar[i].Marka} {esyalar[i].Fiyat}");
            }
        }
    }
}
