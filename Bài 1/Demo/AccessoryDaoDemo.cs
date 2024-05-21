using Bài_1.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1.Demo
{
    internal class AccessoryDaoDemo : AccessoryDAO
    {
        public void DeleteTest(string name, int id)
        {
            ExcuteMethod(ChooseMethodVoid.Delete, name, id);
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
            ExcuteMethod(ChooseMethodVoid.Insert, name, 0, _object);
        }

        public void UpdateTest(string name, int id, ITypeObject obj)
        {
            ExcuteMethod(ChooseMethodVoid.Update, name, id, obj);
        }
    }
}
