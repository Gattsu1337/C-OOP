using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    internal class Cart
    {
        private List<Product> cart;

        private void AddItemInCart(Product item)
        {
            if (!Store.Storage.ContainsKey(item.Name))
            {
                Console.WriteLine("Product out of stock!");
            }

            cart.Add(item);
        }
        private void RemoveItemInCart(Product item)
        {
            if (!cart.Contains(item))
            {
                Console.WriteLine("No such item in your cart!");
            }

            cart.Remove(item);
        }

        private decimal TotalCost()
        {
            decimal total = 0;

            foreach(Product item in cart)
            {
                total += item.Price; 
            }

            return total;
        }
    }
}
