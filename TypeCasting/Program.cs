// Implicit Casting (automatically) - converting a smaller type to a larger type size
// char -> int -> long -> float -> double

int myInt = 9;
double myDouble = myInt;       // Automatic casting: int to double

Console.WriteLine(myInt);      // Outputs 9
Console.WriteLine(myDouble);   // Outputs 9

// Explicit Casting (manually) - converting a larger type to a smaller size type
// double -> float -> long -> int -> char

double myDouble2 = 9.78;
int myInt2 = (int) myDouble2;    // Manual casting: double to int

Console.WriteLine(myDouble2);   // Outputs 9.78
Console.WriteLine(myInt2);      // Outputs 9

//Type Conversion Methods

int myInt3 = 10;
double myDouble3 = 5.25;
bool myBool = true;

Console.WriteLine(Convert.ToString(myInt3));         // convert int to string
Console.WriteLine(Convert.ToDouble(myInt3));        // convert int to double
Console.WriteLine(Convert.ToInt32(myDouble3));     // convert double to int
Console.WriteLine(Convert.ToString(myBool));      // convert bool to string

//Parse Methods
string mystring = "10";
string myDateTime = "10.10.2010";
Console.WriteLine(Int16.Parse(mystring)+100+25*4);       // convert string to short
Console.WriteLine(DateTime.Parse(myDateTime));          // convert string to date

Console.Read();
