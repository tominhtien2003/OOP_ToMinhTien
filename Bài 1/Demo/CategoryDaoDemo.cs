using Bài_1.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1.Demo
{
    internal class CategoryDaoDemo : Database
    {
        private const string CATEGORY = "Category";
        public void InsertTest(Category _object)
        {
            InsertTable(CATEGORY, _object);
        }
        public void UpdateTest(Category _object , int id)
        {
            UpdateTable(CATEGORY, _object , id);
        }
        public List<ITypeObject> FindAllTest()
        {
            return SelectTable(CATEGORY);
        }
    }
}
