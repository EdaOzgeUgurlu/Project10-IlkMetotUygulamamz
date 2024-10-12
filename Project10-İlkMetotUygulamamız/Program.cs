using System;

class Program
{
    //Geriye Değer Döndürmeyen Bir void metot.
    static void SarkıSözü() // void tekrar döndürmez
    {
        string sarkiSözü = ("Hiçbir yüz güzel değil senin yüzünden!");
        Console.WriteLine($"Sevdiğim şarkı sözü: {sarkiSözü}");
    }


    // Geriye tamsayı döndüren bir metot
    static int TamSayı()
    {
        Random random = new Random(); //rasgele bir sayı üretmek için kullanıyoruz.
        int tamSayi = random.Next(0, 100); // 0-100 arasında rastgele bir sayı üret
        return tamSayi % 2; // 2'ye bölümünden kalanı döndür
    }


    // Parametre Alan ve Geriye Değer Döndüren Metot
    static int Carpma(int sayi1, int sayi2)
    {
        return sayi1 * sayi2; // İki sayının çarpımını döndür
    }



    // Parametre Alan ve Geriye Değer Döndürmeyen Metot
    static void HosGeldin(string isim, string soyisim)
    {
        Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}!"); 
    }



    static void Main(string[] args)
    {
        SarkıSözü(); // Metodu çağır

        int sonuc = TamSayı(); // Metodu çağır ve sonucu al
        Console.WriteLine($"Rastgele sayı mod 2 sonucu: {sonuc}");

        // Çarpma metodunu kullanma
        // Kullanıcıdan sayıları al
        Console.Write("Birinci sayıyı girin: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        int carpim = Carpma(sayi1, sayi2);
        Console.WriteLine($"Çarpım sonucu: {carpim}");

        // Hoş geldin metodunu kullanma
        // Kullanıcıdan verileri al
        Console.Write("isminizi girin: ");
        string isim = (Console.ReadLine());

        Console.Write("soyisminizi girin: ");
        string soyisim = (Console.ReadLine());

        HosGeldin(isim, soyisim); 


        Console.ReadKey();
    }
}