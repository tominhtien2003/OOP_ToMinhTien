using Bài_1.Base;
using System;
namespace Bài_1
{
    internal class Category : BaseRow
    {
        public Category() { }
        public Category(int id, string name)
        {
            SetId(id);
            SetName(name);
        }
    }
}
