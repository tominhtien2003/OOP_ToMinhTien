using Bài_1.Base;
using Bài_1.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1.Demo
{
    public class ProductDaoDemo : ProductDAO
    {
        /// <summary>
        /// Delete a object have type is name with id
        /// </summary>
        /// <param name="name">Type of object</param>
        /// <param name="id">id need delete</param>
        public void DeleteTest(string name, int id)
        {
            base.Delete(name, id);
        }
        /// <summary>
        /// Take list object type name
        /// </summary>
        /// <param name="name">Name of object</param>
        /// <returns>a list of object type name</returns>
        public List<BaseRow> FindAllTest(string name)
        {
            return base.FindAll(name);
        }
        /// <summary>
        /// Find obj with typename is name and id 
        /// </summary>
        /// <param name="name">typename of object</param>
        /// <param name="id">id of obj need find</param>
        /// <returns>obj with typename is name and id</returns>
        public BaseRow FindByIdTest(string name, int id)
        {
            return base.FindById(name, id);
        }
        /// <summary>
        /// Add a obj in database
        /// </summary>
        /// <param name="obj">obj need add</param>
        public void InsertTest(BaseRow obj)
        {
            base.Insert(obj);
        }
        /// <summary>
        /// Update obj with id by obj
        /// </summary>
        /// <param name="id">id of obj need update</param>
        /// <param name="obj">obj need update</param>
        public void UpdateTest(int id, BaseRow obj)
        {
            base.Update(id, obj);
        }
    }
}
