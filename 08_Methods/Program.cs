using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //mor renk küp metot anlamına gelir
            //Geriye değer döndürmeyen metotlar -void-

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Veli Yıldız");
            //    Console.WriteLine("Hakan Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");

            //}

            //CustomerList();


            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x+y;
            //    Console.WriteLine(z);

            //}

            //Sum();


            #endregion

            #region Void String Parametreli Metotlar

            //void WriteMethod()
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Hafsa ");

            //void CustomerCard( string name, string surname)
            //{
            //     Console.WriteLine("Müşteri : "+ name+ " " + surname);
            //}

            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kaya");

            #endregion

            #region Void Int Parametreli Metotlar

            //void Sum(int num1, int num2, int num3) 
            //{ 
            //  int result = num1 + num2 + num3;
            //    Console.WriteLine(result);

            //}

            //Sum(1,2,3);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //bir değişken veya sınıf türüyle tanımlanır

            //string CustomerName()
            //{
            //    return "Ruveyda Okur";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name +" " + surname;
            //}

            //Console.WriteLine(StudentCard());
            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke :" + countryName + " - Başkent: " + capital + " - Bayrak Rengi :  " + flagColor;
            //    return cardInfo;

            //}

            //string x, y, z;
            //Console.Write("Ülke adını girniz : ");
            //x= Console.ReadLine();

            //Console.Write("Başkenti girniz : ");
            //y= Console.ReadLine();

            //Console.Write("Bayrak renklerini girniz : ");
            //z= Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));


            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int num1, int num2)
            //{
            //    int result= num1 + num2;
            //    return result;
            //}

            //Console.WriteLine(Sum(1, 2));
            //Console.WriteLine(Sum(3, 2));
            //Console.WriteLine(Sum(7, 2));
            //Console.WriteLine(Sum(90, 2));


            #endregion

            #region Örnek Uygulama
            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " isimli öğrenci sınavı geçti " + " ortalama notu : " + result;
                }
                else
                {
                    return student + " isimli öğrenci sınavı geçemedi" + " ortalama notu : " + result;

                }
            }

            Console.WriteLine(ExamResult("Ali", 25, 67, 88));

            #endregion


            Console.Read();
        }
    }
}
