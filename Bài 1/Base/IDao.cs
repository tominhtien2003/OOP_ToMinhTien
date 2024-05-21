using System.Collections.Generic;

namespace Bài_1.Base
{
    internal interface IDao
    {
        /*
        * thêm đối tượng vào database
        */
        void Insert(string name, ITypeObject obj);

        /*
         *Cập nhật đối tượng 
         */
        void Update(string name, int id, ITypeObject obj);

        /*
         * Xoá đối tương
         */
        void Delete(string name, int id);

        /*
         * Lấy tất cả đối tượng kiểu name
         */
        List<ITypeObject> FindAll(string name);

        /*
         * tìm đối tượng theo id
         */
        ITypeObject FindById(string name, int id);
    }
}
