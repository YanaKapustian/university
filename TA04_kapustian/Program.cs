namespace TA04_kapustian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AVLTree tree = new AVLTree();
            //додаємо елементи і дивимося проміжні результати
            tree.Insert(10);
            tree.Insert(20);
            tree.Insert(30);

            Console.WriteLine("\n");
            Node root = tree.GetRoot();
            tree.PrintTree(root);

            tree.Insert(40);

            Console.WriteLine("\n");
            Node root2 = tree.GetRoot();
            tree.PrintTree(root2);

            tree.Insert(50);

            Console.WriteLine("\n");
            Node root3 = tree.GetRoot();
            tree.PrintTree(root3);

            tree.Insert(25);

            Console.WriteLine("\n");
            Node root4 = tree.GetRoot();
            tree.PrintTree(root4);

            Console.WriteLine("Inorder traversal is:");
            tree.InOrder();

            Console.WriteLine("\nPreorder traversal is:");
            tree.PreOrder();

            Console.WriteLine("\nPostorder traversal is:");
            tree.PostOrder();

            tree.Delete(30);
            tree.Delete(40);

            Console.WriteLine("\nInorder traversal after deletion of 30 and 40 is:");
            tree.PreOrder();

            Console.WriteLine("\n");
            Node root5 = tree.GetRoot();

            tree.PrintTree(root5);

            Console.ReadKey();
        }
    }
}