using FindPetOwner;
using System.Collections.Generic;

NonGroupMember user1 = new NonGroupMember(5,"Jaime", "Lannister");
NonGroupMember user2 = new NonGroupMember(6,"Arya", "Stark");
NonGroupMember user3 = new NonGroupMember(7,"Theon", "Greyjoy");

GroupMember user4 = new GroupMember(1,"Ana", "Danciu");
GroupMember user5 = new GroupMember(2,"Carmen", "Amariei");
GroupMember user6 = new GroupMember(3,"Ana", "Coroiu");
GroupMember user7 = new GroupMember(4,"Gheorghina", "Ariel");

TimeOnly[] liber = { new TimeOnly(10, 0), new TimeOnly(11, 0) };
double[] gpsLocation = {1145.456, 111457,80 };

Post post1 = new Post(new int[]{ 1, 2 },"telefon1","adresa1",liber,"comentariu post1", gpsLocation,1 );
Post post2 = new Post(new int[]{ 1, 2 },"telefon2","adresa2",liber,"comentariu post 2", gpsLocation,2 );
Post post3 = new Post(new int[]{ 1, 2 },"telefon3","adresa3",liber,"comentariu post3", gpsLocation,7 );
Post post4 = new Post(new int[]{ 1, 2 },"telefon3","adresa3",liber,"comentariu post 4", gpsLocation,7 );

//Console.Write($"{ post1.Phone}, {post1.Address}, {string.Join(" ",post1.Availability)}, {post1.Comment}, {post1.status}\n");


List<User> users = new List<User>() { user1, user2, user3, user4, user5, user6, user7 };
List<User> users1 = new List<User>() { user1, user2, user3, user4, user5, user6, user7 };
List<Post> posts = new List<Post>() { post3, post2, post1,post4 };

HashSet<User> userSet1 = new HashSet<User>() { user1, user2, user3 };
HashSet<User> userSet2= new HashSet<User>() { user1, user2, user4};


//filtering operators

var groupMember = users.Where(user => user is GroupMember);

Console.WriteLine("\nonly group members");
Display(groupMember);

var first2 = users.Take(2);
Console.WriteLine("\nfirst 2 users");
Display(first2);

var last2 = users.TakeLast(2);
Console.WriteLine("\nlast 2 users");
Display(last2);


var exceptFirst2 = users.Skip(2);
Console.WriteLine("\nall except first 2 users");
Display(exceptFirst2);


