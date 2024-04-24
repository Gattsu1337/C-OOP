using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace week3
{
    internal class Product
    {
        private string name; private decimal price; private DateTime expirationDate; private int count;

        public string Name
        {
            get => name;
            set => name = (value.Length >= 3) ? value : throw new ArgumentException("Please enter a name with at least 3 characters!");
        }

        public decimal Price
        {
            get => price;
            set => price = (value > 0) ? value : throw new ArgumentException("Please enter a price that is a positive number!");
        }

        public DateTime ExpirationDate
        {
            get => expirationDate;
            set => expirationDate = (value >= DateTime.Now) ? value : throw new ArgumentException("The product has expired!");
        }

        public int Count
        {
            get; set;
        }
    }
}