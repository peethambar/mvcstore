using System;
using BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTreeTests
{
    [TestClass]
    public class Find
    {
        [TestMethod]
        public void Find_Empty()
        {
            BinaryTree<int> list = new BinaryTree<int>();
            Assert.IsFalse(list.Contains(10), "Nothing should have been found.");
        }

        [TestMethod]
        public void Find_Missing()
        {
            int[] testData = new int[] {0, 1, 7, 9, 3 };
            int value = 8;
            BinaryTree<int> list = new BinaryTree<int>();
            foreach (int data in testData)
            {
                list.Add(data);
            }

            Assert.IsFalse(list.Contains(value), "Nothing should have been found.");
        }

        [TestMethod]
        public void Find_Found()
        {
            int[] testData = new int[] { 0, 1, 7, 9, 3 };
            int value = 3;

            BinaryTree<int> list = new BinaryTree<int>();
            foreach (int data in testData)
            {
                list.Add(data);
            }

            Assert.IsTrue(list.Contains(value), "There should have been a node found");
        }
    }
}
