try //{ Hataya sebebiyet verme ihtimali olan kod }
{
    int a = int.Parse(Console.ReadLine());

    int b = int.Parse(Console.ReadLine());

    int c = a+b;

    Console.WriteLine(c);
}
catch(Exception ex)//{ Hata ile karşılaşıldığında ne yapılacağı buraya yazılır }
{
    Console.WriteLine("Bir Hata Oluştu: "+ "Hata:" + ex.Message.ToString());
}
finally//{ Hata olsun olmasın mutlaka yapılmasını istediğimiz işler varsa buraya yazarız. }
{
    Console.WriteLine("İşlem tamamlandı.");
}


try
{
   // int a=int.Parse(null);
    int b=int.Parse("null");
   // int c=int.Parse("-200000000000");
}
catch(ArgumentNullException ex)
{
    Console.WriteLine(ex);
    Console.WriteLine("Boş bir değer girdiniz");
}
catch  (FormatException ex)
{
    Console.WriteLine(ex);
    Console.WriteLine("Veri tipi uygun degil");
}
catch (OverflowException ex)
{
    Console.WriteLine(ex);
    Console.WriteLine("Çok küçük yada çok büyük bir değer girdiniz");
}
Console.ReadLine();