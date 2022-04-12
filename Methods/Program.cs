using MethodOverload;
//Metot Aşırı Yükleme - Overloading
Metotlar.EkranaYazdir(11);
Metotlar.Topla(2, 2, out int toplam);
Metotlar.EkranaYazdir(Convert.ToString(toplam));
Metotlar.EkranaYazdir("Nurgül ", "Sezgin");

//
int a=2;
int b=3;
Console.WriteLine(a+b);
int sum=Sum(a,b);
Console.WriteLine(sum);
//Create a static method
static int Sum(int value1, int value2)
{
    return value1+value2;
}

StaticMethods.Hello();
int result=StaticMethods.SumPlus(ref a, ref b);

MyMethods ex=new MyMethods();//static olmadığında newlemek gereklidir.
ex.WriteConsole(Convert.ToString(sum));

class StaticMethods//Create a static method in a class
{
    public static void Hello()
    {
        Console.WriteLine("Hello World");
    }
    public static int SumPlus(ref int value1,ref int value2)//Referan;Fonksiyon içerisinde parametre üzerinde değişiklik yapıldığında ana değişken değişmez. Sadece kopyası üzerinde değişiklik yapılmış olur. Fonksiyon sonlandığındaysa bellekten silinir. Yani yaşam süresi sona erer.
    {
        value1+=1;
        value2+=2;
        return value1+value2;
    }
}
class MyMethods
{
    public void WriteConsole(string text)//public:Methodumuza her yerden ulaşmamızı sağlar.Yazmasak default private. Yani sadece oluştuğu claassın içinden erişilebilir oluyor.
    {
        Console.WriteLine(text);
        Console.Read();
    }
}


