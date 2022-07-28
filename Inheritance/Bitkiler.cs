public class Bitkiler: Canlilar{
    public void FotosentezYapmak(){
        Console.WriteLine("Bitkiler fotosentez yapar."); 
    }
}

public class TohumluBitkiler:Bitkiler{
    public void TohumlaCogalma(){
        Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
    }
}

public class TohumsuzBitkiler:Bitkiler{
    public void SporlaCogalma(){
        Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
    }
}