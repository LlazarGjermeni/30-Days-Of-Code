using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        Console.ReadLine();
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        Array.Reverse(arr);
        foreach(var n in arr)
        {
            Console.Write($"{n} ");
        }
    }
}