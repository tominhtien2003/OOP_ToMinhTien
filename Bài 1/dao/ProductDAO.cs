using Bài_1.Base;

namespace Bài_1.dao
{
    public class ProductDAO : BaseDAO
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
