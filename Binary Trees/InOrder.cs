        static void InOrder(TNode node)
        {
            if (node.Left != null)
            {
                InOrder(node.Left);
            }

            Console.Write($"{node.Value} ");

            if (node.Right != null)
            {
                InOrder(node.Right);
            }
        }
