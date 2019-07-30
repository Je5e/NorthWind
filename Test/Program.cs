using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NWind.DAL;
using NWind.Entities;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddCategoryAndProduct();
            AddProduct();
            Console.WriteLine("Presione <enter> para finalizar");
            Console.ReadLine();
        }

        static void AddCategoryAndProduct()
        {
            Category c = new Category()
            {
                CategoryName = "Cereales",
                Description = "Produtos de Maíz"
            };

            Product Cereal = new Product()
            {
                ProductName="Cereal",
                UnitsInStock = 0,
                UnitPrice = 15
            };

            c.Products.Add(Cereal);

            using (var r = RepositoryFactory.CreateRepository())
            {
                r.Create<Category>(c);
            }
            Console.WriteLine($"Categoría: {c.CategoryID}, Prodcuto: {Cereal.ProductID}");
        }

        static void AddProduct()
        {
            Product Avena = new Product()
            {
                CategoryID = 1,
                UnitsInStock =100,
                UnitPrice = 10,
                ProductName = "Avena"
            };
            using (var r = RepositoryFactory.CreateRepository())
            {
                r.Create(Avena);
            }
            Console.WriteLine($"Producto: {Avena.ProductID}");
        }
    }
}
