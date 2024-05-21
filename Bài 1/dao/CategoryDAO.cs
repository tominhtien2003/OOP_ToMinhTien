﻿using Bài_1.Base;

namespace Bài_1.dao
{
    internal class CategoryDAO : BaseDAO , IDao
    {
        public string NAME => "Category";

        protected override bool Insert(ITypeObject _object)
        {

            Database.instance.InsertTable(NAME, _object);

            foreach (ITypeObject obj in Database.instance.database[NAME])
            {
                if (obj == _object)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
