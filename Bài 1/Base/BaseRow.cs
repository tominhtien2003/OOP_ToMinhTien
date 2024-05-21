using System;
using System.Collections.Generic;
namespace Bài_1.Base
{
    public abstract class BaseRow
    {
        protected int id;
        protected string name; 

        /*
         * Lấy Id của đối tượng
         */
        public virtual int GetId()
        {
            return id;
        }
        /*
         * Lấy tên của đối tượng
         */
        public virtual string GetName()
        {
            return name;
        }
        /*
         * thay đổi Id của đối tượng
         */
        public virtual void SetId(int id)
        {
            this.id = id;
        }
        /*
         * thay đổi name của đối tượng
         */
        public virtual void SetName(string name)
        {
            this.name = name;
        }
        /*
         * Lấy thông tin của đối tượng
         */
        public virtual void Infor()
        {
            Console.WriteLine("Id : " + id);

            Console.WriteLine("Name : " + name);
        }

    }
}
