using Bài_1.Base;

namespace Bài_1.dao
{
    internal class ProductDAO : BaseDAO
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
