namespace XTreeOne
{
    public class Tree
    {
        public TreeNode Root;
        Random rnd = new Random();

        public void Add(int key, int value)
        {
            if (Root == null)
            {
                Root = new TreeNode(key, value);
            }
            else
            {
                Root.Add(key, value);
            }
        }

        public void Print()
        {
            if (Root == null)
            {
                return;
            }
            else
            {
                Root.Print(Root);
            }

            Console.WriteLine();
        }

        public TreeNode Find(int key)
        {
            if (Root == null)
            {
                return null;
            }
            else
            {
                return Root.Find(key);
            }
        }

        public bool Contains(int key)
        {
            if (Root == null)
            {
                return false;
            }
            else
            {
                return Root.Contains(key);
            }
        }


        public int Height()
        {
            if (Root == null)
            {
                return 0;
            }
            else
            {
                return Root.Height(Root);
            }
        }

        public int Count()
        {
            if (Root == null)
            {
                return 0;
            }
            else
            {
                return Root.Count(Root);
            }
        }

        public void RemoveAll()
        {
            if (Root == null)
            {
                return;
            }
            else
            {
                Root.RemoveAll();
                Root = null;
            }
        }

        public List<TreeNode> GetList()
        {
            if (Root == null)
            {
                return new List<TreeNode>();
            }
            else
            {
                return Root.GetList(new List<TreeNode>());
            }
        }


        public void Balance(Tree a)
        {
            if (a.Root == null)
            {
                return;
            }

            var b = a.GetList().OrderBy(x => x.Key).ToList();
            a.Root = BuildTree(b, 0, b.Count - 1);
        }

        /// <summary>
        /// Build Tree
        /// </summary>
        /// <param name="">sorted array</param>
        /// <param name="">start index, 0</param>
        /// <param name="">end index, n-1</param>
        public TreeNode BuildTree(List<TreeNode> array, int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            TreeNode a = new TreeNode();
            int mid = (start + end) / 2;
            a.Key = array[mid].Key;
            a.Value = array[mid].Value;
            a.Left = BuildTree(array, start, mid - 1);
            a.Right = BuildTree(array, mid + 1, end);
            return a;
        }

        public int GetValue(int key)
        {
            if (Root == null)
            {
                return -1;
            }
            else
            {
                return Root.GetValue(key);
            }
        }

        public void Remove(int key)
        {
            if (Root == null)
            {
                return;
            }
            else
            {
                Root.Remove(Root, key);
            }
        }


    }
}
