using System;
using System.Collections.Generic;
using System.IO;
abstract class Book
{
    
    protected String title;
    protected  String author;
    
    public Book(String t,String a){
        title=t;
        author=a;
    }
    public abstract void display();


}
//Write MyBook class
class MyBook : Book
{
int price;
 public MyBook (string t, string a, int p):base(t,a)
 {
 price = p;
 }
 public override void display()
 {
 var Display = $"Title: {title}\nAuthor: {author}\nPrice: {price}";
 Console.WriteLine(Display);
 }
}
class Solution {
    static void Main(String[] args) {
      String title=Console.ReadLine();
      String author=Console.ReadLine();
      int price=Int32.Parse(Console.ReadLine());
      Book new_novel=new MyBook(title,author,price);
      new_novel.display();
    }
}