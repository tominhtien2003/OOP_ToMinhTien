using Bài_1.Base;
using System.Collections.Generic;

namespace Bài_1.dao
{
    internal class CategoryDAO : BaseDAO
    {
        public void ExcuteMethod(ChooseMethodVoid chooseMethodVoid, string name, int id = 0, ITypeObject _object = null)
        {
            switch (chooseMethodVoid)
            {
                case ChooseMethodVoid.Delete:
                    base.Delete(name, id);
                    break;
                case ChooseMethodVoid.Update:
                    base.Update(name, id, _object);
                    break;
                case ChooseMethodVoid.Insert:
                    base.Insert(name, _object);
                    break;
                default:
                    break;
            }
        }

        protected override List<ITypeObject> FindAll(string name)
        {
            return base.FindAll(name);
        }

        protected override ITypeObject FindById(string name, int id)
        {
            return base.FindById(name, id);
        }

        public override void Infor(string name)
        {
            foreach (ITypeObject obj in Database.instance.database[name])
            {
                obj.Infor();
            }
        }
    }
}
