using Bài_1.Base;
using Bài_1.dao;
using Bài_1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1.Demo
{
    public   class DatabaseDemo : Database
    {
        /// <summary>
        /// Insert a object
        /// </summary>
        /// <param name="obj">Object need add</param>
        public void InsertTableTest(BaseRow obj)
        {
            InsertTable(obj);
        }
        /// <summary>
        /// Take all object have type name
        /// </summary>
        /// <param name="name">Type of object</param>
        /// <returns>List object have type name</returns>
        public List<BaseRow> SelectTableTest(string name)
        {
            return SelectTable(name);
        }
        /// <summary>
        /// Update object with id
        /// </summary>
        /// <param name="obje">obje is update</param>
        /// <param name="id">id of object update</param>
        public void UpdateTableTest(BaseRow obj, int id)
        {
            UpdateTable(obj, id);
        }
        /// <summary>
        /// Delete object with id and type name
        /// </summary>
        /// <param name="name">type name of obj</param>
        /// <param name="id">id of object need delete</param>
        public void DeleteTableTest(string name, int id)
        {
            DeleteTable(name , id);
        }
        /// <summary>
        /// Delete all object
        /// </summary>
        public void TruncateTableTest()
        {
            TruncateTable();
        }
        /// <summary>
        /// Init object
        /// </summary>
        public void InitDatabaseDemo()
        {
            // cháu dùng tên = "a" kéo dài cho tiện ạ . Tại vì chỉ là demo.
            string name_ = "";

            for (int i = 0; i < 10; i++)
            {
                name_ += "a";

                InsertTableTest(new Product(i,name_,i));
            }
            name_ = "";

            for (int i = 0; i < 10; i++)
            {
                name_ += "a";

                InsertTableTest(new Category(i, name_));
            }
            name_ = "";

            for (int i = 0; i < 10; i++)
            {
                name_ += "a";

                InsertTableTest(new Accessotion(i, name_));
            }
        }
        /// <summary>
        /// Print infor of all object in database store
        /// </summary>
        public void PrintTableTest()
        {
            foreach (string name in stores.Keys)
            {
                List<BaseRow> list = stores[name];

                foreach (BaseRow obj in list)
                {
                    obj.Infor();
                }
            }
        }
        
    }
}
