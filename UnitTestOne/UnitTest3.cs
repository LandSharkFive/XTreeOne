using XTreeOne;

namespace UnitTestOne
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestRemove1()
        {
            List<int> list = new List<int>() { 892, 288, 358, 382, 217, 963, 772, 178, 819, 557 };

            // Add the list to a tree.
            Tree a = new Tree();
            foreach (var k in list)
            {
                a.Add(k, k + 1);
            }

            Assert.AreEqual(list.Count, a.Count());
            a.Remove(892);
            a.Remove(382);

            Assert.IsFalse(a.Contains(892));
            Assert.IsFalse(a.Contains(382));

            Assert.IsTrue(a.Contains(288));
            Assert.IsTrue(a.Contains(358));
            Assert.IsTrue(a.Contains(772));
            Assert.IsTrue(a.Contains(819));
            Assert.IsTrue(a.Contains(557));
            Assert.IsTrue(a.Contains(217));
            Assert.IsTrue(a.Contains(963));
            Assert.IsTrue(a.Contains(178));
        }

        [TestMethod]
        public void TestRemove2()
        {
            List<int> list = new List<int>() { 892, 288, 358, 382, 217, 963, 772, 178, 819, 557 };

            // Add the list to a tree.
            Tree a = new Tree();
            foreach (var k in list)
            {
                a.Add(k, k + 1);
            }

            Assert.AreEqual(list.Count, a.Count());
            a.Remove(772);
            a.Remove(557);

            Assert.IsFalse(a.Contains(772));
            Assert.IsFalse(a.Contains(557));

            Assert.IsTrue(a.Contains(288));
            Assert.IsTrue(a.Contains(358));
            Assert.IsTrue(a.Contains(217));
            Assert.IsTrue(a.Contains(819));
            Assert.IsTrue(a.Contains(178));
            Assert.IsTrue(a.Contains(892));
            Assert.IsTrue(a.Contains(963));
            Assert.IsTrue(a.Contains(382));
        }


        [TestMethod]
        public void TestRemove3()
        {
            List<int> list = new List<int>() { 892, 288, 358, 382, 217, 963, 772, 178, 819, 557 };

            // Add the list to a tree.
            Tree a = new Tree();
            foreach (var k in list)
            {
                a.Add(k, k + 1);
            }

            Assert.AreEqual(list.Count, a.Count());
            a.Remove(217);
            a.Remove(178);

            Assert.IsFalse(a.Contains(217));
            Assert.IsFalse(a.Contains(178));

            Assert.IsTrue(a.Contains(288));
            Assert.IsTrue(a.Contains(358));
            Assert.IsTrue(a.Contains(772));
            Assert.IsTrue(a.Contains(819));
            Assert.IsTrue(a.Contains(557));
            Assert.IsTrue(a.Contains(892));
            Assert.IsTrue(a.Contains(963));
            Assert.IsTrue(a.Contains(382));
        }

        [TestMethod]
        public void TestRemove4()
        {
            List<int> list = new List<int>() { 420, 442, 70, 590, 624, 604, 941, 570, 666, 638, 976, 419, 441, 558, 61, 34, 623, 33, 694, 280 };
            list.Sort();
            List<TreeNode> nodes = Util.GetTreeNodes(list);

            // Keys: 33 61 280 420 442 570 604 624 666 941

            foreach (var node in nodes)
            {
                Console.Write("{0} ", node.Key);
            }

            // Add the list to a tree.
            Tree a = new Tree();
            a.Root = a.BuildTree(nodes, 0, 9);

            Assert.AreEqual(nodes.Count, a.Count());
            Assert.AreEqual(nodes.Count, list.Count / 2);

            a.Remove(280);
            a.Remove(288);
            a.Remove(442);
            a.Remove(624);

            Assert.IsFalse(a.Contains(280));
            Assert.IsFalse(a.Contains(288));
            Assert.IsFalse(a.Contains(442));
            Assert.IsFalse(a.Contains(624));

            Assert.IsTrue(a.Contains(33));
            Assert.IsTrue(a.Contains(61));
            Assert.IsTrue(a.Contains(420));
            Assert.IsTrue(a.Contains(570));
            Assert.IsTrue(a.Contains(604));
            Assert.IsTrue(a.Contains(666));
            Assert.IsTrue(a.Contains(941));
        }

        [TestMethod]
        public void TestRemove5()
        {
            List<int> list = new List<int>() { 986, 680, 844, 100, 240, 604, 35, 329, 668, 519, 533, 487, 71, 534, 638, 440, 579, 3, 419, 899 };
            list.Sort();
            List<TreeNode> nodes = Util.GetTreeNodes(list);

            // Keys: 3 71 240 419 487 533 579 638 680 899 

            foreach (var node in nodes)
            {
                Console.Write("{0} ", node.Key);
            }

            // Add the list to a tree.
            Tree a = new Tree();
            a.Root = a.BuildTree(nodes, 0, 9);

            Assert.AreEqual(nodes.Count, a.Count());
            Assert.AreEqual(nodes.Count, list.Count / 2);

            a.Remove(1);
            a.Remove(3);
            a.Remove(240);
            a.Remove(638);

            Assert.IsFalse(a.Contains(1));
            Assert.IsFalse(a.Contains(3));
            Assert.IsFalse(a.Contains(240));
            Assert.IsFalse(a.Contains(638));

            Assert.IsTrue(a.Contains(71));
            Assert.IsTrue(a.Contains(419));
            Assert.IsTrue(a.Contains(487));
            Assert.IsTrue(a.Contains(533));
            Assert.IsTrue(a.Contains(579));
            Assert.IsTrue(a.Contains(680));
            Assert.IsTrue(a.Contains(899));
        }


        [TestMethod]
        public void TestRemove6()
        {
            List<int> list = new List<int>() { 15, 35, 39, 81, 85, 121, 136, 149, 166, 237, 252, 313, 337, 349, 350, 400, 418, 452, 
                483, 517, 528, 621, 635, 646, 683, 735, 754, 756, 789, 806, 844, 847, 862, 877, 880, 895, 902, 953, 959, 981 };
            List<TreeNode> nodes = Util.GetTreeNodes(list);

            // Keys: 15 39 85 136 166 252 337 350 418 483 528 635 683 754 789 844 862 880 902 959 

            foreach (var node in nodes)
            {
                Console.Write("{0} ", node.Key);
            }

            // Add the list to a tree.
            Tree a = new Tree();
            a.Root = a.BuildTree(nodes, 0, 19);

            Assert.AreEqual(nodes.Count, a.Count());
            Assert.AreEqual(nodes.Count, list.Count / 2);

            a.Remove(15);
            a.Remove(959);
            a.Remove(85);
            a.Remove(844);
            a.Remove(418);
            a.Remove(528);

            Assert.IsFalse(a.Contains(1));
            Assert.IsFalse(a.Contains(2));
            Assert.IsFalse(a.Contains(3));
            Assert.IsFalse(a.Contains(15));
            Assert.IsFalse(a.Contains(959));
            Assert.IsFalse(a.Contains(85));
            Assert.IsFalse(a.Contains(844));
            Assert.IsFalse(a.Contains(418));
            Assert.IsFalse(a.Contains(528));

            Assert.IsTrue(a.Contains(39));
            Assert.IsTrue(a.Contains(136));
            Assert.IsTrue(a.Contains(166));
            Assert.IsTrue(a.Contains(252));
            Assert.IsTrue(a.Contains(337));
            Assert.IsTrue(a.Contains(350));
            Assert.IsTrue(a.Contains(483));
            Assert.IsTrue(a.Contains(635));
            Assert.IsTrue(a.Contains(754));
            Assert.IsTrue(a.Contains(789));
            Assert.IsTrue(a.Contains(862));
            Assert.IsTrue(a.Contains(880));
            Assert.IsTrue(a.Contains(902));
        }


    }
}
