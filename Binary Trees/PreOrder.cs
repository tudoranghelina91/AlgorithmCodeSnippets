        static void PreOrder(TNode node)
        {
            if (node == null)
            {
                return;
            }

            Console.Write($"{node.Value} ");
            PreOrder(node.Left);
            PreOrder(node.Right);
        }
