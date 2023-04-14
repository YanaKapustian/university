using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA04_kapustian
{
    public class AVLTree
    {
        private Node root;
        public Node GetRoot()
        {
            return root;
        }

        // розмір дерева
        public int Size()
        {
            return Size(root);
        }

        private int Size(Node node)
        {
            if (node == null)
                return 0;
            else
                return 1 + Size(node.left) + Size(node.right);
        }

        // додавання елементу
        public void Insert(int data)
        {
            root = Insert(root, data);
        }

        private Node Insert(Node node, int data)
        {
            if (node == null)
                return new Node(data);

            if (data < node.data)
                node.left = Insert(node.left, data);
            else if (data > node.data)
                node.right = Insert(node.right, data);
            else
                return node;

            node.height = 1 + Math.Max(Height(node.left), Height(node.right));

            int balance = Balance(node);

            // Якщо дерево не збалансоване, то проводимо повороти
            if (balance > 1 && data < node.left.data)
                return RotateRight(node);

            if (balance > 1 && data > node.left.data)
            {
                node.left = RotateLeft(node.left);
                return RotateRight(node);
            }

            if (balance < -1 && data > node.right.data)
                return RotateLeft(node);

            if (balance < -1 && data < node.right.data)
            {
                node.right = RotateRight(node.right);
                return RotateLeft(node);
            }

            return node;
        }

        // видалення елементу
        public void Delete(int data)
        {
            root = Delete(root, data);
        }

        private Node Delete(Node node, int data)
        {
            if (node == null)
                return node;

            if (data < node.data)
                node.left = Delete(node.left, data);
            else if (data > node.data)
                node.right = Delete(node.right, data);
            else
            {
                if ((node.left == null) || (node.right == null))
                {
                    Node temp = null;
                    if (temp == node.left)
                        temp = node.right;
                    else
                        temp = node.left;

                    if (temp == null)
                    {
                        temp = node;
                        node = null;
                    }
                    else
                        node = temp;
                }
                else
                {
                    Node temp = MinimumValueNode(node.right);
                    node.data = temp.data;
                    node.right = Delete(node.right, temp.data);
                }
            }

            if (node == null)
                return node;

            node.height = 1 + Math.Max(Height(node.left), Height(node.right));

            int balance = Balance(node);
            if (balance > 1 && data < node.left.data)
                return RotateRight(node);

            if (balance > 1 && data > node.left.data)
            {
                node.left = RotateLeft(node.left);
                return RotateRight(node);
            }

            if (balance < -1 && data > node.right.data)
                return RotateLeft(node);

            if (balance < -1 && data < node.right.data)
            {
                node.right = RotateRight(node.right);
                return RotateLeft(node);
            }

            return node;
        }
        private Node MinimumValueNode(Node node)
        {
            Node current = node;
            while (current.left != null)
                current = current.left;
            return current;
        }

        // висота дерева
        private int Height(Node node)
        {
            if (node == null)
                return 0;
            return node.height;
        }

        // баланс дерева
        private int Balance(Node node)
        {
            if (node == null)
                return 0;
            return Height(node.left) - Height(node.right);
        }

        // правий поворот
        private Node RotateRight(Node node)
        {
            Node newRoot = node.left;
            node.left = newRoot.right;
            newRoot.right = node;

            node.height = Math.Max(Height(node.left), Height(node.right)) + 1;
            newRoot.height = Math.Max(Height(newRoot.left), Height(newRoot.right)) + 1;

            return newRoot;
        }

        // лівий поворот
        private Node RotateLeft(Node node)
        {
            Node newRoot = node.right;
            node.right = newRoot.left;
            newRoot.left = node;

            node.height = Math.Max(Height(node.left), Height(node.right)) + 1;
            newRoot.height = Math.Max(Height(newRoot.left), Height(newRoot.right)) + 1;

            return newRoot;
        }

        // функції для роботи з деревом
        public void InOrder()
        {
            InOrder(root);
        }

        private void InOrder(Node node)
        {
            if (node != null)
            {
                InOrder(node.left);
                Console.Write(node.data + " ");
                InOrder(node.right);
            }
        }

        public void PreOrder()
        {
            PreOrder(root);
        }

        private void PreOrder(Node node)
        {
            if (node != null)
            {
                Console.Write(node.data + " ");
                PreOrder(node.left);
                PreOrder(node.right);
            }
        }

        public void PostOrder()
        {
            PostOrder(root);
        }

        private void PostOrder(Node node)
        {
            if (node != null)
            {
                PostOrder(node.left);
                PostOrder(node.right);
                Console.Write(node.data + " ");
            }
        }
        //вивести дерево в консоль
        public void PrintTree(Node node, int level = 0)
        {
            if (node == null) return;

            PrintTree(node.right, level + 1);
            Console.WriteLine(new string(' ', level * 2) + node.data);
            PrintTree(node.left, level + 1);
        }

    }

}
