//Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
using System.Collections;
double[] listNumber=new double[10];
//ArrayList list=new ArrayList();
Console.WriteLine("20 adet sayı giriniz .. \n");
for(int i=1;i<=listNumber.Length;i++)
{
    Console.Write(i+". sayı :");
    double n=Convert.ToDouble(Console.ReadLine());
    listNumber[i-1]=n;
}
Array.Sort(listNumber);//Listeyi küçükten büyüğe sırala

double[] min=new double[3];
min[0]=listNumber[0];
min[1]=listNumber[1];
min[2]=listNumber[2];

double[] max=new double[3];
max[0]=listNumber[7];
max[1]=listNumber[8];
max[2]=listNumber[9];

Console.Write("\nEn küçük üç elemanı: ");
double x=myMethod(min);
Console.Write("\nEn büyük üç elemanı: ");
double y=myMethod(max);

double sumAll=x+y;
Console.WriteLine("\nOrtalamaların toplamları: "+sumAll);

Console.ReadKey();

static double myMethod(double [] listName)
{   foreach(var num in listName)
        Console.Write(num+" ");
    double sum=listName.Sum();
    Console.WriteLine("\nToplam: "+sum+"   Ortalaması: "+ sum/3);
    return sum;
}