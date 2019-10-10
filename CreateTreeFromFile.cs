        static TNode BuildTree(string instructions)
        {
            int i = 0;

            if (instructions.Length == 1)
            {
                return new TNode(instructions[i]);
            }

            else
            {
                TNode root = new TNode(instructions[i++]);

                if (instructions[i] == '(')
                {
                    i++;
                    if (char.IsLetter(instructions[i]))
                        root.Left = BuildTree(instructions);
                    else
                    {
                        i++;
                    }

                    i++;

                    if (char.IsLetter(instructions[i]))
                        root.Right = BuildTree(instructions);
                    else
                    {
                        i++;
                    }
                }

                return root;
            }
        }
