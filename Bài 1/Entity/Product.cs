using System;

namespace Bài_1
{
    internal class Product : ITypeObject
    {

        private int id;

        private string name;

        private int categoryId;


        public Product()
        {
        }
        public Product(int id, string name, int category)
        {

            this.id = id;

            this.name = name;

            this.categoryId = category;

        }
        public int GetId() { return id; }
        public string GetName() { return name; }
        public int GetCategory() { return categoryId; }
        public void SetId(int id) { this.id = id;}
        public void SetName(string name) {  this.name = name;}
        public void SetCategory(int category) {  this.categoryId = category;}

        public void Infor()
        {

            Console.WriteLine("Id : " + id);

            Console.WriteLine("Name : " + name);

            Console.WriteLine("Category : " + categoryId);

        }
    }
}
