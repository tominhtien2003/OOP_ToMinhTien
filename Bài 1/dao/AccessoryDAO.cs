using Bài_1.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bài_1.dao
{
    public class AccessoryDAO : BaseDAO
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
