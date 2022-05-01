// See https://aka.ms/new-console-template for more information
Console.WriteLine(Days.Monday);
Console.WriteLine((int)Days.Monday);//Cast dönüşüm ile indexine erişebiliriz.

int tempature=32;
if(tempature<=(int)Wheather.Cold)
{
    Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim");
}
else if(tempature<=(int)Wheather.Sweltering)
{
    Console.WriteLine("Dışarıya çıkmak için havan aşırı sıcak");
}
else if(tempature>=(int)Wheather.Cool && tempature<=(int)Wheather.Hot)
{
    Console.WriteLine("Hadi dışarı çıkalım");
}
enum Days
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday,

}
enum Wheather
{   
    Freezing=-20,
    Cold=5,
    Cool=15,
    Warm=20,
    Hot=30,
    Sweltering=40,

}