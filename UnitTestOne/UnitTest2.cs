using XTreeOne;

namespace UnitTestOne
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestHeight1()
        {
            List<int> list = new List<int>() { 83, 551, 868, 546, 366, 744, 191, 922, 767, 111 };

            // Add the list to a tree.
            Tree a = new Tree();
            foreach (var k in list)
            {
                a.Add(k, k + 1);
            }

            Assert.AreEqual(list.Count, a.Count());
            Assert.AreEqual(5, a.Height());
        }

        [TestMethod]
        public void TestHeight2()
        {
            List<int> list = new List<int>() { 79, 102, 5, 336, 485, 955, 222, 251, 891, 164 };

            // Add the list to a tree.
            Tree a = new Tree();
            foreach (var k in list)
            {
                a.Add(k, k + 1);
            }

            Assert.AreEqual(list.Count, a.Count());
            Assert.AreEqual(5, a.Height());
        }

        [TestMethod]
        public void TestBuild1()
        {
            List<int> list = new List<int>() { 79, 102, 5, 336, 485, 955, 222, 251, 891, 164,
            244, 45, 897, 505, 863, 280, 943, 512, 155, 630 };

            list.Sort();
            var a = Util.GetTreeNodes(list);

            // Add the list to a tree.
            Tree b = new Tree();
            b.Root = b.BuildTree(a, 0, 9);

            Assert.AreEqual(a.Count(), b.Count());
            Assert.AreEqual(3, b.Height());
        }

        [TestMethod]
        public void TestBalance1()
        {
            List<int> list = new List<int>() { 79, 102, 5, 336, 485, 955, 222, 251, 891, 164,
            244, 45, 897, 505, 863, 280, 943, 512, 155, 630 };

            Tree a = new Tree();
            foreach (var k in list)
            {
                a.Add(k, k + 1);
            }

            Assert.AreEqual(a.Count(), list.Count());
            Assert.AreEqual(9, a.Height());

            a.Balance(a);
            Assert.AreEqual(a.Count(), list.Count());
            Assert.AreEqual(4, a.Height()); 
        }

        [TestMethod]
        public void TestGetList1()
        {
            List<int> list = new List<int>() { 79, 102, 5, 336, 485, 955, 222, 251, 891, 164,
            244, 45, 897, 505, 863, 280, 943, 512, 155, 630 };

            Tree a = new Tree();
            foreach (var k in list)
            {
                a.Add(k, k + 1);
            }

            var b = a.GetList();

            Assert.AreEqual(a.Count(), list.Count());
            Assert.AreEqual(b.Count(), list.Count());
            Assert.AreEqual(a.Count(), b.Count());
        }

    }
}
