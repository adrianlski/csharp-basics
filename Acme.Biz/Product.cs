using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    /// <summary>
    /// Manages products carried in inventory
    /// </summary>
    public class Product
    {
        public Product()
        {
            Console.WriteLine("Created");
        }

        public Product(int productId, string productName, string description) : this()
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.Description = description;

            Console.WriteLine("Another instance");
        }

        private string productName;
        private string description;
        private int productId;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public string SayHello()
        {
            return "Hello " + ProductName + " (" + ProductId + "): " + Description;
        }

    }
}
