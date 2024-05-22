using Bài_1.Base;
using Bài_1.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1.Demo
{
    internal class ProductDaoDemo : ProductDAO
    {
        /*
         * Xoá 1 đối tượng với kiểu name có id 
         */
        public void DeleteTest(string name, int id)
        {
            base.Delete(name, id);
        }
        /*
         * Lấy tất cả các đối tượng có kiểu name
         */
        public List<BaseRow> FindAllTest(string name)
        {
            return base.FindAll(name);
        }
        /*
         * Lấy đối tượng với id và kiểu name
         */
        public BaseRow FindByIdTest(string name, int id)
        {
            return base.FindById(name, id);
        }
        /*
         * Thêm đối tượng kiểu name
         */
        public void InsertTest(string name, BaseRow _object)
        {
            base.Insert(name, _object);
        }
        /*
         * Cập nhật đối tượng kiểu name với id
         */
        public void UpdateTest(string name, int id, BaseRow obj)
        {
            base.Update(name, id, obj);
        }
    }
}
