using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Application
{  
    public class Library
    {
        // Create a binary search tree to store books
        private BinarySearchTree<Book> booksBST;

        // Constructor to initialize the library
        public Library()
        {
            // Initialize the binary search tree
            booksBST = new BinarySearchTree<Book>();
        }

        // Method to add a book to the library
        public void AddBook(Book book)
        {
            // Insert the book into the binary search tree
            booksBST.Insert(book);
        }

        // Method to search for a book by ISBN
        public Book SearchByISBN(int isbn)
        {
            // Start searching from the root of the binary search tree
            return SearchByISBNRec(booksBST.root, isbn);
        }

        // Recursive helper method to search for a book by ISBN
        private Book SearchByISBNRec(TreeNode<Book> node, int isbn)
        {
            // If the node is null, the book is not found
            if (node == null)
            {
                return null;
            }

            // If the ISBN of the current node's book matches the target ISBN, return the book
            if (node.Value.ISBN == isbn)
            {
                return node.Value;
            }
            // If the target ISBN is less than the current node's book's ISBN, search left
            else if (isbn < node.Value.ISBN)
            {
                return SearchByISBNRec(node.Left, isbn);
            }
            // If the target ISBN is greater than the current node's book's ISBN, search right
            else
            {
                return SearchByISBNRec(node.Right, isbn);
            }
        }
    }

}
