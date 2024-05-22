using Bài_1.dao;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Bài_1.Base
{
    public abstract class BaseDAO 
    { 
        /// <summary>
        /// Add a object
        /// </summary>
        /// <param name="obj">Object need add</param>
        protected virtual void Insert(BaseRow obj)
        {
            Database.instance.InsertTable(obj);
        }
        /// <summary>
        /// update obj with id
        /// </summary>
        /// <param name="id">id of obj need update</param>
        /// <param name="obj">need is update</param>
        protected virtual void Update(int id , BaseRow obj)
        {
            Database.instance.UpdateTable(obj, id);
        }
        /// <summary>
        /// Delete a object with id and typename is name
        /// </summary>
        /// <param name="name">typename of obj</param>
        /// <param name="id">id of obj need delete</param>
        protected virtual void Delete(string name,int id)
        {
            Database.instance.DeleteTable(name, id);
        }
        /// <summary>
        /// Take list all obj typename is name
        /// </summary>
        /// <param name="name">typename of obj</param>
        /// <returns>a list obj typename is name</returns>
        protected virtual List<BaseRow> FindAll(string name)
        {
            return Database.instance.SelectTable(name);
        }
        /// <summary>
        /// Find obj with id and typename is name
        /// </summary>
        /// <param name="name">typename of obj need find</param>
        /// <param name="id">id of obj need find</param>
        /// <returns></returns>
        protected virtual BaseRow FindById(string name, int id)
        {
            foreach (BaseRow obj in Database.instance.stores[name])
            {
                if (id == obj.id)
                {
                    return obj;
                }
            }
            return null;
        }
        /// <summary>
        /// Take information of obj
        /// </summary>
        /// <param name="name">typename of obj need take infor</param>
        public abstract void Infor(string name);
    }
}
