namespace Bài_1.Base
{
    internal abstract class BaseDAO
    {
        /*
         * thêm đối tượng vào database
         */
        protected abstract bool Insert(ITypeObject obj);
    }
}
