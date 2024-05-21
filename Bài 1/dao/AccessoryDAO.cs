using Bài_1.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bài_1.dao
{
    internal class AccessoryDAO : BaseDAO
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
            return base.FindById(name,id);
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
