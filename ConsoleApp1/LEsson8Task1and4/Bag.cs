using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8Task1and4
{
    internal class Bag
    {
        private Item[] items;
        private bool _isOpen;

        public Bag() { 
        items = new Item[8];
        _isOpen = false;
        }

        public void ToggleBag()
        {
            _isOpen = !_isOpen;
            Console.WriteLine(_isOpen ? "The bag is opened" : "The bag is closed");
        }
        public void AddItem(Item newItem)
        {
            if (!_isOpen)
            {
                Console.WriteLine("The bag is closed. The item can not be added.");
                return;
            }
            if(Array.Exists(items, item => item != null)) {
                Console.WriteLine("The bag is full");
                return;
            }
            for(int i=0; i<items.Length; i++)
            {
                if (items[i] == null)
                {
                    items[i] = newItem;
                    Console.Write($"Item {newItem.GetName()} is added to the bag");
                }
            }
        }

        public Item RemoveItem(int index)
        {
            if (!_isOpen)
            {
                Console.WriteLine("The bag is closed. Can not remove the item.");
                return null;
            }
            Item removedItem = items[index];
            items[index] = null;
            Console.WriteLine($"Item {removedItem.GetName()} is removed from the bag");
            return removedItem;

        }
    }

    
}
