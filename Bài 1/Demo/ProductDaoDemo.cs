using Bài_1.Base;
using Bài_1.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1.Demo
{
    internal class ProductDaoDemo : ProductDAO
    {
        public void DeleteTest(string name, int id)
        {
            base.Delete(name, id);
        }
        public List<BaseRow> FindAllTest(string name)
        {
            return base.FindAll(name);
        }

        public BaseRow FindByIdTest(string name, int id)
        {
            return base.FindById(name, id);
        }

        public void InsertTest(string name, BaseRow _object)
        {
            base.Insert(name, _object);
        }

        public void UpdateTest(string name, int id, BaseRow obj)
        {
            base.Update(name, id, obj);
        }
    }
}
