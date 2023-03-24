using MCCL6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9MCCL6
{
    internal class DBItem<T> : IDBItem<T> where T : IID
    {
        private int counter = 1;
        public List<T> Items { get; set; }

        public DBItem()
        {
            Items = new List<T>();
        }

        public void AddItem(T item)
        {
            item.Id = counter++;
            Items.Add(item);
        }

        public bool DeleteByItem(T item) 
        { 
            return Items.Remove(item); 
        }
    }
}
