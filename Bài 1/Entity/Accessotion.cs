using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1.Entity
{
    internal class Accessotion : ITypeObject
    {
        private int id;
        private string name;
        public Accessotion() { }
        public Accessotion(int id, string name)
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
