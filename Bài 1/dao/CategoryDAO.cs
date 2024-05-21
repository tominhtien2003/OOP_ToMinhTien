﻿using Bài_1.Base;
using System.Collections.Generic;

namespace Bài_1.dao
{
    internal class CategoryDAO : BaseDAO
    {
        protected override void Delete(string name, int id)
        {
            base.Delete(name, id);
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

        protected override void Insert(string name, ITypeObject _object)
        {
            base.Insert(name, _object);
        }

        protected override void Update(string name, int id, ITypeObject obj)
        {
            base.Update(name, id, obj);
        }
    }
}
