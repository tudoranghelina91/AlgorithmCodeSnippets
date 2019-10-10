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

    static int[] arr = new int[4];

  ```
    
  </li>
  <li>
    <h3>The Backtracking Function</h3>
  </li>
  <p>The Backtracking function will search for every possible combination and will be used to output our result once the result array is filled.</p>
  
  ```C#
  
    static void Bkt(int k, int[] arr)
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
  <p>The Valid Function will check if the condition of the problem is met. Let's say, for example, that a solution is viable only and only if all layers of the result array have distinct values. The code above will display all combinations of digits from 1 to 4 so the output will most certainly contain any of the following combination of digits: <code>1111, 1232, 1234, 1313</code></p>
  <p>In order to avoid that and obtain only the combination of distinct digits, like <code>1234, 3142, 2134, etc.</code> we will have to filter the result by performing additional checks on the result array, and for that, we will use a valid function, which will check the current level of the result array if it contains a value already present in the array.</p>
  
  ```C#
  
  static bool valid (int k, int[] arr)   // k - current level inside the result array
  {
    for (int i = 0; i < k; i++)
    {
      if (arr[i] == arr[k])   // if one of the levels before the current level is equal to the value of the current level
      {
        return false;       // the value of the current doesn't meet the requirements of a valid output
      }
    }
    
    return true;      // otherwise, the value on the current level meets the requirements of a valid output
  }
  
  
  ```
  
</ol>
