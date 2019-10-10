# N Queens

<p>Let's say that we have a chessboard of size N Squares * N Squares. The requirement of the problem is to place N number of queens on the chessboard in such a way that they cannot capture each other. Like in the example below: </p>

![alt text](https://github.com/tudoranghelina91/AlgorithmCodeSnippets/blob/master/Backtracking/nQueens.png)

<p>As you can see, just as in chess, in order for the queens not to attack each other, two queens must not be on the same line, column or diagonal of the chess board.</p>

<p>Before we take a look at the solution, let's recap how backtracking works for permutations</p>

<ol>
  <li>
    <h3>The Result Array</h3>
    <p>The result array will hold the result of the combinations. Once all positions of the array are filled, the result will get printed on the screen. We will get into the details on why we need an array later</p>
    
  ```C#

    int[] arr = new int[4];

  ```
    
  </li>
  <li>
    <h3>The Backtracking Function</h3>
  </li>
  <p>The Backtracking function will search for every possible combination and will be used to output our result once the result array is filled.</p>
  
  ```C#
  
    public static void Bkt(int k, int[] arr)
    {
      for (int i = 0; i < n; i++)
      {
        // If all levels of the result array are filled
        if (k == arr.Length) 
        {
          // Output the result
          PrintResult(int[] arr)
        }
        
        // Otherwise
        else
        {
          // Fill the next level of the solution array
          Bkt(k+1);
        }
      }
    }
    
  ```
  
  <li>
    <h3>The Valid Function</h3>
  </li>
  <p>The Valid Function will check if the condition of the problem is met. Let's say, for example, that a solution is viable only and only if all layers of the result array have distinct values. The code above will display all permutations, not taking into account a condition, so... the output could be something like: <code>1111, 1232, 1234, 1313</code>
  
</ol>
