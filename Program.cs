using System;
using static CustHashTable.CustomeStringHashTable;

namespace CustHashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomeStringHashTable hashTable = new CustomeStringHashTable(10);
            hashTable.add("Alice");
            hashTable.add("Bob");
            hashTable.add("Charlie");

            hashTable.display();

            hashTable.search("Bob");
        }
    }
}