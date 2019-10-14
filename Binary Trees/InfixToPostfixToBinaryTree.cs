/* Shunting yard algorithm is used to convert an infix expression to a postfix expression. 
 * This algorithm will convert an infix expression (normal arithmetic expression)
 * to a postfix expression using Reverse Polish Notation which is an expression using the following format:
 * [operand1][operand2][operator] e.g. [1][3][+] (without brackets)
 */

public static string ShuntingYard(string infix)
{
    // Queue which holds the output postfix expression characters in proper order
    Queue<char> outputQueue = new Queue<char>();
    
    // Stack used for the operators
    Stack<char> operatorStack = new Stack<char>();
    
    /* We use the stringbuilder to append the elements inside the output queue 
     * and return all of them as a string
     */
    StringBuilder sb = new StringBuilder();

    // loop through every element of the infix expression
    for (int i = 0; i < infix.Length; i++)
    {
        // if the current character is an operand (in this case letter or digit)
        if (char.IsLetterOrDigit(infix[i]))
        {
            // append the operand character to the output queue 
            outputQueue.Enqueue(infix[i]);
        }
        
        // if the current character is an operator (in this case * for multiplication or + for addition)
        if (infix[i] == '*' || infix[i] == '+')
        {
            /* As long as the operator stack has elements and the current operator has higher or equal precedence
             * WHERE * is 42 and + is 43 in ASCII notation
             * AND
             * The operator at the top of the stack is not a left paranthesis
             */
             
            while (operatorStack.Count > 0 && infix[i] <= operatorStack.Peek() && operatorStack.Peek() != '(')
            {
                // pop elements from the operator stack and place them inside the output queue   
                outputQueue.Enqueue(operatorStack.Pop());
            }
            
            // Then push the current operator onto the operator stack
            operatorStack.Push(infix[i]);
        }
        
        // if the current character is a left paranthesis
        if (infix[i] == '(')
        {
            // push the left paranthesis onto the operatorStack
            operatorStack.Push(infix[i]);
        }
        
        // if the current character is a right paranthesis
        if (infix[i] == ')')
        {
            // as long as the element at the top of the operator stack IS NOT a left paranthesis
            while (operatorStack.Peek() != '(')
            {
                // pop elements from the stack and put them inside the output queue
                outputQueue.Enqueue(operatorStack.Pop());
            }
            
            // After the while loop, if there is a left paranthesis at the top of the operator stack
            if (operatorStack.Peek() == '(')
            {
                // pop the left paranthesis from the operator stack and discard it
                operatorStack.Pop();
            }
        }
    }

    // Once we reach at the end of the infix expression...
    
    // As long as we have elements inside the operator stack
    while (operatorStack.Count != 0)
    {
        // Pop the remaining operators from the operator stack to the output queue
        outputQueue.Enqueue(operatorStack.Pop());
    }

    // As long as the output queue has elements
    while (outputQueue.Count != 0)
    {
        // remove all elements from the queue and append them to the StringBuilder
        sb.Append(outputQueue.Dequeue());
    }
    
    // Once we've finished removing all elements from the queue and appending them to the string builder
    // Return the postfix expression
    return sb.ToString();
}


// Function used to parse postfixExpression to Binary Tree

public static MathTreeNode BuildTree(string postfixExpression)
{
    // Stack used to hold all the nodes
    Stack<MathTreeNode> mathTreeNodes = new Stack<MathTreeNode>();
    // loop through all the elements inside the postfix expression
    for (int i = 0; i < pattern.Length; i++)
    {
        // if the current character is an operand
        if (char.IsLetterOrDigit(postfixExpression[i]))
        {
            // Create a new tree node to store the operand and push it onto the stack
            mathTreeNodes.Push(new MathTreeNode(postfixExpression[i]));
        }

        // Otherwise, if the current character is an operator
        else
        {
            // Create a new root for the binary tree to store the operator
            MathTreeNode root = new MathTreeNode(postfixExpression[i]);
            
            // Pop two elements from the stack and append them to the left respectively to the right of the current root
            root.Left = mathTreeNodes.Pop();
            root.Right = mathTreeNodes.Pop();
            
            // Push the root node onto the stack
            mathTreeNodes.Push(root);
        }

    }
    
    // once we've finished looping through the postfix expression string
    // pop and return the last element of the node stack which should be the root of the tree
    return mathTreeNodes.Pop();
}
