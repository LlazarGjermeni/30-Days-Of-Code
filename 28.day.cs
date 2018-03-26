using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
         int i=0;
        string[] names = new string[N];  
        
        for(int a0 = 0; a0 < N; a0++){
            string[] tokens_firstName = Console.ReadLine().Split(' ');
            string firstName = tokens_firstName[0];
            string emailID = tokens_firstName[1];
            
           
            
           if (emailID.EndsWith("@gmail.com"))
               {
                  names[i] = firstName;
               i++;
               }
              
        }
        Array.Sort(names);
       
      for(int j =0; j<names.Length; j++)
          {
         if(names[j] != null)
         {
                 Console.WriteLine(names[j]);
                } 
            
            
    }
               }
}
