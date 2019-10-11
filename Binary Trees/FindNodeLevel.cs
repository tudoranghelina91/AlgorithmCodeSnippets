        static int FindLevel(TNode node)
        {
            if (node == null)
            {
                return 0;
            }

            return 1 + Math.Max(FindLevel(node.Left), Depth(node.Right));
        }
