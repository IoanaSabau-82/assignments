using FindPetOwner;
using System.Collections.Generic;

NonGroupMember user1 = new NonGroupMember("Jaime", "Lannister");
NonGroupMember user2 = new NonGroupMember("Arya", "Stark");
NonGroupMember user3 = new NonGroupMember("Theon", "Greyjoy");

GroupMember user4 = new GroupMember("Ana", "Danciu");
GroupMember user5 = new GroupMember("Carmen", "Amariei");
GroupMember user6 = new GroupMember("Ana", "Coroiu");
GroupMember user7 = new GroupMember("Gheorghina", "Ariel");

TimeOnly[] liber = { new TimeOnly(10, 0), new TimeOnly(11, 0) };
double[] gpsLocation = {1145.456, 111457,80 };

Post post1 = new Post(new int[]{ 1, 2 },"telefon1","adresa1",liber,"comentariu", gpsLocation,user1 );
Post post2 = new Post(new int[]{ 1, 2 },"telefon2","adresa2",liber,"comentariu", gpsLocation,user2 );
Post post3 = new Post(new int[]{ 1, 2 },"telefon3","adresa3",liber,"comentariu", gpsLocation,user3 );
Post post4 = new Post(new int[]{ 1, 2 },"telefon3","adresa3",liber,"comentariu", gpsLocation,user3 );

Console.Write($"{ post1.Phone}, {post1.Address}, {string.Join(" ",post1.Availability)}, {post1.Comment}, {post1.status}\n");


List<User> users = new List<User>() { user1, user2, user3, user4, user5, user6, user7 };
List<User> users1 = new List<User>() { user1, user2, user3, user4, user5, user6, user7 };
List<Post> posts = new List<Post>() { post3, post2, post1,post4 };

HashSet<User> userSet1 = new HashSet<User>() { user1, user2, user3 };
HashSet<User> userSet2= new HashSet<User>() { user1, user2, user4};


//filtering operators

var gM = users.Where(user => user is GroupMember);

Console.WriteLine("\nonly group members");
Display(gM);

var first2 = users.Take(2);
Console.WriteLine("\nfirst 2 users");
Display(first2);

var last2 = users.TakeLast(2);
Console.WriteLine("\nlast 2 users");
Display(last2);


var exceptFirst2 = users.Skip(2);
Console.WriteLine("\nall except first 2 users");
Display(exceptFirst2);


// mai incearca chestia asta odata cu skip while is take while
/*var userAna = users.Where(user => user.Surname is "Ana");
Console.WriteLine("\nsurname Ana");
Display(userAna);*/


//projection
var selectName = users.Select(user => user.Name);
Console.WriteLine("\njust names");
Display(selectName);


//ordering

var ordered = users.OrderBy(user => user.Name).ThenBy(user => user.Surname);
Console.WriteLine("\nordered by name and surname");
Display(ordered);


var orderedDesc = users.OrderByDescending(user => user.Name).ThenByDescending(user => user.Surname);
Console.WriteLine("\nordered descending by name and surname");
Display(orderedDesc);

users.Reverse();
Console.WriteLine("\nreversed users seq.");
Display(users);

//grouping
var groupByuser = posts.GroupBy(x => x.User);
Console.WriteLine("\ngroup post by user");
foreach(var group in groupByuser) 
{foreach (var item in group) 
    { Console.WriteLine(item.User); }
}


var concatenated = userSet1.Concat(userSet2);
Console.WriteLine("\nconcatenated");
Display(concatenated);

var union = userSet1.Union(userSet2);
Console.WriteLine("\nunion");
Display(union);

var except = userSet1.Except(userSet2);
Console.WriteLine("\nexcept");
Display(except);


//conversion
List<object> list = new List<object>() {1,2,3,"Lista", user1 };
List <User> userList = list.OfType<User>().ToList();
Console.WriteLine("\nreturns only the elements of a specific type");
Display(userList);

List<object> casting = new List<object>() { 1.0, 2.0, 3.0 };
casting.Add(4.0);
List<double> casting2 = casting.Cast<double>().ToList();
Display(casting2);

Dictionary<string, User> map = users.ToDictionary(x=>x.Name);
foreach (KeyValuePair<string, User> kvp in map) 
{ Console.WriteLine($" key { kvp.Key}, value { kvp.Value}"); }

var toQueryTable = users.AsQueryable();
Console.WriteLine($"users sequence type {users.GetType().Name}");
Console.WriteLine($"toQueryTable sequence type {toQueryTable.GetType().Name}");

//element operators

var firstSName = users.FirstOrDefault(x=>x.Name.StartsWith('S'),user6);
Console.WriteLine($"first name that starts with S. If none meet condition, returns user 6 {firstSName}");

/*throws exception because of multiple results
 
var singleAName = users.Single(x => x.Name.StartsWith('A'));
Console.WriteLine(singleAName);*/


var secondElement = users.ElementAt(1);
Console.WriteLine($"second element {secondElement}");


//aggregation methods

var nrOfUsers=users.Count();
var nrOfUsersWithCondition=users.LongCount(x=>x.Name=="Stark");
Console.WriteLine($"number of users {nrOfUsers}");
Console.WriteLine($"number of users named Stark {nrOfUsersWithCondition}");

List<int> intList = new List<int>() { 2,4,6,9};
var max = intList.Max();
var sum = intList.Sum();
Console.WriteLine($"max from intList is {max}");
Console.WriteLine($"sum of intList elements is {max}");

List<string> stringList = intList.ConvertAll(x => x.ToString());
var stringAggregation = stringList.Aggregate((s1, s2) => s1+", "+s2);
Console.WriteLine($"string aggregation result {stringAggregation}");

//quantifiers

var containsUser1=users.Contains(user1);
Console.WriteLine($"users containes user1 : {containsUser1}");


var anyDivideBy2=intList.Any(x=>x%2==0);
Console.WriteLine($"does any of the elements divide by 2 : {anyDivideBy2}");


var allDivideBy2 = intList.All(x => x % 2 == 0);
Console.WriteLine($"do all elements divide by 2 : {allDivideBy2}");

bool isEqual = users.SequenceEqual(users1);
Console.WriteLine($"users equals users1: {isEqual}");

//generation methods

var emptySequence = Enumerable.Empty<int>();
var repeatSequence = Enumerable.Repeat(intList, 2).ToList();
Console.WriteLine($"repeated sequence");
foreach (var item in repeatSequence)
{
    Console.Write($"\n");
    foreach (var item2 in item)
    {
        Console.Write($"{item2}");
    }
}  

Console.WriteLine($"\nrange based sequence");
var rangeSequence = Enumerable.Range(0, 10);
Display(rangeSequence);


//zip

List<int> fruitPcs = new List<int>() {4, 2, 3 };
List<string> fruits = new List<string>() {"apples", "bananas", "oranges" };

var zipped = fruitPcs.Zip(fruits);
Display(zipped);


//extension methods
string name = "Artiz2an";
Console.WriteLine($"Extension1: does string contain numeric {name.DoesContainNumeric()}");

Console.WriteLine($"Extension2: every second element of {name}:");
Display(name.EverySecondElement());


var usersPosts = user3.ShowPosts(posts);
Console.WriteLine($"Extension3: show users posts:");
Display(usersPosts);

static void Display<T>(IEnumerable<T> sequence)
{
    foreach (T item in sequence)
    {
        Console.WriteLine(item);
    }

}