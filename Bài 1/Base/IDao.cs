using System.Collections.Generic;

namespace Bài_1.Base
{
    public interface IDao
    {
        /*
        * thêm đối tượng vào database
        */
        void Insert(string name, BaseRow obj);

        /*
         *Cập nhật đối tượng 
         */
        void Update(string name, int id, BaseRow obj);

        /*
         * Xoá đối tương
         */
        void Delete(string name, int id);

        /*
         * Lấy tất cả đối tượng kiểu name
         */
        List<BaseRow> FindAll(string name);

        /*
         * tìm đối tượng theo id
         */
        BaseRow FindById(string name, int id);
    }
}
