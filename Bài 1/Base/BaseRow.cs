using System;
using System.Collections.Generic;
namespace Bài_1.Base
{
    public abstract class BaseRow
    {
        public int id
        {
            get { return id; }
            set { id = value; }
        }
        public string name
        {
            get { return name; }
            set { name = value; }
        }
        public string typename
        {
            get { return typename; }
            set {  typename = value; }
        }
        public virtual void Infor()
        {
            Console.WriteLine("Id : " + id);

            Console.WriteLine("Name : " + name);
        }

    }
}
