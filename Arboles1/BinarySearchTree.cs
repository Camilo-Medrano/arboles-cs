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
        
        /// <summary>
        /// InOrder
        /// </summary>
        /// <param name="theRoot"></param>
        public void InOrder(Node theRoot) 
        {
            if (theRoot != null) 
            {
                InOrder(theRoot.Left);
                theRoot.DisplayNode();
                InOrder(theRoot.Right);
            }
        }
        
        /// <summary>
        /// PreOrder
        /// </summary>
        /// <param name="theRoot"></param>
        public void PreOrder(Node theRoot) {
            if (!(theRoot == null)) {
                theRoot.DisplayNode();
                PreOrder(theRoot.Left);
                PreOrder(theRoot.Right);
            }
        }
        
        /// <summary>
        /// PostOrder
        /// </summary>
        /// <param name="theRoot"></param>
        public void PostOrder(Node theRoot) {
            if (!(theRoot == null)) {
                PostOrder(theRoot.Left);
                PostOrder(theRoot.Right);
                theRoot.DisplayNode();
            }
        }
        
        /// <summary>
        /// Finds the Minimum
        /// </summary>
        /// <returns></returns>
        public int FindMin() {
            Node current = root; 
            while (!(current.Left == null)) 
                current = current.Left; 
            return current.Data;
        }
        
        /// <summary>
        /// Finds the maximum
        /// </summary>
        /// <returns></returns>
        public int FindMax() {
            Node current = root;
            while (!(current.Right == null))
                current = current.Right;
            return current.Data;
        }
        
        /// <summary>
        /// Finds a node inside the BST
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Node Find(int key) {
            Node current = root;
            while (current.Data != key) {
                if (key < current.Data)
                    current = current.Left;
                else
                    current = current.Right;
                if (current == null)
                    return null;
            }
            return current;
        }
    }
}