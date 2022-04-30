
Console.WriteLine("Bir cümle giriniz..");
string text = Console.ReadLine();

findAllVowel(text);

Console.WriteLine("\n\n\nPlease touch a key to close it.");
Console.ReadKey();

static void findAllVowel(string text)
{
    char [] letters = new char[text.Length];
    List<char> vowels = new List<char>(){'a','e','ı','i','o','ö','u','ü','A','E','I','İ','O','Ö','U','Ü'};
    for(int i=0;i<text.Length;i++)
        if(vowels.Contains(text[i]))
            Console.Write(text[i]+", ");
    
}
