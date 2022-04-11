//for (int i;;)// Sonsuz döngü
for(int i=0;;i++)
{
    int a = Convert.ToInt32(Console.ReadLine());
    if (a==i)
        break;//Break ifadesi döngü içerisinden çıkmak istenildiğinde kullanılır
}
//Kod burdan devam eder. 

for (int i = 1; i <= 10; i++)
{
    if (i % 2 == 0)
        continue;//continue sadece mevcut iterasyonu sonlandırır
    Console.WriteLine(i);
}

Console.Read();