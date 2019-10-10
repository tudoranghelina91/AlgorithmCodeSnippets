# Evaluating Expression Trees

<p>An arithmetic expression tree is a binary tree represented with two type of nodes. Operator nodes and value nodes like so:</p>

![alt text](https://github.com/tudoranghelina91/AlgorithmCodeSnippets/blob/master/Binary%20Trees/Expression%20Tree.png)

<p>As you can see in the above diagram, the nodes that aren't leaves of the tree represent value nodes and the others represent operator nodes.</p>

<p>Each operator node indicates the beginning of an arithmetic expression between brackets. For example, the above expression tree could be written like so:</p>

<code>(1 + 2) * (4 - (9 % 3) = 3 * (4 - 0) = 3 * 4 = 12</code>

<p>Basically, what we are doing is keep traversing the tree repeatedly until a value node is found, first to the left, and then to the right, and on our way back, we will perform the operation of the left and right node.</p>

<b>Let's take a look at the following C# code</b>

```C#
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
```

As you can see above, the code keeps checking if the node is an expression node or a value node. If it is an expression, it recursively calls for the <code>Evaluate(Tnode root)</code> function twice, for each operand, until a value node is found like so:

```C#
            if (root.Value == '*')
                return Evaluate(root.Left) * Calculate(root.Right);
```

When a value node is found, it returns the execution to the last called function

```C#
            else
                return Convert.ToInt32(root.Value.ToString());
```

<h3>I hope you all enjoyed this! I personally needed this info!!!</h3>
