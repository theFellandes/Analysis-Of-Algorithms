using System;

namespace SortAlgorithms.Hash
{
    public class HashTableExample
    {
        private Employee[] hashtable;

        public HashTableExample(int capacity)
        {
            hashtable = new Employee[capacity];
        }

        private int HashKey(string key)
        {
            return key.Length % hashtable.Length;
        }

        public void Put(string key, Employee employee)
        {
            int hashedKey = HashKey(key);
            //This implementation cannot handle collisions.
            if (hashtable[hashedKey] != null)
            {
                Console.WriteLine("Sorry, there's already an employee at position " + hashedKey);
            }

            else
            {
                hashtable[hashedKey] = employee;
            }
        }

        public Employee Get(string key)
        {
            int hashedKey = HashKey(key);
            return hashtable[hashedKey];
        }

        public void PrintHashtable()
        {
            foreach (var element in hashtable)
            {
                if(element != null)
                    Console.WriteLine(element.FirstName + ", " + element.LastName + ", " + element.Id);
            }
        }
    }
}