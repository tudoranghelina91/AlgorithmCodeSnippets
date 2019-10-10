        static int Evaluate(TNode root)
        {
            // if node is multiplication operator
            if (root.Value == '*')
                return Evaluate(root.Left) * Calculate(root.Right);
            // if node is division operator
            else if (root.Value == '/')
                return Evaluate(root.Left) / Calculate(root.Right);
            // if node is modulo operator
            else if (root.Value == '%')
                return Evaluate(root.Left) % Calculate(root.Right);
            // if node is addition operator
            else if (root.Value == '+')
                return Evaluate(root.Left) + Calculate(root.Right);
            // if node is substraction operator
            else if (root.Value == '-')
                return Evaluate(root.Left) - Calculate(root.Right);
            else
                return Convert.ToInt32(root.Value.ToString());
        }
