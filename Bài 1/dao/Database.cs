using Bài_1.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Bài_1.dao
{
    public class Database
    {
        public static Database instance { get; private set; }
        public Dictionary<string, List<BaseRow>> stores;
        
        public Database()
        {
            if (instance == null)
            {
                stores = new Dictionary<string, List<BaseRow>>();
                instance = this;
            }
            else
            {
                Console.WriteLine("singleton is init");
                return;
            }      
        }
        /// <summary>
        /// Insert a object
        /// </summary>
        /// <param name="obj">Object need add</param>
        public void InsertTable(BaseRow obj)
        {
            if (!stores.ContainsKey(obj.typename))
            {

                stores[obj.typename] = new List<BaseRow>();
            }

            stores[obj.typename].Add(obj);
        }
        /// <summary>
        /// Take all object have type name
        /// </summary>
        /// <param name="name">Type of object</param>
        /// <returns>List object have type name</returns>
        public List<BaseRow> SelectTable(string name)
        {
            List<BaseRow> result = stores[name];

            return result;
        }
        /// <summary>
        /// Update object with id
        /// </summary>
        /// <param name="obje">obje is update</param>
        /// <param name="id">id of object update</param>
        public void UpdateTable(BaseRow obje,int id)
        {
            if (!stores.ContainsKey(obje.typename))
            {
                Console.WriteLine("Don't have object type " + obje.typename);
            }
            else
            {
                foreach (BaseRow obj in stores[obje.typename])
                {
                    if (obj.id == id)
                    {
                        int index = stores[obje.typename].IndexOf(obj);

                        stores[obje.typename][index] = obje;

                        return;
                    }
                }
            }
        }
        /// <summary>
        /// Delete object with id and type name
        /// </summary>
        /// <param name="name">type name of obj</param>
        /// <param name="id">id of object need delete</param>
        public void DeleteTable(string name,int id)
        {
            if (!stores.ContainsKey(name))
            {
                Console.WriteLine("Don't have object type " + name);
            }
            else
            {
                foreach (BaseRow obj in stores[name])
                {
                    if (obj.id == id)
                    {
                        stores[name].Remove(obj);

                        return;
                    }
                }
            }
        }
        /// <summary>
        /// Delete all object
        /// </summary>
        public void TruncateTable()
        {
            foreach (string name in stores.Keys)
            {
                stores[name].Clear();
            }
        }
    }
}
