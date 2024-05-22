using Bài_1.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1.Entity
{
    public class Accessotion : BaseRow
    {
        public Accessotion() { }
        public Accessotion(int id, string name)
        {
            this.id = id;
            this.name = name;
            typename = "Accessotion";
        }
    }
}
