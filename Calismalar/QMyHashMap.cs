using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHashMap
{
    internal class QMyHashMap
    {
        private int[] data;

        public QMyHashMap()
        {
            data = new int[1_000_001];
            Array.Fill(data, -1);
        }

        public void Put(int key, int value)
        {
            data[key] = value;
        }

        public int Get(int key)
        {
           return data[key];
        }

        public void Remove(int key)
        {
            data[key] = -1;
        }
    }

    internal class QMyHashMap2
    {
        Dictionary<int, int> KeyValue;
        public QMyHashMap2()
        {
            KeyValue = new Dictionary<int,int>();
        }

        public void Put(int key, int value)
        {
            KeyValue[key] = value;
        }

        public int Get(int key)
        {
            return KeyValue.ContainsKey(key) == false ? -1 : KeyValue[key];
        }

        public void Remove(int key)
        {
            KeyValue[key] = -1;
        }
    }
}
