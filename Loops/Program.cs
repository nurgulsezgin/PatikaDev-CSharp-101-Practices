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


int sayac = 1;
while (sayac <= 5)//Koşullar sağlandıkça komut satırlarının çalıştırılmasını sağlar
{
    Console.WriteLine(sayac);
    sayac++;
}


int[] sayiDizisi = {2,4,5,1,2,4};
int toplam = 0 ;

foreach(int i in sayiDizisi)//diziler ve koleksiyonlarla döngüsel işlemler yapmak için kullanılır
{
    toplam += i ;
    Console.WriteLine(i+"+Toplam = "+ toplam);
}

Console.Read();