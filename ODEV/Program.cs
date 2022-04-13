// 1. Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

Console.Write("Bir pozitif tam sayı giriniz : ");
int n= int.Parse(Console.ReadLine());
int[] numbers =ExtensionMethods.ReadNumber(n);
ExtensionMethods.WriteEventNumber(numbers);
Console.ReadKey();

//2. Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

// Console.Write("n : ");
// int n= int.Parse(Console.ReadLine());
// Console.Write("m : ");
// int m= int.Parse(Console.ReadLine());
// int[] numbers =ExtensionMethods.ReadNumber(n);
// ExtensionMethods.EqualOrDivisor(numbers,m);
// Console.ReadKey();

//3. Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

// Console.Write("n : ");
// int n= int.Parse(Console.ReadLine());
// string[] words =ExtensionMethods.ReadWords(n);
// for(int i=0;i<n;i++)
// {Console.Write(words[n-i-1]+" ");}
// Console.ReadKey();

//4.Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

// Console.Write("Bir cümle yazınız : ");
// string[] words=Console.ReadLine().Split(" ");
// Console.WriteLine(ExtensionMethods.WordList(words));
// Console.ReadKey();

