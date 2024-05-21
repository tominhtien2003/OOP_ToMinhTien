using Bài_1.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1.Demo
{
    internal class AccessoryDaoDemo : Database
    {
        private const string ACCESSORY = "Accessory";
        public void InsertTest(Category _object)
        {
            InsertTable(ACCESSORY, _object);
        }
        public void UpdateTest(Category _object, int id)
        {
            UpdateTable(ACCESSORY, _object, id);
        }
        public List<ITypeObject> FindAllTest()
        {
            return SelectTable(ACCESSORY);
        }
    }
}
