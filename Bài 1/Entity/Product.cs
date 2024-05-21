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
        public int GetCategory() { return categoryId; }
        public void SetCategory(int category) {  this.categoryId = category;}

        public override void Infor()
        {
            base.Infor();

            Console.WriteLine("Category : " + categoryId);
        }
    }
}
