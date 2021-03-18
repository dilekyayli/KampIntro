using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 10002451;
            musteri1.MusteriAdi = "Saliha";
            musteri1.MusteriSoyadi = "YAYLI";
            musteri1.KrediTipi = "Konut Kredisi";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 20365214;
            musteri2.MusteriAdi = "Sedat";
            musteri2.MusteriSoyadi = "YAYLI";
            musteri2.KrediTipi = "İhtiyaç Kredisi";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 34789630;
            musteri3.MusteriAdi = "Uğur";
            musteri3.MusteriSoyadi = "YAYLI";
            musteri3.KrediTipi = "Taşıt Kredisi";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 41025463;
            musteri4.MusteriAdi = "Dilek";
            musteri4.MusteriSoyadi = "YAYLI";
            musteri4.KrediTipi = "Ticari Kredi";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Sil(musteri3);
            musteriManager.Sil(musteri4);

        }
    }
}
