
namespace XTreeOne
{
    public static class Util
    {
        public static void Add(this List<TreeNode> list, int key, int value) 
        {
            list.Add(new TreeNode(key, value));
        }

    }
}
