using Bài_1.Base;
using System;

namespace Bài_1
{
    internal class Product : BaseRow
    {
        private int categoryId;


        public Product()
        {
        }
        public Product(int id , string name ,int category)
        {

            SetId(id);
            SetName(name);
            this.categoryId = category;

        }
        /*
         * Lấy Category của product
         */
        public int GetCategory() { return categoryId; }
        /*
         * Thay đổi category của product
         */
        public void SetCategory(int category) {  this.categoryId = category;}

        /*
         * Lấy thông tin của đối tượng
         */
        public override void Infor()
        {
            base.Infor();

            Console.WriteLine("Category : " + categoryId);
        }
    }
}
