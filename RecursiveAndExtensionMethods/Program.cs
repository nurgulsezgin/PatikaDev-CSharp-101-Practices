//Recursive Function:Öz yinelemeli fonksiyon 
static int FibonacciNums(int num)
{   if(num>0)
        return FibonacciNums(num-1);
    else
        return 2;
}
Console.WriteLine(FibonacciNums(5));//İlk 5 sayı

static int Exponential(int baseNumber, int power) 
{
    if(power!=1)
        return Exponential(baseNumber,power-1)*baseNumber;
    return baseNumber;
}
Console.WriteLine(Exponential(3,2));//İlk 5 sayı
Console.Read();





//Extension 