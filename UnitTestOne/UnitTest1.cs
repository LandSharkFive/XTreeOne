using XTreeOne;

namespace UnitTestOne
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd1()
        {
            List<int> list = new List<int>() { 892, 288, 358, 382, 217, 963, 772, 178, 819, 557 };

            // Add the list to a tree.
            Tree a = new Tree();
            foreach (var k in list)
            {
                a.Add(k, k + 1);
            }

            Assert.AreEqual(list.Count, a.Count());
            for (int i = 0; i < list.Count; i++)
            {
                Assert.AreEqual(true, a.Contains(list[i]));
            }

        }

        [TestMethod]
        public void TestAdd2()
        {
            List<int> list = new List<int>() { 656, 968, 320, 413, 244, 495, 133, 806, 136, 364 };

            // Add the list to a tree.
            Tree a = new Tree();
            foreach (var k in list)
            {
                a.Add(k, k + 1);
            }

            Assert.AreEqual(list.Count, a.Count());
            for (int i = 0; i < list.Count; i++)
            {
                Assert.AreEqual(true, a.Contains(list[i]));
            }

        }

        [TestMethod]
        public void TestAdd3()
        {
            List<int> list = new List<int>() { 83, 551, 868, 546, 366, 744, 191, 922, 767, 111 };

            // Add the list to a tree.
            Tree a = new Tree();
            foreach (var k in list)
            {
                a.Add(k, k + 1);
            }

            Assert.AreEqual(list.Count, a.Count());
            for (int i = 0; i < list.Count; i++)
            {
                Assert.AreEqual(true, a.Contains(list[i]));
            }

        }

        [TestMethod]
        public void TestFind1()
        {
            List<int> list = new List<int>() { 83, 551, 868, 546, 366, 744, 191, 922, 767, 111 };

            // Add the list to a tree.
            Tree a = new Tree();
            foreach (var k in list)
            {
                a.Add(k, k + 1);
            }

            Assert.AreEqual(list.Count, a.Count());
            for (int i = 0; i < list.Count; i++)
            {
                Assert.IsNotNull(a.Find(list[i]));
            }

        }

        [TestMethod]
        public void TestGetValue1()
        {
            List<int> list = new List<int>() { 83, 551, 868, 546, 366, 744, 191, 922, 767, 111 };

            // Add the list to a tree.
            Tree a = new Tree();
            foreach (var k in list)
            {
                a.Add(k, k + 1);
            }

            Assert.AreEqual(list.Count, a.Count());
            for (int i = 0; i < list.Count; i++)
            {
                int k = list[i];
                Assert.AreEqual(k + 1, a.GetValue(k));
            }
        }

    }
}