﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    public class ProductDemo : Product
    {
        public ProductDemo() { }

        public Product CreateProductTest()
        {
            Product productTest = new Product(1, "product_1", 1);

            return productTest;
        }
        /// <summary>
        /// Take infor of object
        /// </summary>
        /// <param name="product">obj need take infor</param>
        public void PrintProduct(Product product)
        {
            product.Infor();           
        }
    }
}
