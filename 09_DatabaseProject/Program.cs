using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ado.net c#ta sql kullanmamızı sağlayan bir çerçeve

            Console.WriteLine("***** ^C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");

            Console.WriteLine();
            Console.WriteLine();


            string tableNumber;


            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış yap");
            Console.Write("Lütfen Görüntülemek İstediğiniz Tablo Numarasını Giriniz : ");
            tableNumber = Console.ReadLine();

            Console.WriteLine("-------------------------------------");
            //sqlle bağlantı
            SqlConnection connection= new SqlConnection("Data Source=ELIF\\SQLEXPRESS;initial Catalog=EgitimKampidb;integrated security=true");
            connection.Open(); //bağlantı açtık

            SqlCommand command = new SqlCommand("Select * From TblCategory",connection);
            
            SqlDataAdapter adapter = new SqlDataAdapter(command);//sorguyla c# ile sql arasında köprü

            DataTable dataTable = new DataTable(); //verileri belleğe almayı sağlar
            adapter.Fill(dataTable); 

            connection.Close(); // bağlantı kapattık

            //var bütün değişken türlerini içerir ne geleceğini bilmediğimiz yerlerde kullanılır 
            foreach ( DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine();
            }


            Console.Read();
        }
    }
}
