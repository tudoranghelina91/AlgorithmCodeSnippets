        static TNodeInt Min(TNodeInt root)
        {
            if (root == null)
            {
                return new TNodeInt(0);
            }

            TNodeInt result = root;
            TNodeInt leftResult = Max(root.Left);
            TNodeInt rightResult = Max(root.Right);

            if (leftResult.Value < result.Value)
                result = leftResult;
            if (rightResult.Value < result.Value)
                result = rightResult;

            return result;
        }

        static TNodeInt Max(TNodeInt root)
        {
            if (root == null)
            {
                return new TNodeInt(0);
            }

            TNodeInt result = root;
            TNodeInt leftResult = Max(root.Left);
            TNodeInt rightResult = Max(root.Right);

            if (leftResult.Value > result.Value)
                result = leftResult;
            if (rightResult.Value > result.Value)
                result = rightResult;

            return result;
        }
