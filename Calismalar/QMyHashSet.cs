using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHashSet
{
    internal class QMyHashSet
    {
        Dictionary<int, int> keys = new Dictionary<int, int>();

        public QMyHashSet()
        {
            
        }

        public void Add(int key)
        {
            keys[key] = key;
        }

        public void Remove(int key)
        {
            keys.Remove(key);         
        }

        public bool Contains(int key)
        {
            return keys.TryGetValue(key, out int value);
        }
    }
}
