// See https://aka.ms/new-console-template for more information

using System.Collections;

Stack<int> stack = new Stack<int>();
stack.Push(0);
stack.Push(1);
stack.Push(2);
stack.Push(3);
while (stack.Count > 0) { 
var pushit = stack.Pop();
Console.WriteLine(pushit);
}
int? enull= 10;
enull = null;
Console.WriteLine(enull.HasValue);

int? num = 5;
//int num1 = (int)num;
int num1 = num.Value;
Console.WriteLine(num1);

int? g =null;
int? f = null;
int h = g ?? f ?? -1;
Console.WriteLine(h);

ArrayList newArray = new ArrayList();
newArray.Add(1);
newArray.Add("asta");
foreach (var item in newArray) 
{
    Console.WriteLine(item);
}


Colors colors = Colors.Red;
Console.WriteLine(((int)colors));

List<string> strings = new List<string>() { "ana", "has"};
List<string> strings1 = new List<string>() { "5", "apples"};
strings.AddRange(strings1);
foreach (var item in strings) 
{
    Console.Write(item + " "); 
}

Dictionary<int, string> myDict = new Dictionary<int, string>();
myDict.Add(1, "bananas");
myDict.Add(2, "apples");
myDict.Add(3, "bananas");

foreach(var item in myDict) { Console.WriteLine(item); }

if(myDict.TryGetValue(4, out string value)) { Console.WriteLine(value); }
else { Console.WriteLine("not found"); }

Animal Pisic = new Animal("houdi");

class Animal 
{
    public string Name { get; set; }
    public Animal(string name)
    {
        Name = name;
            }
}

enum Colors {Red=3, Green, Yellow};


