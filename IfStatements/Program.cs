//int time = DateTime.Now.Hour;
int time = 22;
if (time>= 5 && time<= 12) 
{
  Console.WriteLine("Good morning.");
} 
else if (time> 12 && time<= 16) 
{
  Console.WriteLine("Good afternoon.");
}
else if (time> 16 && time<= 20) 
{
  Console.WriteLine("Good evening.");
} 
else // when the sun goes down
{
  Console.WriteLine("Good nights.");
}

//Ternary Operator(Short Hand If...Else)
int time2 = 10;
string result = (time2 < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);
Console.Read();