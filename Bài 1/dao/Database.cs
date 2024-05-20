using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1.dao
{
    internal class Database
    {
        public Dictionary<string, List<ITypeObject>> database;
        public Database()
        {
            database = new Dictionary<string, List<ITypeObject>>();
        }
        public void InsertTable(string name, ITypeObject _object)
        {
            if (!database.ContainsKey(name))
            {
                database[name] = new List<ITypeObject>();
            }
            database[name].Add(_object);
        }
        public List<ITypeObject> SelectTable(string name)
        {
            List<ITypeObject> result = database[name];
            return result;
        }
        public void UpdateTable(string name, ITypeObject _object,int id)
        {
            if (!database.ContainsKey(name))
            {
                Console.WriteLine("Don't have object type " + name);
            }
            else
            {
                foreach (ITypeObject obj in database[name])
                {
                    if (obj.GetId() == id)
                    {
                        int index = database[name].IndexOf(obj);
                        database[name][index] = _object;
                        return;
                    }
                }
            }
        }
        public void DeleteTable(string name, ITypeObject _object, int id)
        {
            if (!database.ContainsKey(name))
            {
                Console.WriteLine("Don't have object type " + name);
            }
            else
            {
                foreach (ITypeObject obj in database[name])
                {
                    if (obj.GetId() == id)
                    {
                        database[name].Remove(obj);
                        return;
                    }
                }
            }
        }
        public void TruncateTable()
        {
            foreach (string name in database.Keys)
            {
                database[name].Clear();
            }
        }
    }
}
