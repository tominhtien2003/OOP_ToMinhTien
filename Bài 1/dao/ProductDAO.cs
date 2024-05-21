using Bài_1.Base;
using System;
using System.Collections.Generic;

namespace Bài_1.dao
{
    internal class ProductDAO : BaseDAO
    {       
        public void ExcuteMethod(ChooseMethodVoid chooseMethodVoid , string name , int id = 0 , ITypeObject _object = null)
        {
            switch (chooseMethodVoid)
            {
                case ChooseMethodVoid.Delete:
                    base.Delete(name , id );
                    return;
                case ChooseMethodVoid.Update:
                    base.Update(name , id , _object);
                    return;
                case ChooseMethodVoid.Insert:
                    base.Insert(name,_object);
                    return;
                default:
                    Console.WriteLine("Data input fail!");
                    return;
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
