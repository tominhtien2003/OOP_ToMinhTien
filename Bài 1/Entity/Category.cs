using System;
using System.Collections.Generic;
namespace Bài_1
{
    internal class Category : ITypeObject
    {
        private int id;

        private string name;

        public Category() { }
        public Category(int id, string name)
        {

            this.id = id;

            this.name = name;

        }

        public int GetId() { return id; }
        public string GetName() { return name; }

        public void SetId(int id) { this.id = id; }
        public void SetName(string name) { this.name = name; }
        public void Infor()
        {

            Console.WriteLine("Id : " + id);

            Console.WriteLine("Name : " + name);

        }
    }
}
