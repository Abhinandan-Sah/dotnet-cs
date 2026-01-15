using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9_extension
{
    public class GenericsCustomization
    {
        public GenericsCustomization()
        {
        }

        public void ExampleOfList()
        {
            // Creating and using a List
            List<string> names = new List<string>();
            names.Add("John");
            names.Add("Sarah");
            names.Add("Mike");
            
            Console.WriteLine($"List has {names.Count} names");
            foreach (var name in names)
            {
                Console.WriteLine($"- {name}");
            }
        }

    }

    // Custom collection implementing IList interface
    public class MyCollection : IList
    {
        // Internal storage - using ArrayList to store items
        private ArrayList items;

        // Constructor
        public MyCollection()
        {
            items = new ArrayList();
        }

        // Access items by index: myCollection[0]
        public object? this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }

        // Size cannot change during iteration - false means it can grow
        public bool IsFixedSize
        {
            get { return false; }
        }

        // Can we modify? Yes we can
        public bool IsReadOnly
        {
            get { return false; }
        }

        // How many items
        public int Count
        {
            get { return items.Count; }
        }

        // Thread safe? No
        public bool IsSynchronized
        {
            get { return false; }
        }

        // For thread locking (not used here)
        public object SyncRoot
        {
            get { return this; }
        }

        // Add an item, returns index where added
        public int Add(object? value)
        {
            return items.Add(value);
        }

        // Remove all items
        public void Clear()
        {
            items.Clear();
        }

        // Check if item exists
        public bool Contains(object? value)
        {
            return items.Contains(value);
        }

        // Copy items to another array
        public void CopyTo(Array array, int index)
        {
            items.CopyTo(array, index);
        }

        // For foreach loops
        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }

        // Find position of item (-1 if not found)
        public int IndexOf(object? value)
        {
            return items.IndexOf(value);
        }

        // Add item at specific position
        public void Insert(int index, object? value)
        {
            items.Insert(index, value);
        }

        // Remove first occurrence of item
        public void Remove(object? value)
        {
            items.Remove(value);
        }

        // Remove item at position
        public void RemoveAt(int index)
        {
            items.RemoveAt(index);
        }

        // Custom method - display all items
        public void PrintAll()
        {
            Console.WriteLine($"MyCollection has {Count} items:");
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine($"[{i}] {items[i]}");
            }
        }
    }
}