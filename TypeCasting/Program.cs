// Implicit Casting (automatically) - converting a smaller type to a larger type size
// char -> int -> long -> float -> double

int myInt = 9;
double myDouble = myInt;       // Automatic casting: int to double

Console.WriteLine(myInt);      // Outputs 9
Console.WriteLine(myDouble);   // Outputs 9

// Explicit Casting (manually) - converting a larger type to a smaller size type
// double -> float -> long -> int -> char

double myDouble = 9.78;
int myInt = (int) myDouble;    // Manual casting: double to int

Console.WriteLine(myDouble);   // Outputs 9.78
Console.WriteLine(myInt);      // Outputs 9

//Type Conversion Methods

int myInt = 10;
double myDouble = 5.25;
bool myBool = true;

Console.WriteLine(Convert.ToString(myInt));    // convert int to string
Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

//Parse Methods
string mystring = "10";
string myDateTime = "10.10.2010";
Console.WriteLine(Int1.Parse(myString));   // convert bool to string 
Console.WriteLine(DateTime.Parse(myDateTime)); 
