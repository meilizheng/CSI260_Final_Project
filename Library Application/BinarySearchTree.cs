using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library_Application
{
    // Define the binary search tree class
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        // The root of the tree
        public TreeNode<T> root;
         
        // Method to insert a value into the tree
        public void Insert(T value)
        {
            root = InsertRec(root, value);
        }

        // Recursive helper method to insert a value into the tree
        private TreeNode<T> InsertRec(TreeNode<T> node, T value)
        {
            // If the node is null, create a new node with the value
            if (node == null)
            {
                return new TreeNode<T>(value);
            }

            // If the value is less than the current node's value, go left
            if (value.CompareTo(node.Value) < 0)
            {
                node.Left = InsertRec(node.Left, value);
            }
            // If the value is greater than the current node's value, go right
            else if (value.CompareTo(node.Value) > 0)
            {
                node.Right = InsertRec(node.Right, value);
            }

            return node;
        }

        // Method to search for a value in the tree
        public bool Search(T value)
        {
            return SearchRec(root, value);
        }

        // Recursive helper method to search for a value in the tree
        private bool SearchRec(TreeNode<T> node, T value)
        {
            // If the node is null, the value is not found
            if (node == null)
            {
                return false;
            }

            // If the value is equal to the current node's value, it's found
            if (value.CompareTo(node.Value) == 0)
            {
                return true;
            }
            // If the value is less than the current node's value, search left
            else if (value.CompareTo(node.Value) < 0)
            {
                return SearchRec(node.Left, value);
            }
            // If the value is greater than the current node's value, search right
            else
            {
                return SearchRec(node.Right, value);
            }
        }
    }
}
