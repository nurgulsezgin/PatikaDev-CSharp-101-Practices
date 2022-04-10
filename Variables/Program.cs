//DataType variableName = value;  //Size and Description

byte b = 1;              //1byte: unsigned integer :0 to 255
sbyte sb = 0;           // 1byte: signed integer   :-128 to 127

//Numbers
short s = 2;                      //2 bytes:(System.Int16)  :from -32768 to 32767
int myNum = 5;	                 //4 bytes:(System.Int32)   :from -2,147,483,648 to 2,147,483,647
long myLongNum = 15000000000L;  //8 bytes:(System.Int64)	:from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

Int16 i16 = 1;
Int32 i32 = 1;
Int64 i64 = 1; 

float myFloatNum = 5.75F;         //4 bytes:	Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
double myDoubleNum = 5.99D;	     //8 bytes:     Stores fractional numbers. Sufficient for storing 15 decimal digits
decimal myDecimalNum  =10m;     //16 bytes	

//Scientific Numbers

float f1 = 35e3F;
double d1 = 12E4D;

//Texts

bool myBool = true;	              //1 bit	Stores true or false values
char myLetter = 'D';	         //2 bytes	Stores a single character or letter, surrounded by single quotes
string myText = "Hello";	    //2 bytes per character

object o1 = 'D';
object o2 = "Hello";
object o3 = 10;
object o4 = 10.5;

string dateTime = DateTime.Today.ToString();
string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
string dateTime3 = DateTime.Now.ToString("dd.MM.yyyy");
string hour = DateTime.Now.ToString("HH:mm");

short numb = Convert.ToInt16(Console.Read());    //Convert Whatever to short 
short numb2 = Int16.Parse("10");                //Convert string to short
