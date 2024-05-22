using Bài_1.Base;
using System.Collections.Generic;

namespace Bài_1.dao
{
    public class CategoryDAO : BaseDAO
    {
        /// <summary>
        /// Take information of object
        /// </summary>
        /// <param name="name">Typename of object</param>
        public override void Infor(string name)
        {
            foreach (BaseRow obj in Database.instance.stores[name])
            {
                obj.Infor();
            }
        }
    }
}
