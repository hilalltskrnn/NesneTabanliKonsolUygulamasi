using System;

namespace Proje_tasitlar
{

    public class Tasitlar
    {
        public string tasit_turu;  //Absraction -- Soyutlama

        public string Tasit_Turu   // Encapsulation -- Kapsülleme
        {
            get { return tasit_turu; }
            set { tasit_turu = value; }
        }


        public string hareket_yeri;  //Absraction -- Soyutlama
        public string Hareket_Yeri   // Encapsulation -- Kapsülleme
        {
            get { return hareket_yeri; }
            set { hareket_yeri = value; }
        }

        public int azami_hizi;    //Absraction -- Soyutlama
        public int Azami_hizi   // Encapsulation -- Kapsülleme
        {
            get { return azami_hizi; }
            set { azami_hizi = value; }
        }

        public virtual void TasitlariYazdir() //Polymorphism -- Çok Biçimlilik (Miras alınan özelliklerin değiştirilebilmesi ve nesne üzerinden çağrılabilmesi)
        {
            Console.WriteLine($"Taşıtın türü: {this.tasit_turu}\nHareket Yeri: {this.hareket_yeri}\nAzami Hızı: {this.azami_hizi}");
        }

    }

    public class KaraTasitlari : Tasitlar  // Inheritance -- Kalıtım
    {
        public string ornek_tasit;  // Kara taşıtlarına örnek taşıt özelliğini ekledim
        public string Ornek_Tasit
        {
            get { return ornek_tasit; }
            set { ornek_tasit = value; }
        }

        public override void TasitlariYazdir()
        {
            base.TasitlariYazdir();
            Console.WriteLine($"Örnek Taşıt: {this.ornek_tasit}");
        }


    }

    public class HavaTasitlari : KaraTasitlari  // Inheritance -- Kalıtım
    {
        public int yolcu_kapasitesi;  // Hava taşıtlarına yolcu kapasite özelliğini ekledim
        public int Yolcu_Kapasitesi
        {
            get { return yolcu_kapasitesi; }
            set { yolcu_kapasitesi = value; }
        }

        public override void TasitlariYazdir()
        {
            base.TasitlariYazdir();
            Console.WriteLine($"Yolcu Kapasitesi: {this.yolcu_kapasitesi}");
        }


    }

    public class DenizTasitlari : HavaTasitlari  // Inheritance -- Kalıtım
    {
        public int tasit_uzunlugu;  // Deniz taşıtlarına taşıt uzunluğu özelliğini ekledim
        public int Tasit_Uzunluğu
        {
            get { return tasit_uzunlugu; }
            set { tasit_uzunlugu = value; }
        }

        public override void TasitlariYazdir()
        {
            base.TasitlariYazdir();
            Console.WriteLine($"Taşıt Uzunluğu: {this.tasit_uzunlugu}");
        }


    }

    public class RayliSistemTasitlari : DenizTasitlari  // Inheritance -- Kalıtım
    {
        public int tasit_maliyeti; // Rayli sistem taşıtlarına taşıt maliyeti özelliğini ekledim
        public int Tasit_Maliyeti
        {
            get { return tasit_maliyeti; }
            set { tasit_maliyeti = value; }
        }

        public override void TasitlariYazdir()
        {
            base.TasitlariYazdir();
            Console.WriteLine($"Tasıt Maliyeti: {this.tasit_maliyeti}");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Taşıtlar---------------");
            KaraTasitlari kara = new KaraTasitlari();
            kara.tasit_turu = "Kara Taşıtı";
            kara.hareket_yeri = "Kara";
            kara.azami_hizi = 240;
            kara.ornek_tasit = "Araba";

            kara.TasitlariYazdir();

            Console.WriteLine("------------------------------------");
            HavaTasitlari hava = new HavaTasitlari();
            hava.tasit_turu = "Hava Taşıtı";
            hava.hareket_yeri = "Hava";
            hava.azami_hizi = 500;
            hava.ornek_tasit = "Uçak";
            hava.yolcu_kapasitesi = 555;
            hava.TasitlariYazdir();

            Console.WriteLine("------------------------------------");
            DenizTasitlari deniz = new DenizTasitlari();
            deniz.tasit_turu = "Deniz Taşıtı";
            deniz.hareket_yeri = "Deniz";
            deniz.azami_hizi = 300;
            deniz.ornek_tasit = "Gemi";
            deniz.yolcu_kapasitesi = 200;
            deniz.tasit_uzunlugu = 50;

            deniz.TasitlariYazdir();

            Console.WriteLine("------------------------------------");
            RayliSistemTasitlari rayli = new RayliSistemTasitlari();
            rayli.tasit_turu = "Rayli Sistem Taşıtı";
            rayli.hareket_yeri = "Ray";
            rayli.azami_hizi = 400;            // km cinsinden
            rayli.ornek_tasit = "Tren";
            rayli.yolcu_kapasitesi = 450;
            rayli.tasit_uzunlugu = 150;        // m cinsinden
            rayli.tasit_maliyeti = 100000000;  // TLs cinsinden

            rayli.TasitlariYazdir();


        }
    }

}
