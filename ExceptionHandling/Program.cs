try //{ Hataya sebebiyet verme ihtimali olan kod }
{
    int a = int.Parse(Console.ReadLine());

    int b = int.Parse(Console.ReadLine());

    int c = a+b;

    Console.WriteLine(c);
}
catch(Exception ex)//{ Hata ile karşılaşıldığında ne yapılacağı buraya yazılır }
{
    Console.WriteLine("Bir Hata Oluştu: "+ ex.Message.ToString());
}
finally//{ Hata olsun olmasın mutlaka yapılmasını istediğimiz işler varsa buraya yazarız }
{
    Console.WriteLine("İşlem tamamlandı.");
}