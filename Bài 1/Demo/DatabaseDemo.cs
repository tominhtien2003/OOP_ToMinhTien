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
    internal class DatabaseDemo : Database
    {
        /*
         * Thêm đối tượng kiểu name
         */
        public void InsertTableTest(string name , BaseRow _object)
        {
            InsertTable(name , _object);
        }
        /*
         * Lấy tất cả đối tượng kiểu name
         */
        public List<BaseRow> SelectTableTest(string name)
        {
            return SelectTable(name);
        }
        /*
         * Cập nhật đối tượng kiểu name với id
         */
        public void UpdateTableTest(string name, BaseRow _object, int id)
        {
            UpdateTable(name , _object, id);
        }
        /*
         * Xoá đối tượng với id kiểu name
         */
        public void DeleteTableTest(string name, int id)
        {
            DeleteTable(name , id);
        }
        /*
         * Xoá toàn bộ đối tượng
         */
        public void TruncateTableTest()
        {
            TruncateTable();
        }
        /*
         * Khởi tạo đối tượng
         */
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
        /*
         * Xuất ra thông tin của tất cả đối tươgn
         */
        public void PrintTableTest()
        {
            foreach (string name in database.Keys)
            {
                List<BaseRow> list = database[name];

                foreach (BaseRow obj in list)
                {
                    obj.Infor();
                }
            }
        }
        
    }
}
