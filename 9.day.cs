using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int factorial(int n) {
        // Complete this function
        if (n==1)
        {
            return 1;
        }
        return factorial(n-1) * n;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        
        // if (n==1)
        // {
        //     return ;
        // }
        // int result = (n-1) * n;
    Console.WriteLine(factorial(n));    
      
    }
}