﻿using Bài_1.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1.Entity
{
    internal class Accessotion : BaseRow
    {
        public Accessotion() { }
        public Accessotion(int id, string name)
        {
            SetId(id);
            SetName(name);
        }
    }
}
