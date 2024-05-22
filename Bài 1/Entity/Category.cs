using Bài_1.Base;
using System;
namespace Bài_1
{
    public class Category : BaseRow
    {
        public Category() { }
        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
            typename = "Category";
        }
    }
}
