using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictionary
{
    internal class CustomDictionary<Tkey, Tvalue>
    {
        List<Tkey> keys = new();
        List<Tvalue> values = new();

        public CustomDictionary() { }

        public void Add(Tkey key, Tvalue value)
        {
            keys.Add(key);
            values.Add(value);
        }
        public void RemoveAtIndex(int index)
        {
            if (index >= 0 && index < keys.Count)
            {
                keys.RemoveAt(index);
                values.RemoveAt(index);
            }
        }
        public Tkey? FindKey(int index) 
        {
            if (index >= 0 && index < keys.Count)
            {
                return keys[index];
            }
            return default;
        }
        public void UpdateValueAtKey(Tkey key, Tvalue newValue)
        {
            bool found = false;
            int index = -1;
            foreach (Tkey k in keys)
            {
                index++;
                if (Object.Equals(k, key))
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                values[index] = newValue;
            }
        }

        public string Display()
        {
            if (keys != null)
            {
                StringBuilder sb = new();
                for (int i = 0; i < keys.Count; i++)
                {
                    sb.Append($"{i+1}, {keys[i]}, {values[i]}");
                }
                return sb.ToString();
            }
            return "";
        }
    }
}
