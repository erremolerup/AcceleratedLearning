using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace FindwiseUppgift.Test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void should_only_return_barrskog_document_when_searching_for_barrskogen()
        {
            //Arrange
            var simpleSearch = new SimpleSearch();
            simpleSearch.UpdateIndex(File.ReadAllText("Barrskog.txt"), 1);
            simpleSearch.UpdateIndex(File.ReadAllText("Lövskog.txt"), 2);
            simpleSearch.UpdateIndex(File.ReadAllText("Fjällskog.txt"), 3);

            // Act
            List<DocumentRatio> result = simpleSearch.Search("Barrskogen");
            
            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(1, result[0].Id);
        }


        [TestMethod]
        public void should_return_barrskog_and_lövskog_when_search_for_träd()
        {
            //Arrange
            var simpleSearch = new SimpleSearch();
            simpleSearch.UpdateIndex(File.ReadAllText("Barrskog.txt"), 1);
            simpleSearch.UpdateIndex(File.ReadAllText("Lövskog.txt"), 2);
            simpleSearch.UpdateIndex(File.ReadAllText("Fjällskog.txt"), 3);

            // Act
            List<DocumentRatio> result = simpleSearch.Search("Träd");

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(1, result[0].Id);
            Assert.AreEqual(2, result[1].Id);
        }

        [TestMethod]
        public void should_return_all_documents_when_search_for_skog()
        {
            //Arrange
            var simpleSearch = new SimpleSearch();
            simpleSearch.UpdateIndex(File.ReadAllText("Barrskog.txt"), 1);
            simpleSearch.UpdateIndex(File.ReadAllText("Lövskog.txt"), 2);
            simpleSearch.UpdateIndex(File.ReadAllText("Fjällskog.txt"), 3);

            // Act
            List<DocumentRatio> result = simpleSearch.Search("Skog");

            // Assert
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(3, result[0].Id);
            Assert.AreEqual(2, result[1].Id);
            Assert.AreEqual(1, result[2].Id);
        }

        [TestMethod]
        public void should_return_three_hits_when_search_for_findwise()
        {
            // Arrange
            var simpleSearch = new SimpleSearch();
            simpleSearch.UpdateIndex("findwise", 1);
            simpleSearch.UpdateIndex("hej findwise", 2);
            simpleSearch.UpdateIndex("findwise är kul", 3);

            // Act
            List<DocumentRatio> result = simpleSearch.Search("findwise");

            // Assert
            Assert.AreEqual(3, result.Count);

            Assert.AreEqual(1, result[0].Id);
            Assert.AreEqual(1, result[0].Ratio);

            Assert.AreEqual(2, result[1].Id);
            Assert.AreEqual(0.5M, result[1].Ratio);

            Assert.AreEqual(3, result[2].Id);
            Assert.AreEqual((1M / 3M), result[2].Ratio);
        }

        [TestMethod]
        public void should_return_zero_hits_when_search_for_kalle2()
        {
            // Arrange
            var simpleSearch = new SimpleSearch();
            simpleSearch.UpdateIndex("findwise", 1);
            simpleSearch.UpdateIndex("hej findwise", 2);
            simpleSearch.UpdateIndex("findwise är kul", 3);

            // Act
            List<DocumentRatio> result = simpleSearch.Search("kalle");

            // Assert
            Assert.AreEqual(0, result.Count);
        }


        [TestMethod]
        public void should_return_zero_hits_when_search_for_kalle1()
        {
            // Arrange
            var simpleSearch = new SimpleSearch();
            simpleSearch.UpdateIndex("findwise", 1);

            // Act
            List<DocumentRatio> result = simpleSearch.Search("kalle");

            // Assert
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void should_return_one_hit_when_search_for_findwise()
        {
            // Arrange
            var simpleSearch = new SimpleSearch();
            simpleSearch.UpdateIndex("findwise", 1);

            // Act
            List<DocumentRatio> result = simpleSearch.Search("findwise");

            // Assert
            Assert.AreEqual(1, result.Count);

            Assert.AreEqual(1, result[0].Id);
            Assert.AreEqual(1, result[0].Ratio);
        }


        [TestMethod]
        public void should_return_zero_hits_when_search_for_findwise2()
        {
            // Arrange
            var simpleSearch = new SimpleSearch();
            simpleSearch.UpdateIndex("", 1);

            // Act
            List<DocumentRatio> result = simpleSearch.Search("findwise");

            // Assert
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void should_return_zero_hits_when_search_for_findwise1()
        {
            // Arrange
            var simpleSearch = new SimpleSearch();
            simpleSearch.UpdateIndex(null, 1);

            // Act
            List<DocumentRatio> result = simpleSearch.Search("findwise");

            // Assert
            Assert.AreEqual(0, result.Count);
        }
    }
}
