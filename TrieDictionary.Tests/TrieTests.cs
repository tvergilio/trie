using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrieDictionary;

namespace TrieDictionary.Tests
{
    [TestClass]
    public class TrieTests
    {
        [TestMethod]
        public void TestInsertAndRetrieve()
        {
            Trie trie = new Trie();
            trie.Insert("test");
            var words = trie.GetAllWords();
            Assert.IsTrue(words.Contains("test"));
        }
    }
}
