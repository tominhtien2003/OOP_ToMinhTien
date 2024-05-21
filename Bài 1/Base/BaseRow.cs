using System;
using System.Collections.Generic;
namespace Bài_1.Base
{
    internal abstract class BaseRow
    {
        /*
         * Lấy Id của đối tượng
         */
        protected abstract int GetId();
        /*
         * Lấy thông tin của đối tượng
         */
        protected abstract void Infor();
        /*
         * thay đổi Id của đối tượng
         */
        protected abstract void SetId(int id);
        /*
         * thay đổi name của đối tượng
         */
        protected abstract void SetName(string name);

    }
}
