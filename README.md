# AlgorithmCodeSnippets
<h1>Reading a binary tree from a string with parantheses</h1>

<p>Let's assume that we have a binary tree structure presented with parantheses in the form of a pattern like the one below:
<br />
  <code>
    string pattern = "(A(B(D,E),C(F,G))"
  </code>
</p>

<p>
  This string contains instructions on how the tree should be built. For example, the string <code>(A(B(-,E),C(F,-))</code> would instruct us to build the string like so:
</p>

![alt text](https://github.com/tudoranghelina91/AlgorithmCodeSnippets/blob/master/Binary%20Tree.png)

<p>If we take a closer look at the image and string, we would notice that the input string will give us some hints on how to build the file</p>
<code>
  <ul>
    <li>Any letter from the alphabet represents the value of a node</li>
    <li><b>(</b> indicates the insertion of children for the current node, left and right in that order</li>
    <li><b>,</b> indicates the insertion of the Right Node. The character before <b>,</b> is the left neighbor and the one after the right one</li>
    <li><b>)</b> indicates that there are no more children to insert</li>
  </ul>
</code>

<p>Therefore, based on the aforementioned facts, the algorithm in simple steps would sound something like this</p>

<code>
  i = 0;  // Used to track the position in the string;
  BEGIN READ TREE
    IF (PATTERN STRING LENGTH = 1)  // The pattern string has only a single node (the root node)
      RETURN NEW NODE;
    ELSE
      CREATE NODE(instructions[i])
      i++;
</code>

<code>
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

</code>
