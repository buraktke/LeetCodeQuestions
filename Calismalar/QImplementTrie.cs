using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementTrie
{
    internal class QImplementTrie
    {

        private TrieNode root;

        public QImplementTrie()
        {
            root = new TrieNode();
        }

        public void Insert(string word)
        {
            TrieNode node = root;

            foreach (char ch in word)
            {
                if (!node.Children.ContainsKey(ch))
                    node.Children[ch] = new TrieNode();
                node = node.Children[ch];
            }
            node.IsEnd = true;
        }

        public bool Search(string word)
        {
            TrieNode node = root;

            foreach (char ch in word)
            {
                if (!node.Children.ContainsKey(ch))
                    return false;
                node = node.Children[ch];
            }
            return node.IsEnd;
        }

        public bool StartsWith(string prefix)
        {
            TrieNode node = root;

            foreach (char ch in prefix)
            {
                if (!node.Children.ContainsKey(ch))
                    return false;
                node = node.Children[ch];
            }
            return true;
        }
    }

    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
        public bool IsEnd = false;
    }
}
