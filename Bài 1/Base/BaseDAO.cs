using Bài_1.dao;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Bài_1.Base
{
    internal abstract class BaseDAO 
    {
        //Ở đây cháu dùng virual để có thêm lớp cơ sở .

        /*
        * thêm đối tượng vào database
        */
        public abstract void Infor(string name);
        protected virtual void Insert(string name,ITypeObject obj)
        {
            Database.instance.InsertTable(name, obj);
        }
        /*
         *Cập nhật đối tượng 
         */
        protected virtual void Update(string name,int id, ITypeObject obj)
        {
            Database.instance.UpdateTable(name, obj, id);
        }
        /*
         * Xoá đối tương
         */
        protected virtual void Delete(string name,int id)
        {
            Database.instance.DeleteTable(name, id);
        }
        /*
         * Lấy tất cả đối tượng kiểu name
         */
        protected virtual List<ITypeObject> FindAll(string name)
        {
            return Database.instance.SelectTable(name);
        }
        /*
         * tìm đối tượng theo id
         */
        protected virtual ITypeObject FindById(string name, int id)
        {
            foreach (ITypeObject obj in Database.instance.database[name])
            {
                if (id == obj.GetId())
                {
                    return obj;
                }
            }
            return null;
        }

    }
}
