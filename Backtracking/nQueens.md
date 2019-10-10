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
  
    public static void Bkt(int k)
    {
      for (int i = 0; i < n; i++)
      {
        if (k == n) 
        {
          PrintSolution()
        }
        
        else
        {
          Bkt(k+1);
        }
      }
    }
    
  ```
  
</ol>
