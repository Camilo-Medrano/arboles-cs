namespace Arboles1
{
    public class BinarySearchTree
    {
        public Node root;

        /// <summary>
        /// Conctructor of the class BinarySearchTree
        /// </summary>
        public BinarySearchTree()
        {
            root = null;
        }

        /// <summary>
        /// Method that adds to the tree
        /// </summary>
        /// <param name="i">Integer to input</param>
        public void Insert(int i)
        {
            Node newNode = new Node();
            newNode.Data = i;
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (i < current.Data)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                        else
                        {
                            current = current.Right;
                            if (current == null)
                            {
                                parent.Right = newNode;
                                break;
                            }
                        }
                    }
                }
            }
        }
        
        /// <summary>
        /// InOrder
        /// </summary>
        /// <param name="theRoot"></param>
        public void InOrder(Node theRoot) {
            if (theRoot != null) {
                InOrder(theRoot.Left);
                theRoot.DisplayNode();
                InOrder(theRoot.Right);
            }
        }
    }
}