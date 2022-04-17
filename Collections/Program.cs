using System.Collections.Generic;

//List<T> class
//System.Collection.Generic
//T -> obect  türündedir

List<int> nums=new List<int>();

nums.Add(1);
nums.Add(2);
nums.Add(3);
nums.Add(4);

List<string> colors=new List<string>();

colors.Add("pink");
colors.Add("orange");
colors.Add("green");
colors.Add("grey");
colors.Add("purple");
colors.Add("red");

//count

Console.WriteLine("Count of numbers list : "+nums.Count);
Console.WriteLine("Count of colors list : "+colors.Count);

Console.WriteLine("Number List : ");
foreach(var num in nums)
    Console.Write(num+", ");
Console.Write("\n");

Console.WriteLine("Color List : ");
foreach(var color in colors)
    Console.Write(color+", ");
Console.Write("\n");

//remove element of list

nums.Remove(4);
colors.Remove("pink");

nums.RemoveAt(0);
colors.RemoveAt(2);

nums.ForEach(num=> Console.WriteLine(num));
colors.ForEach(color=> Console.WriteLine(color));

//searching 
if(nums.Contains(10))
    Console.WriteLine("List contains 10!");
else
    Console.WriteLine("List does not contain 10!");

if(colors.Contains("red"))
    Console.WriteLine("List contains red!");

//Searching by index number --Check the list indexing number for part 
Console.WriteLine(colors.BinarySearch("red"));
Console.WriteLine(nums.BinarySearch(3));

//Convert array to list
string[] animals={"cat","dog","bird","fox","elephant"};
List<string> listAnimals=new List<string>(animals);
listAnimals.ForEach(animal=> Console.WriteLine(animal));

//clear all element of list
listAnimals.Clear();

//
List<Users> userList=new List<Users>();

Users user1=new Users();
user1.Name="Nurgul";
user1.LastName="Sezgin";
user1.Age=26;

Users user2=new Users();
user2.Name="Rosalie";
user2.LastName="Alpha";
user2.Age=4;

userList.Add(user1);
userList.Add(user2);

List<Users> newList=new List<Users>();

newList.Add(new Users(){
    Name="Çigdem",
    LastName="Usta",
    Age=26
});

foreach(Users user in userList)
{
    Console.WriteLine("Username : "+user.Name);
    Console.WriteLine("Surname : "+user.LastName);
    Console.WriteLine("Age : "+user.Age);
}

Console.WriteLine(newList[0].Name);
Console.WriteLine(newList[0].LastName);
Console.WriteLine(newList[0].Age);

//Stopping console
Console.ReadKey();

//Encapsulation
public class Users{
    string name;
    string lastName;
    int age;

//ctrl + .   --Extract fiel-Encapsulate field
    public string Name { get => name; set => name = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public int Age { get => age; set => age = value; }
}




