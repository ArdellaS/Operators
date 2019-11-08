using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the solve function below.
    static void solve(double meal_cost, int tip_percent, int tax_percent)
    {

        double price = meal_cost;
        int tip = ((int)price * tip_percent / 100);

        int tax = (int)Math.Ceiling(((int)price * (tax_percent / 100.00)));

        double totalCost = price + tip + tax;

        Console.WriteLine($"{Math.Ceiling(totalCost)}");

    }

    static void Main(string[] args)
    {
        double meal_cost = 10.25;

        int tip_percent = 17;

        int tax_percent = 5;

        solve(meal_cost, tip_percent, tax_percent);
    }
}
