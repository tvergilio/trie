using System;
using System.Text;

namespace TrieDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "as", "astronaut", "asteroid", "are", "around", "cat", "cars", "cares", "careful", "carefully", "for", "follows", "forgot", "from", "front", "mellow", "mean", "money", "monday", "monster", "place", "plan", "planet", "planets", "plans", "the", "their", "they", "there", "towards" };
            Trie dictionary = InitializeTrie(words);
            Console.WriteLine("Trie initialized.");
            // Call exercise functions here if needed
        }

        static Trie InitializeTrie(string[] words)
        {
            Trie trie = new Trie();
            foreach (string word in words)
            {
                trie.Insert(word);
            }
            return trie;
        }
    }
}
