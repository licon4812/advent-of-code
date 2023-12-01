// See https://aka.ms/new-console-template for more information
using System;

var data = File.ReadAllLines("../../../data.txt");
var numbers = new List<string>();

foreach (var line in data)
{
    var lineNumbers = line.Where(char.IsNumber).Aggregate("", (current, t) => current + t);
    numbers.Add(lineNumbers);
}

var result = 0;
foreach (var line in numbers)
{
   //combine the first and last number of each line
   var first = line.First().ToString();
   var last = line.Last().ToString();
   var combined = first + last;
   var combinedInt = int.Parse(combined);
   result += combinedInt;
}

Console.WriteLine(result);



