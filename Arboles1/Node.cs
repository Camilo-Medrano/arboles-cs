using System;

namespace Arboles1
{
    public class Node
    {
        public int Data;
        public Node Left;
        public Node Right;

        public void DisplayNode()
        {
            Console.Write(Data + " ");
        }
    }
}