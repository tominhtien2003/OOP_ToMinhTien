using System;
using System.Collections.Generic;
namespace Bài_1.Base
{
    public abstract class BaseRow
    {
        public int id
        {
            get;
            set;
        }
        public string name
        {
            get;
            set;
        }
        public string typename
        {
            get;
            set;
        }
        public virtual void Infor()
        {
            Console.WriteLine("Id : " + id);

            Console.WriteLine("Name : " + name);
        }

    }
}
