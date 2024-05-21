using Bài_1.Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Run Bài 2
            ProductDemo productDemo = new ProductDemo();

            Product product = productDemo.CreateProductTest();

            product.Infor();

            // Run Bài 5
            DatabaseDemo databaseDemo = new DatabaseDemo();

            databaseDemo.InitDatabaseDemo();

            // cháu thấy câu 7 là câu 4.3 ạ !

            databaseDemo.UpdateTableTest("Category", new Category(3, "ba ba"), 3);

            databaseDemo.PrintTableTest();
        }
    }
}
