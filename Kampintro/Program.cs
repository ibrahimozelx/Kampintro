using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği
            //Do not repeat yourself- Kendini tekrarlama
            // değer tutucu
            
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarBugun = 7.55;
            double dolarDun = 8.05;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);



        }
    }
}
