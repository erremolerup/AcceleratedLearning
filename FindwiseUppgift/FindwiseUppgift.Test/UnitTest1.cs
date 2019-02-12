using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FindwiseUppgift.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void search_for_findwise()
        {
            // Arrange
            Program.ResetIndex();
            Program.UpdateIndex("findwise", 1);
            Program.UpdateIndex("hej findwise", 2);
            Program.UpdateIndex("findwise är kul", 3);

            // Act
            List<DocumentRatio> result = Program.Search("findwise");

            // Assert

            Assert.AreEqual(3, result.Count);

            Assert.AreEqual(1, result[0].Id);
            Assert.AreEqual(1, result[0].Ratio);

            Assert.AreEqual(2, result[1].Id);
            Assert.AreEqual(0.5M, result[1].Ratio);

            Assert.AreEqual(3, result[2].Id);
            Assert.AreEqual((1M /3M), result[2].Ratio);
        }

        [TestMethod]
        public void search_for_kalle()
        {
            // Arrange
            Program.ResetIndex();
            Program.UpdateIndex("findwise", 1);
            Program.UpdateIndex("hej findwise", 2);
            Program.UpdateIndex("findwise är kul", 3);

            // Act
            List<DocumentRatio> result = Program.Search("kalle");

            // Assert

            Assert.AreEqual(0, result.Count);
        }


        [TestMethod]
        public void search1()
        {
            // Arrange
            Program.ResetIndex();
            Program.UpdateIndex("findwise", 1);

            // Act
            List<DocumentRatio> result = Program.Search("kalle");

            // Assert
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void search2()
        {
            // Arrange
            Program.ResetIndex();
            Program.UpdateIndex("findwise", 1);

            // Act
            List<DocumentRatio> result = Program.Search("findwise");

            // Assert
            Assert.AreEqual(1, result.Count);

            Assert.AreEqual(1, result[0].Id);
            Assert.AreEqual(1, result[0].Ratio);
        }


        [TestMethod]
        public void search3()
        {
            // Arrange
            Program.ResetIndex();
            Program.UpdateIndex("", 1);

            // Act
            List<DocumentRatio> result = Program.Search("findwise");

            // Assert
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void search4()
        {
            // Arrange
            Program.ResetIndex();
            Program.UpdateIndex(null, 1);

            // Act
            List<DocumentRatio> result = Program.Search("findwise");

            // Assert
            Assert.AreEqual(0, result.Count);
        }
    }
}
