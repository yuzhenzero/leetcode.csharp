using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode.csharp
{
    public class RandomizedSet
    {
        private Random _random;
        private Dictionary<int, int> _indices;
        private List<int> _list;

        public RandomizedSet()
        {
            _random = new Random();
            _indices = new Dictionary<int, int>();
            _list = new List<int>();
        }

        public bool Insert(int val)
        {
            if (_indices.ContainsKey(val))
            {
                return false;
            }

            _list.Add(val);
            _indices[val] = _list.Count - 1;
            return true;
        }

        public bool Remove(int val)
        {
            if (!_indices.ContainsKey(val))
            {
                return false;
            }

            int index = _indices[val];
            int last = _list.Last();
            _list[index] = last;
            _indices[last] = index;
            _list.RemoveAt(_list.Count - 1);
            _indices.Remove(val);

            return true;
        }


        public int GetRandom()
        {
            int index = _random.Next(_list.Count);

            return _list[index];
        }
    }
}