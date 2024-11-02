using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create - Read - Update  - Delete

            #region Kategori ekleme
            //Console.WriteLine("***** Menü Sipariş İşlem Paneli ***** ");
            //Console.WriteLine();

            //Console.WriteLine("-------------------------------");
            //Console.Write("Eklemek İstediğiniz Kategori Adı : ");
            //string categoryName=Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=ELIF\\SQLEXPRESS;initial Catalog=EgitimKampidb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);

            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Kategori Başarıyla Eklendi!");

            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;


            //Console.WriteLine("-------------------------------");


            //Console.Write("Eklemek İstediğiniz Ürün Adı : ");
            //productName = Console.ReadLine();

            //Console.Write("Eklemek İstediğiniz Ürün Fiyatı : ");
            //productPrice=decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=ELIF\\SQLEXPRESS;initial Catalog=EgitimKampidb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);

            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true); // bu değeri dışardan almıyor direk kendimiz belirliyoruz 

            //command.ExecuteNonQuery(); // değişiklikleri kaydet ve bunları veritabanına yansıt

            //connection.Close();

            //Console.WriteLine("Ürün Ekleme Başarılı!");



            #endregion


            #region Ürün Listeleme

            //SqlConnection connection = new SqlConnection("Data Source=ELIF\\SQLEXPRESS;initial Catalog=EgitimKampidb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct ", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable); // veriler dataTableda bunları görüntülemek için foreach kullanıyoruz

            //foreach ( DataRow row in dataTable.Rows)//satırları geziyor
            //{
            //    foreach (var item in row.ItemArray) // satırların içindeki sütunları geziyor
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }

            //    Console.WriteLine();
            //}


            //connection.Close();



            #endregion

            #region Ürün Silme

            //Console.Write("Silinecek Ürün Id : ");
            // int productId =int.Parse(Console.ReadLine());  

            //SqlConnection connection = new SqlConnection("Data Source=ELIF\\SQLEXPRESS;initial Catalog=EgitimKampidb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Ürün Silindi!");
            #endregion

            #region Ürün Güncelleme

            //Console.WriteLine();

            //Console.Write("Güncellenecek Ürün ID : ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı : ");
            //string productName=Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı : ");
            //decimal productPrice=decimal.Parse(Console.ReadLine());

            // SqlConnection connection = new SqlConnection("Data Source=ELIF\\SQLEXPRESS;initial Catalog=EgitimKampidb;integrated security=true");
            ////connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productName" , productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();


            //connection.Close();

            //Console.WriteLine("Ürün Güncellendi!");
            #endregion


            Console.Read();

        }
    }
}
