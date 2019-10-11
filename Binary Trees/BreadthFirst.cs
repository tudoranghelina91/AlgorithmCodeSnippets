        static void BreadthFirst(TNode root)
        {
            Queue nodes = new Queue();
            nodes.Add(root);
            while (!nodes.IsEmpty())
            {
                TNode n = nodes.Remove();
                if (n != null)
                {
                    if (n.Left != null)
                        nodes.Add(n.Left);
                    if (n.Right != null)
                        nodes.Add(n.Right);
                    Console.Write($"{n.Value} ");
                }
            }
        }
