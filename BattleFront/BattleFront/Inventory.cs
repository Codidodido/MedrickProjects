using System.Collections.Generic;

namespace BattleFront
{
    public class Inventory<T>
    {
        public List<T> Items { get; }

        public Inventory()
        {
            Items = new List<T>();
        }

        public Inventory(List<T> items)
        {
            Items = items;
        }

        public void AddToInventory(T item)
        {
            Items.Add(item);
        }

        public void RemoveFromInventory(T item)
        {
            
        }
    }
}