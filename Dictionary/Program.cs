using System;
using System.Collections.Generic;

Dictionary<int, string> users = new Dictionary<int, string>();
//Key must be unique
users.Add(10,"Ayşe yılmaz");
users.Add(12,"Ahmet yılmaz");
users.Add(18,"Deniz arda");
users.Add(20,"Özcan coşar");

//Dizinin elemanlarına erişim
Console.WriteLine("****Elemanlar erişim****");
Console.WriteLine(users[12]);
foreach(var item in users)
    Console.WriteLine(item);

//Count
Console.WriteLine("Count: "+users.Count);

//Contains
Console.WriteLine(users.ContainsKey(12));
Console.WriteLine(users.ContainsValue("Ayşe yılmaz"));

//Remove
Console.WriteLine("*****Remove******");
users.Remove(12);
foreach(var item in users)
    Console.WriteLine(item.Value);

//Keys
Console.WriteLine("*****Keys******");
foreach(var item in users.Keys)
    Console.WriteLine(item);

//Values
Console.WriteLine("*****Values******");
foreach(var item in users.Values)
    Console.WriteLine(item);

Console.ReadKey();

