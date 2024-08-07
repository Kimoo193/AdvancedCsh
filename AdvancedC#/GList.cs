using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Csh
{
    public class GList<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public void DisplayItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
