using Bài_1.dao;
using Bài_1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1.Demo
{
    internal class DatabaseDemo : Database
    {
        public void InsertTableTest(string name , ITypeObject _object)
        {
            InsertTable(name , _object);
        }
        public List<ITypeObject> SelectTableTest(string name)
        {
            return SelectTable(name);
        }
        public void UpdateTableTest(string name, ITypeObject _object, int id)
        {
            UpdateTable(name , _object, id);
        }
        public void DeleteTableTest(string name, ITypeObject _object, int id)
        {
            DeleteTable(name , _object, id);
        }
        public void TruncateTableTest()
        {
            TruncateTable();
        }
        public void InitDatabaseDemo()
        {
            // cháu dùng tên = "a" kéo dài cho tiện ạ . Tại vì chỉ là demo.
            string name_ = "";
            for (int i = 0; i < 10; i++)
            {
                name_ += "a";
                InsertTableTest("Product",new Product(i,name_,i));
            }
            name_ = "";
            for (int i = 0; i < 10; i++)
            {
                name_ += "a";
                InsertTableTest("Category", new Category(i, name_));
            }
            name_ = "";
            for (int i = 0; i < 10; i++)
            {
                name_ += "a";
                InsertTableTest("Accessotion", new Accessotion(i, name_));
            }
        }
        public void PrintTableTest()
        {
            foreach (string name in database.Keys)
            {
                List<ITypeObject> list = database[name];
                foreach (ITypeObject obj in list)
                {
                    obj.Infor();
                }
            }
        }
        
    }
}
