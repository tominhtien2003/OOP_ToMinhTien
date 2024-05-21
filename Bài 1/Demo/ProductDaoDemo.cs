using Bài_1.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1.Demo
{
    internal class ProductDaoDemo : Database
    {
        private const string PRODUCT = "Product";
        public void InsertTest(Category _object)
        {
            InsertTable(PRODUCT, _object);
        }
        public void UpdateTest(Category _object, int id)
        {
            UpdateTable(PRODUCT, _object, id);
        }
        public List<ITypeObject> FindAllTest()
        {
            return SelectTable(PRODUCT);
        }
    }
}
