using XTreeOne;

namespace UnitTestOne
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd1()
        {
            List<TreeNode> myList = new List<TreeNode>();
            myList.Add(892, 100);
            myList.Add(288, 64);
            myList.Add(358, 127);
            myList.Add(382, 712);
            myList.Add(217, 151);
            myList.Add(963, 512);
            myList.Add(772, 53);
            myList.Add(178, 314);
            myList.Add(819, 321);
            myList.Add(557, 324);

            // Add the list to a tree.
            Tree a = new Tree();
            a.AddRange(myList);

            Assert.AreEqual(myList.Count, a.Count());
            for (int i = 0; i < myList.Count; i++)
            {
                int key = myList[i].Key;
                Assert.IsTrue(a.Contains(key));
            }

        }

        [TestMethod]
        public void TestAdd2()
        {
            List<TreeNode> myList = new List<TreeNode>();
            myList.Add(656, 105);
            myList.Add(968, 125);
            myList.Add(320, 130);
            myList.Add(413, 135);
            myList.Add(244, 140);
            myList.Add(495, 145);
            myList.Add(133, 150);
            myList.Add(806, 155);
            myList.Add(136, 160);
            myList.Add(364, 165);

            // Add the list to a tree.
            Tree a = new Tree();
            a.AddRange(myList);

            Assert.AreEqual(myList.Count, a.Count());
            for (int i = 0; i < myList.Count; i++)
            {
                int key = myList[i].Key;
                Assert.IsTrue(a.Contains(key));
            }
        }

        [TestMethod]
        public void TestAdd3()
        {
            List<TreeNode> myList = new List<TreeNode>();
            myList.Add(83, 15);
            myList.Add(551, 32);
            myList.Add(858, 45);
            myList.Add(546, 71);
            myList.Add(366, 38);
            myList.Add(744, 147);
            myList.Add(191, 158);
            myList.Add(922, 321);
            myList.Add(767, 406);
            myList.Add(111, 412);

            // Add the list to a tree.
            Tree a = new Tree();
            a.AddRange(myList);

            Assert.AreEqual(myList.Count, a.Count());
            for (int i = 0; i < myList.Count; i++)
            {
                int key = myList[i].Key;
                Assert.AreEqual(true, a.Contains(key));
            }

        }

        [TestMethod]
        public void TestFind1()
        {
            List<TreeNode> myList = new List<TreeNode>();
            myList.Add(83, 23);
            myList.Add(551, 152);
            myList.Add(868, 315);
            myList.Add(546, 475);
            myList.Add(366, 611);
            myList.Add(744, 602);
            myList.Add(191, 173);
            myList.Add(922, 931);
            myList.Add(767, 771);
            myList.Add(111, 601);

            // Add the list to a tree.
            Tree a = new Tree();
            a.AddRange(myList);

            Assert.AreEqual(myList.Count, a.Count());
            for (int i = 0; i < myList.Count; i++)
            {
                int key = myList[i].Key;
                Assert.IsNotNull(a.Find(key));
            }

        }

        [TestMethod]
        public void TestGetValue1()
        {
            //List<int> list = new List<int>() { 83, 551, 868, 546, 366, 744, 191, 922, 767, 111 };
            List<TreeNode> myList = new List<TreeNode>();
            myList.Add(83, 27);
            myList.Add(551, 227);
            myList.Add(868, 352);
            myList.Add(546, 552);
            myList.Add(366, 709);
            myList.Add(744, 831);
            myList.Add(191, 839);
            myList.Add(922, 937);
            myList.Add(767, 527);
            myList.Add(111, 486);

            // Add the list to a tree.
            Tree a = new Tree();
            a.AddRange(myList);

            Assert.AreEqual(myList.Count, a.Count());
            for (int i = 0; i < myList.Count; i++)
            {
                int key = myList[i].Key;
                int value = myList[i].Value;
                Assert.AreEqual(value, a.GetValue(key));
            }
        }

    }
}