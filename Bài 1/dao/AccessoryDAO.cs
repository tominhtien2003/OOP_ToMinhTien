using Bài_1.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1.dao
{
    internal class AccessoryDAO : BaseDAO , IDao
    {
        public string NAME { get => "Accessory"; }

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
