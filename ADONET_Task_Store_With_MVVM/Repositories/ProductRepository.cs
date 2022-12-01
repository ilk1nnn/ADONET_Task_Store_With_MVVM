using ADONET_Task_Store_With_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ADONET_Task_Store_With_MVVM.Repositories
{
    public class ProductRepository : BaseRepository
    {
        public static List<Product> RepoProducts { get; set; }

        public static void GetAllProducts()
        {
            var products = new List<Product>(); 
            using(var conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Products", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int Id = 0;
                        string Name = string.Empty;
                        decimal Price = 0;

                        Id = reader.GetFieldValue<int>(0);
                        Name = reader.GetFieldValue<string>(1);
                        Price = reader.GetFieldValue<decimal>(5);

                        Product product = new Product
                        {
                            Id = Id,
                            ProductName= Name,
                            Price = Price
                        };


                        products.Add(product);

                    }
                }


            }

            RepoProducts= products;


            

        }

        public static void DeleteProductByID(int id)
        {
            using(var conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE ProductID = @id", conn);
                cmd.Parameters.Add(new SqlParameter()
                {
                    SqlDbType = System.Data.SqlDbType.Int,
                    SqlValue = id,
                    ParameterName= "@id"
                });

                cmd.ExecuteNonQuery();

            }
        }

    }

}
