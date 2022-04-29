using System.Collections;

Console.WriteLine("20 adet pozitif tamsayı giriniz .. ");


List<int> primeNumberList=new List<int>();
List<int> nonPrimeNumberList=new List<int>();

for(int i=1;i<=20;i++)
{   back:
    Console.Write(i+". sayı : ");
    try
    {   
        int n=Convert.ToInt32(Console.ReadLine());
        
        if (n<0)
        {throw new NegativeNumberNotAllowed("Negative number is not allowed");
        }   
        if (isPrimeNumber(n))
            primeNumberList.Add(n);
        else
            nonPrimeNumberList.Add(n);
    }
    catch(FormatException)
    {
        Console.WriteLine("Not numeric number!! \nPlease enter a positive integer number!! \nRe-try!!!" );
            goto back;
    }
    catch(NegativeNumberNotAllowed)
    {
        goto back;
    }  
}
Console.WriteLine("*********************");
write(primeNumberList,"Asal sayı");
Console.WriteLine("*********************");
write(nonPrimeNumberList,"Asal olmayan sayı");
Console.ReadKey();

static void write(List<int> listName, string name)
{   
    Console.WriteLine(name +"lar dizisinin elemanlarını büyükten küçüğe olacak şekilde ekrana yaz..");
    listName.Sort();
    listName.Reverse();
    listName.ForEach(num=> Console.Write(num+" "));
    if (listName.Count!=0)
    {   
        Console.WriteLine("\nEleman sayısı: "+listName.Count());
        Console.WriteLine("Elemanların ortalaması: "+listName.Sum()/listName.Count());
    }
    else 
    {
        Console.WriteLine("Girdiğiniz sayılar arasında "+ name +" yoktur");
    }
}

static bool isPrimeNumber(int number)
{   if (number == 1 || number == 0)
    {
        return false;
    }
    for(int i=2; i<number; i++)
    {
        if(number%i==0)
            return false;
    } 
    return true;
}

//**********MyException********
class NegativeNumberNotAllowed: Exception
{
public NegativeNumberNotAllowed(string message)
{
    Console.WriteLine("You can not enter negative number ! \nPlease enter a positive integer number!! \nRe-try!!!");
}
}