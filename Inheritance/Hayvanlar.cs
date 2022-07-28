public class Hayvanlar: Canlilar{
    public void SuruHalindeHareket(){
        Console.WriteLine("Hayvanlar sürüler halinde hareket eder."); 
    }
}

public class Kus:Hayvanlar{
    public void Ucmak(){
        Console.WriteLine("Kuşlar uçar");
    }
}
