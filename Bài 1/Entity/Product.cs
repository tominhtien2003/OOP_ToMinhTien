using Bài_1.Base;
using System;

namespace Bài_1
{
    public class Product : BaseRow
    {
        public int categoryId
        {
            get;
            set;
        }


        public Product()
        {
        }
        public Product(int id , string name ,int category)
        {

            this.id = id;
            this.name = name;
            this.categoryId = category;
            typename = "Product";

        }
        /// <summary>
        /// Take all information of obj
        /// </summary>
        public override void Infor()
        {
            base.Infor();

            Console.WriteLine("Category : " + categoryId);
        }
    }
}
