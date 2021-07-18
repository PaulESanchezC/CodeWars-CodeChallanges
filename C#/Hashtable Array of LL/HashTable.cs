using System.Collections.Generic;

namespace Hashtable_Array_of_LL
{
    public class HashTable
    {
        //Variables or Objects
        private LinkedList<KV> _linkedList;
        private LinkedList<KV>[] listArray;
        private KV kv;
        private int index;
        private int length;

        //Linked Lists and Array of Linked Lists Constructor 
        public HashTable(int lenght)
        {
            listArray = new LinkedList<KV>[lenght];
            _linkedList = new LinkedList<KV>();
            index = 0;
            this.length = lenght;
        }

        //Node Class
        public class KV
        {
            //Node Properties
            public int Key { get; set; }
            public string Value { get; set; }
            //Node Constructor
            public KV(int key, string value)
            {
                this.Key = key;
                this.Value = value;
            }
        }
        //Methods
        public void Put(int key, string value)
        {
            kv = new KV(key, value);
            index = GetIndex(key);
            if (IsEmpty(index))
            {
                _linkedList = new LinkedList<KV>();
                _linkedList.AddFirst(kv);
                listArray[index] = _linkedList ;
                
            }
            else
            {
                _linkedList = listArray[index];
                _linkedList.AddLast(kv);
            }
        }
        public string Get(int key)
        {
            index = GetIndex(key);
            _linkedList = listArray[index];
            foreach (var node in _linkedList)
                if (node.Key == key)
                    return node.Value;

            return "No value found";
        }
        public void Remove(int key)
        {
            index = GetIndex(key);
            
            if (IsEmpty(index))
                return;
            
            _linkedList = listArray[index];

            foreach (var node in _linkedList)
                if (node.Key == key)
                {
                    _linkedList.Remove(node);
                    return;
                }
        }

        //Private Methods
        private bool IsEmpty(int index)
        {
            return listArray[index] == null || listArray[index].Count == 0;
        }
        private int GetIndex(int key)
        {
            return key % length;
        }
    }
}