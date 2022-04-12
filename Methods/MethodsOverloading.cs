namespace MethodOverload
{
    static class Metotlar
    {
        public static void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public static void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public static void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public static void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}
