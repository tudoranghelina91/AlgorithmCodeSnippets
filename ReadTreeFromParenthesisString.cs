        // Reading Binary Tree From Parenthesis String
        
        // sample string
        string instructions = "(A(B(D,E),C(F,G))";
        
        // Read the tree from file
        static TNode ReadTreeFromFile(ref int i, string instructions)
        {
            // Check if string has only one node (ROOT NODE)
            if (instructions.Length == 1)
            {
                // Return root node with value
                return new TNode(instructions[i]);
            }

            
            else
            {
                // Create a new node and advance to the next character inside the string
                TNode root = new TNode(instructions[i++]);

                // Check if the next character is an open paranthesis
                if (instructions[i] == '(')
                {
                    // Advance to the next position in the string
                    i++;
                    
                    // If the current character is a letter add the letter to the left side of the current node
                    if (char.IsLetter(instructions[i]))
                        root.Left = BuildTree(ref i, instructions);
                    
                    // Else (the character is - which indicates that the current node doesn't have a child on the left side)
                    else
                    {
                        // Advance to the next position inside the string
                        i++;
                    }
                    
                    // Advance to the next position to skip ',' (which indicates the beginning of a sibling on the right side)
                    i++;

                    // If the current character is a letter add the letter to the right side of the current node
                    if (char.IsLetter(instructions[i]))
                        root.Right = BuildTree(ref i, instructions);
                    // Else (the character is - which indicates that the current node doesn't have a child on the left side)
                    else
                    {
                        // Advance to the next position inside the string
                        i++;
                    }
                    // Advance to the next position to skip ')' (which indicates that the right neighbor has been added)
                    i++;
                }
                // return the current node along with it's children
                return root;
            }
        }
