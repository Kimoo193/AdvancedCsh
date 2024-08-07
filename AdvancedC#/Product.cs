using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Csh
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }
        private Dictionary<Product, int> productInventory = new Dictionary<Product, int>();

        public void Pay(Product product, int quantity)
        {
            if (productInventory.ContainsKey(product))
            {
                productInventory[product] += quantity;
            }
            else
            {
                productInventory[product] = quantity;
            }
        }

        public void Sell(Product product, int quantity)
        {
            if (productInventory.ContainsKey(product))
            {
                productInventory[product] -= quantity;

                if (productInventory[product] < 5)
                {
                    NotifySuppliers(product);
                }
            }
            else
            {
                Console.WriteLine("Product not available in inventory.");
            }
        }

        public event Action<Product> OnProductLow;

        protected void NotifySuppliers(Product product)
        {
            OnProductLow?.Invoke(product);
        }
    }

    public class Supplier
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void OnProductLow(Product product)
        {
            Console.WriteLine($"Supplier {Name} notified: Product {product.Name} is low on stock.");
        }
    }

}
