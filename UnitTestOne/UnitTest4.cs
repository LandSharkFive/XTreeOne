
using XTreeOne;

namespace UnitTestOne
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestRemoveAll1()
        {
            List<int> list = new List<int>() { 892, 288, 358, 382, 217, 963, 772, 178, 819, 557 };

            // Add the list to a tree.
            Tree a = new Tree();
            foreach (var k in list)
            {
                a.Add(k, k + 1);
            }

            Assert.AreEqual(list.Count, a.Count());
            a.RemoveAll();
            Assert.AreEqual(null, a.Root);
        }

    }
}
