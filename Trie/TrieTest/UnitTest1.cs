using MyTrie;
namespace MyTrie.TrieTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Trie trie = new Trie();

            Assert.IsTrue(trie.Add("apple"));
            Assert.IsTrue(trie.Contains("apple"));
            Assert.IsFalse(trie.Contains("banana"));
            Assert.IsTrue(trie.Add("banana"));
            Assert.IsTrue(trie.Contains("banana"));
            Assert.AreEqual(trie.HowManyStartWithPrefix("a"), 1);
            Assert.AreEqual(trie.HowManyStartWithPrefix("b"), 1);
            Assert.AreEqual(trie.Size, 2);

            Assert.IsTrue(trie.Remove("apple"));
            Assert.IsFalse(trie.Contains("apple"));
            Assert.IsFalse(trie.Remove("apple")); // Уже удален
            Assert.IsFalse(trie.Remove("cat")); // Не существует в дереве
            Assert.AreEqual(trie.Size, 1);
        }
    }
}