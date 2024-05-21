using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    internal class ProductDemo : Product
    {
        public ProductDemo() { }
        public ProductDemo(int id, string name, int categoryId) : base(id, name, categoryId)
        {

        }

        public Product CreateProductTest()
        {

            Product productTest = new Product(1, "product_1", 1);

            return productTest;

        }
        public void PrintProduct(Product product)
        {

            product.Infor();
            
        }
    }
}
