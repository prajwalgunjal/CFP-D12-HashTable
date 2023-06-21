namespace CustHashTable
{
    public partial class CustomeStringHashTable
    {
        private Node[] Names;

        public CustomeStringHashTable(int size)
        {
            Names = new Node[size];
        }

        public int CustomeHashFunction(string key)
        {
            char[] character = key.ToCharArray();
            int sumoAsciCode = 0;

            foreach (char c in character)
            {
                sumoAsciCode += c;
            }
            return sumoAsciCode;
        }

        public void search(string someName)
        {
            int arrayIndex = Math.Abs(CustomeHashFunction(someName)) % Names.Length;
            Node temp = Names[arrayIndex];
            int counter = 0;
            bool found = false;

            while (temp != null)
            {
                Console.WriteLine("Iteration Counter: " + counter);

                if (temp.Data == someName)
                {
                    Console.WriteLine($"{someName} is present at index {arrayIndex}");
                    found = true;
                    break;
                }

                temp = temp.Next;
                counter++;

            }

            if (!found)
            {
                Console.WriteLine($"{someName} is not found in the hash table.");
            }
        }
        public void add(string newName)
        {
            int arrayIndex = Math.Abs(CustomeHashFunction(newName)) % Names.Length;
            Node newNode = new Node(newName);

            if (Names[arrayIndex] == null)
            {
                Names[arrayIndex] = newNode;
            }
            else
            {
                Node temp = Names[arrayIndex];
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }

            Console.WriteLine($"{newName} added at index {arrayIndex}");
        }

        public void display()
        {
            for (int i = 0; i < Names.Length; i++)
            {
                Node temp = Names[i];
                Console.Write($"Index {i}: ");
                while (temp != null)
                {
                    Console.Write(temp.Data + " -> ");
                    temp = temp.Next;
                }
                Console.WriteLine("null");
            }
        }

    }
}