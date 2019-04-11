using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamXml
{
    public delegate void ProductAddDelegate(Product product);
    [Serializable]
    public class Product
    {
        public event ProductAddDelegate AddEvent;

        public string Brand { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() {}

        public void AddProduct(Product product)
        {
            AddEvent(product);
        }
    }
}
