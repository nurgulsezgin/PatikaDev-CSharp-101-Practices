using System.Collections;
using System.Collections.Generic;

//using sytem.collection

ArrayList list=new ArrayList();

// list.Add("Nurgül");//string
// list.Add(12);//int
// list.Add(true);//boolean
// list.Add(0.5);//double
// list.Add('A');//char

// //Access in element
// Console.WriteLine(list[0]);

// foreach(var item in list)
//     Console.WriteLine(item);

//SomeMethods

//AddRange
Console.WriteLine("********** AddRange *********");
// string[] colors={"red","pink","yellow","green","blue","black","white"};
List<int> nums=new List<int>(){1,2,3,4,5,6,100,99,98,97,96,95};
//list.AddRange(colors);
list.AddRange(nums);
foreach(var item in list)
    Console.WriteLine(item);

//Sort
Console.WriteLine("********** Sort *********");
list.Sort(); //Compile time da hata verir Tipleri farklı olunca karşılaştırma yapamaz
foreach(var item in list)
    Console.WriteLine(item);

//Binary Search
Console.WriteLine("********** Binary Search *********");
Console.WriteLine(list.BinarySearch(9));

//Reverse
Console.WriteLine("********** Reverse *********");
list.Reverse();//Mirror
foreach(var item in list)
    Console.WriteLine(item);

//Clear
Console.WriteLine("********** Clear *********");
list.Clear();
foreach(var item in list)
    Console.WriteLine(item);

Console.ReadKey();