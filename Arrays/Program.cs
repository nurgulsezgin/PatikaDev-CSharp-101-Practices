﻿using System.Linq;
//Create an Array

string[] colors=new string[4];// Create an array of four elements, and add values later

string[] animals = {"Bird", "Cat", "Dog", "Mouse"};//Omitting the new keyword, and without specifying the size

string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

string[] carLists = new string[] {"Volvo", "BMW", "Ford", "Mazda"};//without specifying the size

int[] myNum;
myNum=new int[5];

//Change an Array Element
colors[0]="Yellow";
colors[1]="Pink";
colors[2]="Purple";
colors[3]="Blue";

//Access the Elements of an Array
Console.WriteLine(colors);
Console.WriteLine(cars[0]);
//Array Length
Console.WriteLine(colors.Length);

//Loop Through an Array
for (int i = 0; i < animals.Length; i++) 
{
  Console.WriteLine(animals[i]);
}
//The foreach Loop and Sort Arrays
int[] myNumbers = {5, 1, 8, 9};
Array.Sort(myNumbers);
foreach (int i in myNumbers)
{
  Console.WriteLine(i);
}

//System.Linq Namespace
Console.WriteLine(myNumbers.Sum());  // returns the sum of values

double sum = myNumbers.Sum();
double ortalama = sum / myNumbers.Length;
Console.WriteLine("Sayıların ortalaması: " + ortalama);
