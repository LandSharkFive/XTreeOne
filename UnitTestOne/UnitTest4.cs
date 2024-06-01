
using XTreeOne;

namespace UnitTestOne
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestRemoveAll1()
        {
            List<TreeNode> myList = new List<TreeNode>();
            myList.Add(892, 271);
            myList.Add(288, 371);
            myList.Add(358, 472);
            myList.Add(382, 574);
            myList.Add(217, 527);
            myList.Add(963, 71);
            myList.Add(772, 31);
            myList.Add(178, 22);
            myList.Add(819, 171);
            myList.Add(557, 617);

            // Add the list to a tree.
            Tree a = new Tree();
            a.AddRange(myList);

            Assert.AreEqual(myList.Count, a.Count());
            a.RemoveAll();
            Assert.IsNull(a.Root);
        }

    }
}
