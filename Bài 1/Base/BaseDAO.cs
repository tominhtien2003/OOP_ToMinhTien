using Bài_1.dao;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Bài_1.Base
{
    internal abstract class BaseDAO 
    { 
        /*
        * thêm đối tượng vào database
        */
        protected virtual void Insert(string name ,BaseRow obj)
        {
            Database.instance.InsertTable(name, obj);
        }
        /*
         *Cập nhật đối tượng 
         */
        protected virtual void Update(string name ,int id , BaseRow obj)
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
        protected virtual List<BaseRow> FindAll(string name)
        {
            return Database.instance.SelectTable(name);
        }
        /*
         * tìm đối tượng theo id kiểu name
         */
        protected virtual BaseRow FindById(string name, int id)
        {
            foreach (BaseRow obj in Database.instance.database[name])
            {
                if (id == obj.GetId())
                {
                    return obj;
                }
            }
            return null;
        }
        /*
         * thông tin của đối tượng
         */
        public abstract void Infor(string name);
    }
}
