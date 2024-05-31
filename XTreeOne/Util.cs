
namespace XTreeOne
{
    public static class Util
    {
        public static List<TreeNode> GetTreeNodes(List<int> a)
        {
            List<TreeNode> list = new List<TreeNode>();
            for (int i = 0; i < a.Count; i += 2)
            {
                list.Add(new TreeNode(a[i], a[i + 1]));
            }
            return list;
        }

    }
}
