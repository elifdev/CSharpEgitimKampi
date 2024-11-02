using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //foreach (1;2;3;4)
            //Değişkenin türü, adı,in,ListediziKoleksiyon

            //string[] cities = { "milano", "roma" , "budapeşte" , "ankara", "istanbul", "bursa" };

            //foreach (string city in cities) 
            //{ 
            //  Console.WriteLine(city);

            //int[] numbers = { 45, 78, 985, 74, 11, 22, 33, 55, 77 };

            //foreach (int num in numbers)
            //{ 
            //  Console.WriteLine(num);
            //}


            //int[] numbers = { 45, 78, 985, 74, 11, 22, 33, 55, 77 };

            //foreach (int num in numbers)
            //{ 
            //  if (num % 2 == 0)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}


            //int[] numbers = { 45, 78, 985, 74, 11, 22, 33, 55, 77 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}

            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6
            //};

            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            //string word = "Merhaba";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}













            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
           
            
            Console.WriteLine("----------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------");

            //öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames=new string[studentCount];
            double[] studentExamAvg=new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                for(int j=0; j < 3; j++) //3 sınav notu
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz : ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;//notları topluyoruz

                }

                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
                    
            }


            //öğrencilerin ortalamasına göre geçme durumları

            for (int i = 0;i < studentCount;i++)
            {

                Console.WriteLine("----------------------------");


                Console.WriteLine($"{studentNames[i]} adlı öğrencinin not ortalaması : {studentExamAvg[i]}");

                if(studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
                }else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
                }

                Console.WriteLine("----------------------------");

            }


            #endregion

            Console.Read();
              

                
        }
    }
}
