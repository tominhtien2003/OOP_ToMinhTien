using Bài_1.dao;
using Bài_1.Demo;
using System;

namespace Bài_1
{
    internal class Program
    {
        private const string CATEGORY = "Category";
        private const string PRODUCT = "Product";
        private const string ACCESSOTION = "Accessotion";
        static void Main(string[] args)
        {
            new Database();
            //Run Bài 2

            /*ProductDemo productDemo = new ProductDemo();

            Product product = productDemo.CreateProductTest();

            product.Infor();*/

            // Run Bài 5
            /*DatabaseDemo databaseDemo = new DatabaseDemo();

            databaseDemo.InitDatabaseDemo();

            // cháu thấy câu 7 là câu 4.3 ạ !

            databaseDemo.UpdateTableTest("Category", new Category(3, "ba ba"), 3);

            databaseDemo.PrintTableTest();*/

            //CategoryDaoDemo
            CategoryDaoDemo categoryDaoDemo = new CategoryDaoDemo();

            categoryDaoDemo.InsertTest(CATEGORY, new Category(111, "abc"));

            categoryDaoDemo.InsertTest(CATEGORY, new Category(222, "def"));

            categoryDaoDemo.UpdateTest(CATEGORY, 111, new Category(333, "xyz"));

            categoryDaoDemo.DeleteTest(CATEGORY, 111);

            categoryDaoDemo.Infor(CATEGORY);

            //ProductDaoDemo
            ProductDaoDemo productDaoDemo = new ProductDaoDemo();

            productDaoDemo.InsertTest(PRODUCT, new Product(111, "abc",111));

            productDaoDemo.InsertTest(PRODUCT, new Product(222, "def",222));

            productDaoDemo.UpdateTest(PRODUCT, 111, new Product(333, "xyz",333));

            productDaoDemo.DeleteTest(PRODUCT, 111);

            productDaoDemo.Infor(PRODUCT);

        }
    }
}
