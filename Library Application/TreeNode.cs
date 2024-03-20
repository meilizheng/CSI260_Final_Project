using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Application
{
    public class TreeNode<T>
    {
        // Each node has a value of type T
        public T Value { get; set; }

        // Each node has references to its left and right children
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        // Constructor to initialize a node with a value
        public TreeNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
