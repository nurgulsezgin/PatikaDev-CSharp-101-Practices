int x=2;
int y=3;


Console.WriteLine(x += y);
Console.WriteLine(x *=2);
Console.WriteLine(x /=6);
Console.WriteLine(x -= x);
x++;
Console.WriteLine(x);
y--;
Console.WriteLine(y);

if(x==1 || y==2)
{
    Console.WriteLine("x=1 veya y=2 dir.");
}
if(x==1 && y==2)
{
    Console.WriteLine("x=1 ve y=2 dir.");
}
if(x!=y)
{
    Console.WriteLine("x y ye eşit degildir..");
}
Console.Read();

