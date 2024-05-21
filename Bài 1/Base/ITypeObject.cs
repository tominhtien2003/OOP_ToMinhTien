using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    public interface ITypeObject
    {
        /*
         * Lấy Id của đối tượng
         */
        int GetId();
        /*
         * Lấy thông tin của đối tượng
         */
        void Infor();
        /*
         * thay đổi Id của đối tượng
         */
        void SetId(int id);
        /*
         * thay đổi name của đối tượng
         */
        void SetName(string name);
    }
}
