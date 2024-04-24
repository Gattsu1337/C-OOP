using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    internal class Store
    {
        private static Dictionary<string, Product> storage;

        public static Dictionary<string, Product> Storage
        {
            get;
            set;
        }

        private void AddProduct(Product product)
        {
            storage.Add(product.Name, product);
        }

        private void RemoveProduct(Product product)
        {

            if(storage.ContainsKey(product.Name))
            {
                storage.Remove(product.Name);
            }
            else
            {
                throw new InvalidOperationException("There is no such item in the storage!");
            }
        }

        private Product FindProduct(string name)
        {
            if (storage.ContainsKey(name))
            {
                return storage[name];
            }
            else 
            {
                Console.WriteLine("Item could not be found!");
                return null;
            }
        }

        private void IncreaseAmountOfProduct(string name, int amount)
        {
            if(!storage.ContainsKey(name))
            {
                Console.WriteLine("There is no such product in the storage!");
            }

            storage[name].Count += amount;
        }

        private void DecreaseAmountOfProduct(string name, int amount)
        {
            if (!storage.ContainsKey(name))
            {
                Console.WriteLine("There is no such product in the storage!");
            }
            else if (storage[name].Count < amount)
            {
                throw new ArgumentException("There is not enough product to decrease!");
            }

            storage[name].Count -= amount;
        }
    }
}
