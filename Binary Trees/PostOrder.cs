        static void PostOrder(TNode node)
        {
            if (node.Left != null)
            {
                PostOrder(node.Left);
            }


            if (node.Right != null)
            {
                PostOrder(node.Right);
            }

            Console.Write($"{node.Value} ");
        }
