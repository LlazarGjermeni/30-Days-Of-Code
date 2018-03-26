using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        double meal_cost = Convert.ToDouble(Console.ReadLine());
        int tip_percent = Convert.ToInt32(Console.ReadLine());
        int tax_percent = Convert.ToInt32(Console.ReadLine());
        double tip = meal_cost * tip_percent / 100;
        double tax = meal_cost * tax_percent / 100;
        var totalCost = Math.Round(tip + tax + meal_cost);
        Console.WriteLine($"The total meal cost is {totalCost} dollars.");
    }
}