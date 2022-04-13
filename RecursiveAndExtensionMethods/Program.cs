//Recursive Function:Öz yinelemeli fonksiyon  
static void FibonacciDizisi(int num)
{
    for(int i = 0; i < num; i++)
        Console.Write(FibonacciNums(i)+" ");
    Console.WriteLine(" ");
    

    int FibonacciNums(int num)
    {      
        if(num==1)
        {   return num;
            
        }
        if(num==0)
        {   return num;
        }
        return FibonacciNums(num-1)+FibonacciNums(num-2);
        
    }
}

FibonacciDizisi(10);//0,1,1,2,3,5,7,12   Dizinin ilk 10 elemanı

//
int Exponential(int baseNumber, int power) 
{
    if(power!=1)
        return Exponential(baseNumber,power-1)*baseNumber;
    return baseNumber;
}
Console.WriteLine(Exponential(3,2));//3^2=9

//
int Factorial(int num)
{
    if(num == 0) return 1; else return num * Factorial(num - 1);
}
Console.WriteLine(Factorial(4));//4!=4.3.2.1=24


//Extension Function :genişletilebilir metotlar
int myValue = 17;
bool isEven = myValue.IsEventNumber();
if(isEven)
{Console.WriteLine("This is even number(Çift sayıdır.)");}
else
{Console.WriteLine("This is odd number(Tek sayıdır.)");}
if(myValue.IsPrimeNumber())
{Console.WriteLine(myValue+", bir asal sayıdır");}
else 
{Console.WriteLine(myValue+", bir asal sayı değildir.");}
Console.WriteLine("Nurgül Sezgin".RemoveWhiteSpaces());
Console.WriteLine("Please click any button to close terminal.");
Console.ReadKey();
public static class MyExtensionClass
{
    public static bool IsEventNumber(this int value)//Çiftmi?Tekmi?
    {
        if(value%2==0)
            return true;
        else
            return false;
    }
    
    public static bool IsPrimeNumber(this int value)//Asal Sayımı?Degilmi?
    {
        for (int i = 2; i < value; i++)     
        {
            if(value%i==0)
            {
                return false;
            }
        }
        return true;
    }

    public static string RemoveWhiteSpaces(this string text) 
    {
        string[] array=text.Split(" ");
        return string.Join("",array);
    }
}





