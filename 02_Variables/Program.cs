using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;    
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("---- Elma Birim Fiyatı :" + applePrice + " ₺");
            //Console.WriteLine("---- Portakal Birim Fiyatı :" + orangePrice + " ₺");
            //Console.WriteLine("---- Çilek Birim Fiyatı :" + strawberryPrice + " ₺");
            //Console.WriteLine("---- Patates Birim Fiyatı :" + potatoPrice + " ₺" );
            //Console.WriteLine("---- Domates Birim Fiyatı :" + tomatoPrice + " ₺");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            ////Console.WriteLine("Elmanın toplam fiyatı :" + appleTotalPrice);

            //Console.WriteLine();

            //Console.WriteLine("Alınan Ürün : Elma -" + "Birim fiyat : " + applePrice + " - Gramaj : " + appleGram + "- Toplam tutar : " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün : Portakal -" + "Birim fiyat : " + orangePrice + " - Gramaj : " + orangeGram + "- Toplam tutar : " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün : Çilek -" + "Birim fiyat : " + strawberryPrice + " - Gramaj : " + strawberryGram + "- Toplam tutar : " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün : Patates -" + "Birim fiyat : " + potatoPrice + " - Gramaj : " + potatoGram + "- Toplam tutar : " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün : Domates -" + "Birim fiyat : " + tomatoPrice + " - Gramaj : " + tomatoGram + "- Toplam tutar : " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar :" + shoppingTotalPrice + "₺");

            #endregion

            #region Char Değişkenler

            //Caesar cipher, (also known as the Caesar method or Caesar shift) is a method of encryption where the letters in a text are replaced by the characters 3 positions ahead.

            //char symbol;

            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgileri ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Şehir Bilgisi : ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Yolcu Yaş : ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No : ");
            //passengerIdentityNumber = Console.ReadLine();



            //Console.WriteLine();

            //Console.WriteLine("--------------------");
            //Console.WriteLine("Yolcu TC Kimlik No : " + passengerIdentityNumber + " "+"Yolcu Ad Soyad : " + passengerName + " " + passengerSurname + " " + passengerDistrict + "/" + passengerCity + " " + passengerAge);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chaircount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz : ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz : ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz : ");
            //chaircount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz : ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoeCount* shoePrice + computerCount* computerPrice + chaircount*chairPrice + tvCount* tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar :" + totalPrice);
            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri 

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav Notunu Giriniz");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav Notunu Giriniz");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav Notunu Giriniz");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız : " + result);


            #endregion

            #region Klavyeden Karakter Girişleri 

            //char gender;
            //Console.Write("Lütfen cinsiyet giriniz E/K : " );
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Girilen Cinsiyet :" + gender);

            #endregion




            Console.Read();
            


        }
    }
}
