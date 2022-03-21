using System.Linq;
// See https://aka.ms/new-console-template for more information

int[] ints = { 1, 20, 3, 4, 55, 6, 7 };

var sortedInts = ints.OrderBy(x => x);
foreach (int i in sortedInts) 
{ Console.WriteLine(i);
}


