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
        /*
         * Lấy thông tin của đối tượng 
         */
        public override void Infor(string name)
        {
            foreach (BaseRow obj in Database.instance.database[name])
            {
                obj.Infor();
            }
        }
    }
}
