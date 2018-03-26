class Solution {
    static void Main(String[] args) {
       
int i=4;
double d =4.0;
string s = "HackerRank";

 // Declare second integer, double, and String variables.
        int isec;
        double dsec;
        string ssec;
        // Read and save an integer, double, and String to your variables.
       isec = int.Parse(Console.ReadLine());
        dsec = double.Parse(Console.ReadLine());
       ssec = Console.ReadLine();
         
        // Print the sum of both integer variables on a new line.
        Console.WriteLine( String.Format("{0:0}",i + isec));
        // Print the sum of the double variables on a new line.
         Console.WriteLine( String.Format("{0:0.0}",d + dsec));
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
 Console.WriteLine(s + ssec);