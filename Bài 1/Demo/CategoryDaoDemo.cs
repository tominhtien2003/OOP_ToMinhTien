using Bài_1.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1.Demo
{
    internal class CategoryDaoDemo : CategoryDAO
    {
        public void DeleteTest(string name, int id)
        {
            Delete(name, id);
        }
        public List<ITypeObject> FindAllTest(string name)
        {
            return FindAll(name);
        }

        public ITypeObject FindByIdTest(string name, int id)
        {
            return base.FindById(name, id);
        }

        public void InsertTest(string name, ITypeObject _object)
        {
            Insert(name, _object);
        }

        public void UpdateTest(string name, int id, ITypeObject obj)
        {
            Update(name, id, obj);
        }
    }
}
