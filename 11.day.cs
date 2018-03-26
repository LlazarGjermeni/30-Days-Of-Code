using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int[][] arr = new int[6][];
        for(int arr_i = 0; arr_i < 6; arr_i++){
           string[] arr_temp = Console.ReadLine().Split(' ');
           arr[arr_i] = Array.ConvertAll(arr_temp,Int32.Parse);
        }
        Console.WriteLine(HourGlass(arr));
    }
    
    static int HourGlass(int [][] arr)
    {
        int max = 0;
        int sum = 0;
        bool read =false;
        for ( int j = 0; j<=6-3; j++)
        {
            for(int i =0; i<=6-3; i++ )
            {
                sum = arr[j][i] + arr[j][i + 1] + arr[j][i + 2] + arr[j + 1][i + 1] + arr[j + 2][i] + arr[j + 2][i + 1] + arr[j + 2][i+ 2];
                if (sum>max|| read == false)
                {
                    max=sum;
                    read = true;
                }
                
            }
        }
        return max;
    }
}