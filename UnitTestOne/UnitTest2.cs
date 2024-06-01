using XTreeOne;

namespace UnitTestOne
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestHeight1()
        {
            List<TreeNode> myList = new List<TreeNode>();
            myList.Add(83, 423);
            myList.Add(551, 387);
            myList.Add(868, 213);
            myList.Add(546, 72);
            myList.Add(366, 766);
            myList.Add(744, 363);
            myList.Add(191, 39);
            myList.Add(922, 63);
            myList.Add(767, 731);
            myList.Add(111, 624);

            // Add the list to a tree.
            Tree a = new Tree();
            a.AddRange(myList);

            Assert.AreEqual(myList.Count, a.Count());
            Assert.AreEqual(5, a.Height());
        }

        [TestMethod]
        public void TestHeight2()
        {
            List<TreeNode> myList = new List<TreeNode>();
            myList.Add(79, 423);
            myList.Add(102, 572);
            myList.Add(5, 333);
            myList.Add(336, 23);
            myList.Add(485, 82);
            myList.Add(955, 123);
            myList.Add(222, 342);
            myList.Add(251, 673);
            myList.Add(891, 842);
            myList.Add(164, 513);

            // Add the list to a tree.
            Tree a = new Tree();
            a.AddRange(myList);

            Assert.AreEqual(myList.Count, a.Count());
            Assert.AreEqual(5, a.Height());
        }

        [TestMethod]
        public void TestBuild1()
        {
            List<TreeNode> myList = new List<TreeNode>();
            myList.Add(5, 23);
            myList.Add(79, 35);
            myList.Add(102, 94);
            myList.Add(164, 36);
            myList.Add(222, 53);
            myList.Add(251, 88);
            myList.Add(336, 72);
            myList.Add(485, 52);
            myList.Add(891, 12);
            myList.Add(955, 8);
            
            // Add the list to a tree.
            Tree a = new Tree();
            a.Root = a.BuildTree(myList, 0, 9);

            Assert.AreEqual(a.Count(), myList.Count());
            Assert.AreEqual(3, a.Height());
        }

        [TestMethod]
        public void TestBalance1()
        {
            List<TreeNode> myList = new List<TreeNode>();
            myList.Add(79, 102);
            myList.Add(5, 336);
            myList.Add(485, 955);
            myList.Add(222, 251);
            myList.Add(891, 164);
            myList.Add(244, 45);
            myList.Add(897, 505);
            myList.Add(863, 280);
            myList.Add(943, 512);
            myList.Add(155, 630);

            Tree a = new Tree();
            a.AddRange(myList);

            Assert.AreEqual(a.Count(), myList.Count());
            Assert.AreEqual(4, a.Height());

            a.Balance(a);
            Assert.AreEqual(a.Count(), myList.Count());
            Assert.AreEqual(3, a.Height()); 
        }

        [TestMethod]
        public void TestGetList1()
        {
            List<TreeNode> myList = new List<TreeNode>();
            myList.Add(79, 102);
            myList.Add(5, 336);
            myList.Add(485, 955);
            myList.Add(222, 251);
            myList.Add(891, 164);
            myList.Add(244, 45);
            myList.Add(897, 505);
            myList.Add(863, 280);
            myList.Add(943, 512);
            myList.Add(155, 630);

            Tree a = new Tree();
            a.AddRange(myList);

            var b = a.GetList();

            Assert.AreEqual(a.Count(), myList.Count());
            Assert.AreEqual(b.Count(), myList.Count());
            Assert.AreEqual(a.Count(), b.Count());
        }

    }
}
