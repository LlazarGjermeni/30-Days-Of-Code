using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        var actuallyDate = Console.ReadLine().Split(' ');
        
        var actuallyDay = int.Parse(actuallyDate[0]);
        var actuallyMonth = int.Parse(actuallyDate[1]);
        var actuallyYear = int.Parse(actuallyDate[2]);
        
        var enteredDate = Console.ReadLine().Split(' ');
        var enteredDay = int.Parse(enteredDate[0]);
        var enteredMonth = int.Parse(enteredDate[1]);
        var enteredYear = int.Parse(enteredDate[2]);
        
        var fine = 0;
         if(actuallyYear>enteredYear){
             fine = 10000;
        }else if(actuallyYear==enteredYear)
         {
             if(actuallyMonth>enteredMonth)
                 fine = (actuallyMonth-enteredMonth)* 500;
             else if (actuallyMonth==enteredMonth && actuallyDay> enteredDay)
                 fine= (actuallyDay-enteredDay) *15;
         }
           Console.WriteLine(fine); 
    }
}