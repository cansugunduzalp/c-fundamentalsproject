using System;

class Program
{
    static void Main()
    {
        // Kullanıcıya seçenekleri sunma
        Console.WriteLine("Hangi programı çalıştırmak istersiniz?");
        Console.WriteLine("1 - Rastgele Sayı Bulma Oyunu");
        Console.WriteLine("2 - Hesap Makinesi");
        Console.WriteLine("3 - Ortalama Hesaplama");

        // Kullanıcının seçim yapmasını sağlama
        Console.Write("Seçiminizi yapın (1/2/3): ");
        int secim = Convert.ToInt32(Console.ReadLine());

        // Seçime göre uygun fonksiyonu çalıştırma
        switch (secim)
        {
            case 1:
                RastgeleSayiBulmaOyunu();
                break;

            case 2:
                HesapMakinesi();
                break;

            case 3:
                OrtalamaHesaplama();
                break;

            default:
                Console.WriteLine("Geçersiz seçim.");
                break;
        }
    }

    // Rastgele Sayı Bulma Oyunu
    static void RastgeleSayiBulmaOyunu()
    {
        Random rand = new Random();
        int hedefSayi = rand.Next(1, 101); // 1 ile 100 arasında rastgele sayı
        int tahmin = 0;
        int can = 5;

        Console.WriteLine("Rastgele Sayı Bulma Oyunu başladı! 1 ile 100 arasında bir sayı tahmin edin.");

        // 5 tahmin hakkı
        while (can > 0 && tahmin != hedefSayi)
        {
            Console.Write("Tahmininizi girin: ");
            tahmin = Convert.ToInt32(Console.ReadLine());
            can--;

            if (tahmin < hedefSayi)
                Console.WriteLine("Daha yüksek bir sayı tahmin edin.");
            else if (tahmin > hedefSayi)
                Console.WriteLine("Daha düşük bir sayı tahmin edin.");
            else
                Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");

            Console.WriteLine($"Kalan can: {can}");
        }

        if (can == 0)
            Console.WriteLine($"Tahmin hakkınız bitti! Doğru sayı: {hedefSayi}");
    }

    // Hesap Makinesi
    static void HesapMakinesi()
    {
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
        Console.WriteLine("Toplama için +, Çıkarma için -, Çarpma için *, Bölme için /");
        string islem = Console.ReadLine();

        double sonuc = 0;
        bool islemYapildi = true;

        switch (islem)
        {
            case "+":
                sonuc = sayi1 + sayi2;
                break;

            case "-":
                sonuc = sayi1 - sayi2;
                break;

            case "*":
                sonuc = sayi1 * sayi2;
                break;

            case "/":
                if (sayi2 == 0)
                {
                    Console.WriteLine("Hata: Sıfıra bölme hatası!");
                    islemYapildi = false;
                }
                else
                {
                    sonuc = sayi1 / sayi2;
                }
                break;

            default:
                Console.WriteLine("Geçersiz işlem.");
                islemYapildi = false;
                break;
        }

        if (islemYapildi)
            Console.WriteLine($"Sonuç: {sonuc}");
    }

    // Ortalama Hesaplama
    static void OrtalamaHesaplama()
    {
        Console.Write("Birinci ders notunu girin: ");
        double not1 = Convert.ToDouble(Console.ReadLine());

        if (not1 < 0 || not1 > 100)
        {
            Console.WriteLine("Geçersiz not! Program sonlandırılıyor.");
            return;
        }

        Console.Write("İkinci ders notunu girin: ");
        double not2 = Convert.ToDouble(Console.ReadLine());

        if (not2 < 0 || not2 > 100)
        {
            Console.WriteLine("Geçersiz not! Program sonlandırılıyor.");
            return;
        }

        Console.Write("Üçüncü ders notunu girin: ");
        double not3 = Convert.ToDouble(Console.ReadLine());

        if (not3 < 0 || not3 > 100)
        {
            Console.WriteLine("Geçersiz not! Program sonlandırılıyor.");
            return;
        }

        double ortalama = (not1 + not2 + not3) / 3;
        Console.WriteLine($"Ortalama: {ortalama}");

        // Harf notu hesaplama
        string harfNotu = "";

        if (ortalama >= 90)
            harfNotu = "AA";
        else if (ortalama >= 85)
            harfNotu = "BA";
        else if (ortalama >= 80)
            harfNotu = "BB";
        else if (ortalama >= 75)
            harfNotu = "CB";
        else if (ortalama >= 70)
            harfNotu = "CC";
        else if (ortalama >= 65)
            harfNotu = "DC";
        else if (ortalama >= 60)
            harfNotu = "DD";
        else if (ortalama >= 55)
            harfNotu = "FD";
        else
            harfNotu = "FF";

        Console.WriteLine($"Harf notu: {harfNotu}");
    }
}
