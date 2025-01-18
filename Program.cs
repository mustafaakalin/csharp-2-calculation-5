using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Eğitim Durumuna Göre burs Hesaplama (Switch Case)
            // lise ve ortaöğretim için 3000 ₺
            // önlisans ve lisans için 4000 ₺
            // yüksek lisans ve doktora için 5000 ₺
            // eğer eğitim durumu girilmezse 0 ₺
            // eğitim durumu yanlış girilirse 0 ₺
            // eğitim durumu girilince burs miktarını ekrana yazdırınız.
            start:
            Console.WriteLine("############## EGITIM DUZEYI SECENEKLERI ##############\nlise\nortaöğretim\nön lisans\nlisans\nyüksek lisans\ndoktora\n##############\nEğitim Durumunuzu Giriniz: ");
            string egitimDurumu = Console.ReadLine();
            int bursMiktari = 0;

            switch (egitimDurumu)
            {
                case "lise":
                case "ortaöğretim":
                    bursMiktari = 3000;
                    Console.WriteLine("Burs Miktarınız: " + bursMiktari + " ₺");
                    break;
                case "ön lisans":
                case "lisans":
                    bursMiktari = 4000;
                    Console.WriteLine("Burs Miktarınız: " + bursMiktari + " ₺");
                    break;
                case "yüksek lisans":
                case "doktora":
                    bursMiktari = 5000;
                    Console.WriteLine("Burs Miktarınız: " + bursMiktari + " ₺");
                    break;
                default:
                    Console.WriteLine("HATALI GIRIS: PROGRAM BASA DONULUYOR ");
                    goto start;
                    // break;
            }

            // Console.WriteLine("Hello World!");
        }
    }
}