var userAna = users.SkipWhile(user => user.Surname is "Ana");
Console.WriteLine("\n skip while surname Ana");
Display(userAna);

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
var groupByuser = posts.GroupBy(x => x.User_id);
Console.WriteLine("\ngroup post by user");
foreach(var group in groupByuser) 
{foreach (var item in group) 
    { Console.WriteLine(item.User_id); }
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
Console.WriteLine($"\nusers sequence type {users.GetType().Name}");
Console.WriteLine($"\ntoQueryTable sequence type {toQueryTable.GetType().Name}");

//element operators

var firstSName = users.FirstOrDefault(x=>x.Name.StartsWith('S'),user6);
Console.WriteLine($"\nfirst name that starts with S. If none meet condition, returns user 6 {firstSName}");

/*throws exception because of multiple results
 
var singleAName = users.Single(x => x.Name.StartsWith('A'));
Console.WriteLine(singleAName);*/


var secondElement = users.ElementAt(1);
Console.WriteLine($"\nsecond element {secondElement}");


//aggregation methods

var nrOfUsers=users.Count();
var nrOfUsersWithCondition=users.LongCount(x=>x.Name=="Stark");
Console.WriteLine($"\nnumber of users {nrOfUsers}");
Console.WriteLine($"\nnumber of users named Stark {nrOfUsersWithCondition}");

List<int> intList = new List<int>() { 2,4,6,9};
var max = intList.Max();
var sum = intList.Sum();
Console.WriteLine($"\nmax from intList is {max}");
Console.WriteLine($"\nsum of intList elements is {max}");

List<string> stringList = intList.ConvertAll(x => x.ToString());
var stringAggregation = stringList.Aggregate((s1, s2) => s1+", "+s2);
Console.WriteLine($"\nstring aggregation result {stringAggregation}");

//quantifiers

var containsUser1=users.Contains(user1);
Console.WriteLine($"\nusers containes user1 : {containsUser1}");


var anyDivideBy2=intList.Any(x=>x%2==0);
Console.WriteLine($"\ndoes any of the elements divide by 2 : {anyDivideBy2}");


var allDivideBy2 = intList.All(x => x % 2 == 0);
Console.WriteLine($"\ndo all elements divide by 2 : {allDivideBy2}");

bool isEqual = users.SequenceEqual(users1);
Console.WriteLine($"\nusers equals users1: {isEqual}");

//generation methods

var emptySequence = Enumerable.Empty<int>();
var repeatSequence = Enumerable.Repeat(intList, 2).ToList();
Console.WriteLine($"\nrepeated sequence");
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
Console.WriteLine($"\nzipped lists");
Display(zipped);


//extension methods
string name = "Artiz2an";
Console.WriteLine($"\nExtension1: does string contain numeric {name.DoesContainNumeric()}");

Console.WriteLine($"\nExtension2: every second element of {name}:");
Display(name.EverySecondElement());


var usersPosts = user3.ShowPosts(posts);
Console.WriteLine($"\nExtension3: show users posts:");
Display(usersPosts);


//query sintax
Console.WriteLine($"\ninner join with query sintax");
var innerJoinQuery = from user in users 
                     join post in posts
                     on user.Id equals post.User_id 
                     select new {User = user.Id, Posted_by=post.User_id, Post_comment=post.Comment};
Display(innerJoinQuery);


//method syntax
Console.WriteLine($"\ninner join with method sintax");
var innerJoinMethod = users.Join(posts, 
                    user => user.Id, post => post.User_id,
                    (user, post) => new { User = user.Id, Posted_by = post.User_id, Post_comment = post.Comment});
Display(innerJoinMethod);


//query sintax
Console.WriteLine($"\nleft join with query sintax, ordered by user id");
var leftJoinQuery = from user in users
                    join post in posts on user.Id equals post.User_id
                    into UsersWithPosts
                    from subpost in UsersWithPosts.DefaultIfEmpty()
                    orderby user.Id
                    select new { User = user.Id, Post_comment = subpost?.Comment?? String.Empty }; 
Display(leftJoinQuery);


//method syntax
Console.WriteLine($"\nleft join with method sintax, ordered by user id");
var leftJoinMethod = users.GroupJoin(posts,
                    user => user.Id, post => post.User_id,
                    (user, post) => new { user, post})
                    .SelectMany(x=>x.post.DefaultIfEmpty(),(subuser,subpost)=>new { User = subuser.user.Id, Post_comment = subpost?.Comment ?? String.Empty }).OrderBy(x=>x.User);
Display(leftJoinMethod);

var concerteElvis = from concert in Exercitiu.GetConcerts().Where(x=>x.Country=="Germany"&&(x.Year>1950||x.Year<1980))
                    join singer in Exercitiu.GetSingers().Where(x => x.FirstName == "Elvis") on concert.SingerId equals singer.Id
                    select new { Locatie = concert.Avenue};

Display(concerteElvis);



static void Display<T>(IEnumerable<T> sequence)
{
    foreach (T item in sequence)
    {
        Console.WriteLine(item);
    }

}

public class Exercitiu
{
    private IEnumerable<Singer> _singers; private IEnumerable<Concert> _concerts; public Exercitiu() { _singers = GetSingers(); _concerts = GetConcerts(); }
    public static IEnumerable<Singer> GetSingers() 
    { return new List<Singer>() { new Singer { Id = 1, FirstName = "Freddie", LastName = "Mercury" }, 
        new Singer { Id = 2, FirstName = "Elvis", LastName = "Presley" }, 
        new Singer { Id = 3, FirstName = "Chuck", LastName = "Berry" }, 
        new Singer { Id = 4, FirstName = "Ray", LastName = "Charles" }, 
        new Singer { Id = 5, FirstName = "David", LastName = "Bowie" } }; }
    public static IEnumerable<Concert> GetConcerts()
    {
        return new List<Concert>()
        {new Concert { SingerId = 2, Country = "Germany", Avenue = "Alianz", Year = 1979},
            new Concert { SingerId = 1, Country = "USA", Avenue = "NYW", Year = 1980},
            new Concert { SingerId = 1, Country = "Germany", Avenue = "Opera Nazional", Year = 1981},
            new Concert { SingerId = 2, Country = "Germany", Avenue = "Berlin Arena", Year = 1970},
            new Concert { SingerId = 2, Country = "Rusia", Avenue = "Lujniki", Year = 1968},
            new Concert { SingerId = 3, Country = "UK", Avenue = "London Opera", Year = 1960},
            new Concert { SingerId = 3, Country = "USA", Avenue = "Central Park", Year = 1961},
            new Concert { SingerId = 2, Country = "Rusia", Avenue = "Red Square", Year = 1962},
            new Concert { SingerId = 4, Country = "USA", Avenue = "Capitolium", Year = 1950},
            new Concert { SingerId = 4, Country = "Romania", Avenue = "Arena nationala", Year = 1951},
            new Concert { SingerId = 5, Country = "France", Avenue = "Verdun", Year = 1983}
};
    }
}
public class Singer { public int Id { get; set; } public string FirstName { get; set; } public string LastName { get; set; } }
public class Concert { public int SingerId { get; set; } public string Avenue { get; set; } public int Year { get; set; } public string Country { get; set; } }



















