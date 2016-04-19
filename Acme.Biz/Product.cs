using System;
using Acme.Common;
using static Acme.Common.LoggingService;

namespace Acme.Biz
{
    /// <summary>
    /// Manages products carried in inventory
    /// </summary>
    public class Product
    {
        #region Constructors
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
        #endregion
        private string productName;
        private string description;
        private int productId;
        #region Properties
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
        #endregion
        public string SayHello()
        {
            var Vendor = new Vendor();
            Vendor.SendWelcomeEmail("Hi");
            

            var emailService = new EmailService();
            var confirmation = emailService.SendMessage("new product", this.ProductName, "recipient");
            var result = LogAction("Log hello");
            
            
            return "Hello " + ProductName + " (" + ProductId + "): " + Description;
        }

    }
}
