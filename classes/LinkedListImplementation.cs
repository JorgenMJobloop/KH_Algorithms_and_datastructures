public class LinkedListImplentation<T>
{
    // List<int> exampleListItems = new List<int>();

    // public void ExampleList()
    // {
    //     exampleListItems.Add(1);
    //     exampleListItems.Remove(1);
    // }

    private class Node
    {
        /// <summary>
        /// generic type T (Data)
        /// </summary>
        public T Data { get; set; }
        /// <summary>
        /// next Node
        /// </summary>
        public Node? Next { get; set; }

        public Node(T data)
        {
            this.Data = data;
            Next = null;
        }

        private Node headNode;
        private int _count;

        public int Count => _count;

        public void Add(T item)
        {
            Node newNode = new Node(item);
            if (headNode == null)
            {
                headNode = newNode;
            }
            else
            {
                Node current = headNode;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            _count++;
        }

        public bool Remove(T item)
        {
            if (headNode == null)
            {
                return false;
            }
            if (headNode.Data.Equals(item))
            {
                headNode = headNode.Next;
                _count--;
                return true;
            }

            Node current = headNode;
            while (current.Next != null && !current.Next.Data.Equals(item))
            {
                current = current.Next;
            }
            if (current.Next == null)
            {
                return false;
            }
            current.Next = current.Next.Next;
            _count--;
            return true;
        }
        public void PrintAllValues()
        {
            Node current = headNode;
            while (current != null)
            {
                Console.WriteLine($"{current.Data} -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}