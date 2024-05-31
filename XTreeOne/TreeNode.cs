namespace XTreeOne
{
    public class TreeNode
    {
        // Binary Tree
        public int Key;
        public int Value;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode()
        {
            this.Key = 0;
            this.Value = 0;
            Left = null;
            Right = null;
        }

        public TreeNode(int key, int value)
        {
            this.Key = key;
            this.Value = value;
            Left = null;
            Right = null;
        }


        public TreeNode Find(int key)
        {
            TreeNode temp = this;
            while (true)
            {
                if (temp == null)
                {
                    return null;
                }
                else if (key < temp.Key)
                {
                    temp = temp.Left;
                }
                else if (key > temp.Key)
                {
                    temp = temp.Right;
                }
                else if (key == temp.Key)
                {
                    // found
                    return temp;
                }
            }
        }

        public int GetValue(int key)
        {
            var a = Find(key);
            if (a == null)
            {
                return -1;
            }
            return a.Value;
        }

        public bool Contains(int key)
        {
            TreeNode temp = this;
            while (true)
            {
                if (temp == null)
                {
                    // not found
                    return false;
                }
                else if (key < temp.Key)
                {
                    temp = temp.Left;
                }
                else if (key > temp.Key)
                {
                    temp = temp.Right;
                }
                else if (key == temp.Key)
                {
                    // found
                    return true;
                }
            }
        }

        public void Add(int key, int value)
        {
            if (key < this.Key)
            {
                if (Left == null)
                    Left = new TreeNode(key, value);
                else
                    Left.Add(key, value);
            }
            else if (key > this.Key)
            {
                if (Right == null)
                    Right = new TreeNode(key, value);
                else
                    Right.Add(key, value);
            }
        }

        public void Print(TreeNode node)
        {
            if (node != null)
            {
                Print(node.Left);
                Console.WriteLine("{0} {1}", node.Key, node.Value);
                Print(node.Right);
            }
        }

        public bool IsLeaf()
        {
            return Left == null && Right == null;
        }

        public int Height(TreeNode node)
        {
            if (node == null || node.IsLeaf())
            {
                return 0;
            }

            return 1 + Math.Max(Height(node.Left), Height(node.Right));
        }

        public int Count(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }
            if (node.IsLeaf())
            {
                return 1;
            }

            return 1 + Count(node.Left) + Count(node.Right);
        }

        public List<TreeNode> GetList(List<TreeNode> myList)
        {
            if (Left != null)
            {
                Left.GetList(myList);
            }
            myList.Add(new TreeNode(this.Key, this.Value));
            if (Right != null)
            {
                Right.GetList(myList);
            }

            return myList;
        }

        public void RemoveAll()
        {
            if (Left != null)
            {
                Left.RemoveAll();
                Left = null;
            }
            if (Right != null)
            {
                Right.RemoveAll();
                Right = null;
            }
        }

        public TreeNode Remove(TreeNode node, int key)
        {
            if (node == null)
            {
                return node;
            }

            if (key < node.Key)
                node.Left = Remove(node.Left, key);
            else if (key > node.Key)
                node.Right = Remove(node.Right, key);
            else
            {
                // One child or zero.
                if (node.Left == null)
                    return node.Right;
                else if (node.Right == null)
                    return node.Left;

                node.Key = MinValue(node.Right);
                node.Right = Remove(node.Right, node.Key);
            }

            return node;
        }

        public int MinValue(TreeNode node)
        {
            int min = node.Key;
            while (node.Left != null)
            {
                min = node.Left.Key;
                node = node.Left;
            }
            return min;
        }


    }
}
