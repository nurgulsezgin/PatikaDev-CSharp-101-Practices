
public static class ExtensionMethods
{
    public static void WriteEventNumber(int[] numberList)
    {   Console.Write("Çift sayılar : ");
        foreach (int number in numberList)
        {
            if(number%2==0)
            {Console.Write(number+" ");}
            else 
                continue;
        }
    }
    public static void EqualOrDivisor(int[] numberList,int m)
    {   Console.Write(m+" Tam bölenleri ; ");
        foreach (int number in numberList)
        {
            if(m%number==0)
            {Console.Write(number+" ");}
            else 
                continue;
        }
    }
    public static int[] ReadNumber(int n)
    {
        int[] numbers=new int[n];
        for(int i=1;i<=n;i++)
        {
            //int i=Int32.Parse(num);
            Console.Write(i+". sayı=");
            numbers[i-1]=int.Parse(Console.ReadLine());
        }
        return numbers;
    }
    public static string[] ReadWords(int n)
    {
        string[] words=new string[n];
        for(int i=1;i<=n;i++)
        {
            //int i=Int32.Parse(num);
            Console.Write(i+". kelime=");
            words[i-1]=Console.ReadLine();
        }
        return words;
    }
    public static string WordList(string[] words)
    {   int countWords=0;
        int countLetters=0;
        foreach(string word in words)
        {   if (word=="")
                continue;
            countWords++;
            for(int i=1;i<=word.Length;i++)
            {countLetters++;}
            
        }
        return "Toplam Kelime Sayısı:"+countWords+"Toplam Kelime Sayısı:"+countLetters;
    }
}

    