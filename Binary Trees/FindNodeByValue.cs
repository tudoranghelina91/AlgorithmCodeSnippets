        static TNode Find(TNode root, char value)
        {
            if (root != null)
            {
                if (root.Value == value)
                {
                    return root;
                }

                else
                {
                    TNode node = Find(root.Left, value);
                    if (node == null)
                    {
                        node = Find(root.Right, value);
                    }

                    return node;
                }
            }

            return null;
        }
