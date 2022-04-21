using System.Collections.Generic;
using System.Net.Sockets;

namespace leetcode.csharp
{
    public class Node
    {
        public Node prev, next;
        public int key, val;

        public Node(int key, int val)
        {
            this.key = key;
            this.val = val;
        }
    }

    public class DoubleList
    {
        public Node head, tail;
        private int size;

        public DoubleList()
        {
            this.head = new Node(0, 0);
            this.tail = new Node(0, 0);
            head.next = tail;
            tail.prev = head;
            size = 0;
        }

        public void append(Node node)
        {
            node.next = tail;
            node.prev = tail.prev;
            tail.prev.next = node;
            tail.prev = node;
            size++;
        }

        public int remove(Node node)
        {
            node.prev.next = node.next;
            node.next.prev = node.prev;
            node.next = null;
            node.prev = null;
            size--;
            return node.key;
        }

        public Node removeFirst()
        {
            if (head.next == tail)
            {
                return null;
            }

            Node first = head.next;
            remove(first);
            return first;
        }

        public int Size()
        {
            return size;
        }
    }

    public class LRUCache
    {
        private int capacity;
        private Dictionary<int, Node> map;
        private DoubleList list;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            this.map = new Dictionary<int, Node>();
            this.list = new DoubleList();
        }

        private void MakeNodeLatest(int key)
        {
            Node node = map[key];
            list.remove(node);
            list.append(node);
        }

        private void removeKey(int key)
        {
            Node node = map[key];
            list.remove(node);
            map.Remove(key);
        }

        private void RemoveOldest()
        {
            Node node = list.removeFirst();
            map.Remove(node.key);
        }

        private void AddLatest(int key, int value)
        {
            Node node = new Node(key, value);

            list.append(node);
            map.Add(key, node);
        }

        public int Get(int key)
        {
            if (!map.ContainsKey(key))
            {
                return -1;
            }

            MakeNodeLatest(key);
            return map[key].val;
        }

        public void Put(int key, int value)
        {
            if (map.ContainsKey(key))
            {
                // 两边都删掉
                removeKey(key);

                // 再加上
                AddLatest(key, value);
                return;
            }

            if (list.Size() == capacity)
            {
                RemoveOldest();
            }

            AddLatest(key, value);
        }

        // public static void Main(string[] args)
        // {
        //     LRUCache cache = new LRUCache(2);
        //     cache.Put(2, 1);
        //     cache.Put(2, 2);
        //     cache.Get(2);
        //     cache.Put(1, 1);
        //     cache.Put(4, 1);
        //     cache.Get(2);
        // }
    }
}