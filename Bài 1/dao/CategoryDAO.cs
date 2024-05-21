using Bài_1.Base;
using System.Collections.Generic;

namespace Bài_1.dao
{
    internal class CategoryDAO : BaseDAO
    {
        public override void Infor(string name)
        {
            foreach (BaseRow obj in Database.instance.database[name])
            {
                obj.Infor();
            }
        }
    }
}
