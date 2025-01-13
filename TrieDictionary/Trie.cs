using System;
using System.Collections.Generic;
using System.Linq;

namespace TrieDictionary
{
    public class Trie
    {
        private TrieNode root;

        public Trie()
        {
            root = new TrieNode();
        }

        public void Insert(string word)
        {
            TrieNode current = root;
            foreach (char c in word)
            {
                if (!current.Children.ContainsKey(c))
                {
                    current.Children[c] = new TrieNode();
                }
                current = current.Children[c];
            }
            current.IsEndOfWord = true;
        }

        public List<string> GetAllWords()
        {
            return GetAllWordsWithPrefix(root, "");
        }

        private List<string> GetAllWordsWithPrefix(TrieNode node, string prefix)
        {
            List<string> words = new();
            if (node.IsEndOfWord)
            {
                words.Add(prefix);
            }

            foreach (var child in node.Children)
            {
                words.AddRange(GetAllWordsWithPrefix(child.Value, prefix + child.Key));
            }

            return words;
        }
        public class TrieNode
        {
            public Dictionary<char, TrieNode> Children { get; private set; }
            public bool IsEndOfWord { get; set; }

            public TrieNode()
            {
                Children = new Dictionary<char, TrieNode>();
            }
        }
    }
}