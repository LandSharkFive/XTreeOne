using XTreeOne;

namespace UnitTestOne
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestRemove1()
        {
            List<TreeNode> myList = new List<TreeNode>();
            myList.Add(892, 383);
            myList.Add(288, 333);
            myList.Add(358, 376);
            myList.Add(382, 481);
            myList.Add(217, 638);
            myList.Add(963, 992);
            myList.Add(772, 83);
            myList.Add(178, 1783);
            myList.Add(819, 23);
            myList.Add(557, 11);

            // Add the list to a tree.
            Tree a = new Tree();
            a.AddRange(myList);

            Assert.AreEqual(myList.Count, a.Count());
            a.Remove(892);
            a.Remove(382);

            Assert.AreEqual(8, a.Count());

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
            List<TreeNode> myList = new List<TreeNode>();
            myList.Add(892, 321);
            myList.Add(288, 441);
            myList.Add(358, 628);
            myList.Add(382, 421);
            myList.Add(217, 113);
            myList.Add(963, 32);
            myList.Add(772, 21);
            myList.Add(178, 28);
            myList.Add(819, 522);
            myList.Add(557, 372);

            // Add the list to a tree.
            Tree a = new Tree();
            a.AddRange(myList);

            Assert.AreEqual(myList.Count, a.Count());
            a.Remove(772);
            a.Remove(557);

            Assert.AreEqual(8, a.Count());

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
            List<TreeNode> myList = new List<TreeNode>();
            myList.Add(892, 121);
            myList.Add(288, 441);
            myList.Add(358, 628);
            myList.Add(382, 421);
            myList.Add(217, 113);
            myList.Add(963, 32);
            myList.Add(772, 21);
            myList.Add(178, 28);
            myList.Add(819, 522);
            myList.Add(557, 372);

            // Add the list to a tree.
            Tree a = new Tree();
            a.AddRange(myList);

            Assert.AreEqual(myList.Count, a.Count());
            a.Remove(217);
            a.Remove(178);
            a.Remove(382);

            Assert.AreEqual(7, a.Count());

            Assert.IsFalse(a.Contains(217));
            Assert.IsFalse(a.Contains(178));
            Assert.IsFalse(a.Contains(382));

            Assert.IsTrue(a.Contains(288));
            Assert.IsTrue(a.Contains(358));
            Assert.IsTrue(a.Contains(772));
            Assert.IsTrue(a.Contains(819));
            Assert.IsTrue(a.Contains(557));
            Assert.IsTrue(a.Contains(892));
            Assert.IsTrue(a.Contains(963));
        }

        [TestMethod]
        public void TestRemove4()
        {
            List<TreeNode> myList = new List<TreeNode>();
            myList.Add(33, 121);
            myList.Add(34, 225);
            myList.Add(61, 322);
            myList.Add(70, 512);
            myList.Add(280, 632);
            myList.Add(419, 609);
            myList.Add(420, 35);
            myList.Add(441, 62);
            myList.Add(442, 777);
            myList.Add(558, 938);
            myList.Add(570, 294);
            myList.Add(590, 339);
            myList.Add(604, 391);
            myList.Add(623, 742);
            myList.Add(624, 707); 
            myList.Add(638, 311);
            myList.Add(694, 44);
            myList.Add(941, 37);
            myList.Add(976, 941);
            myList.Add(981, 456);


            // Add the list to a tree.
            Tree a = new Tree();
            a.Root = a.BuildTree(myList, 0, 19);

            Assert.AreEqual(myList.Count, a.Count());

            a.Remove(280);
            a.Remove(288);
            a.Remove(441);
            a.Remove(442);
            a.Remove(624);
            a.Remove(981);

            Assert.AreEqual(15, a.Count());

            Assert.IsFalse(a.Contains(280));
            Assert.IsFalse(a.Contains(288));
            Assert.IsFalse(a.Contains(441));
            Assert.IsFalse(a.Contains(442));
            Assert.IsFalse(a.Contains(624));
            Assert.IsFalse(a.Contains(981));

            Assert.IsTrue(a.Contains(33));
            Assert.IsTrue(a.Contains(34));
            Assert.IsTrue(a.Contains(61));
            Assert.IsTrue(a.Contains(70));
            Assert.IsTrue(a.Contains(419));
            Assert.IsTrue(a.Contains(420));
            Assert.IsTrue(a.Contains(570));
            Assert.IsTrue(a.Contains(604));
            Assert.IsTrue(a.Contains(638));
            Assert.IsTrue(a.Contains(623));
            Assert.IsTrue(a.Contains(638));
            Assert.IsTrue(a.Contains(694));
            Assert.IsTrue(a.Contains(941));
            Assert.IsTrue(a.Contains(976));
            Assert.IsTrue(a.Contains(638));
        }

        [TestMethod]
        public void TestRemove5()
        {
            List<TreeNode> myList = new List<TreeNode>();
            myList.Add(1, 71);
            myList.Add(3, 78);
            myList.Add(35, 79);
            myList.Add(71, 712);
            myList.Add(100, 773);
            myList.Add(240, 427);
            myList.Add(329, 587);
            myList.Add(419, 211);
            myList.Add(440, 331);
            myList.Add(487, 755);
            myList.Add(519, 474);
            myList.Add(533, 427);
            myList.Add(534, 777);
            myList.Add(579, 709);
            myList.Add(604, 733);
            myList.Add(638, 654);
            myList.Add(668, 932);
            myList.Add(844, 783);
            myList.Add(889, 22);
            myList.Add(986, 21);


            // Add the list to a tree.
            Tree a = new Tree();
            a.Root = a.BuildTree(myList, 0, 19);

            Assert.AreEqual(myList.Count, a.Count());
            Assert.AreEqual(20, a.Count());

            a.Remove(1);
            a.Remove(3);
            a.Remove(240);
            a.Remove(638);
            a.Remove(844);

            Assert.AreEqual(15, a.Count());

            Assert.IsFalse(a.Contains(1));
            Assert.IsFalse(a.Contains(3));
            Assert.IsFalse(a.Contains(240));
            Assert.IsFalse(a.Contains(411));
            Assert.IsFalse(a.Contains(638));
            Assert.IsFalse(a.Contains(884));

            Assert.IsTrue(a.Contains(35));
            Assert.IsTrue(a.Contains(71));
            Assert.IsTrue(a.Contains(100));
            Assert.IsTrue(a.Contains(329));
            Assert.IsTrue(a.Contains(419));
            Assert.IsTrue(a.Contains(440));
            Assert.IsTrue(a.Contains(487));
            Assert.IsTrue(a.Contains(533));
            Assert.IsTrue(a.Contains(534));
            Assert.IsTrue(a.Contains(579));
            Assert.IsTrue(a.Contains(604));
            Assert.IsTrue(a.Contains(889));
            Assert.IsTrue(a.Contains(668));
            Assert.IsTrue(a.Contains(889));
            Assert.IsTrue(a.Contains(986));
        }


        [TestMethod]
        public void TestRemove6()
        {
            List<TreeNode> myList = new List<TreeNode>();
            myList.Add(15, 271);
            myList.Add(39, 311);
            myList.Add(85, 712);
            myList.Add(418, 774);
            myList.Add(528, 571);
            myList.Add(844, 312);
            myList.Add(902, 33);
            myList.Add(959, 461);
            myList.Add(962, 27);
            myList.Add(988, 55);

            // Add the list to a tree.
            Tree a = new Tree();
            a.Root = a.BuildTree(myList, 0, 9);

            Assert.AreEqual(myList.Count, a.Count());

            a.Remove(15);
            a.Remove(39);
            a.Remove(959);
            a.Remove(85);
            a.Remove(844);
            a.Remove(418);
            a.Remove(528);

            Assert.AreEqual(4, a.Count());

            Assert.IsFalse(a.Contains(1));
            Assert.IsFalse(a.Contains(2));
            Assert.IsFalse(a.Contains(3));
            Assert.IsFalse(a.Contains(15));
            Assert.IsFalse(a.Contains(39));
            Assert.IsFalse(a.Contains(85));
            Assert.IsFalse(a.Contains(959));
            Assert.IsFalse(a.Contains(844));
            Assert.IsFalse(a.Contains(418));

            Assert.IsTrue(a.Contains(528));
            Assert.IsTrue(a.Contains(902));
            Assert.IsTrue(a.Contains(962));
            Assert.IsTrue(a.Contains(988));
        }


    }
}
