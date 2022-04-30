//Söz dizimi 
// class SınıfAdı
// {
//     [Erişim belirleyici] [Veri Tipi] ÖzellikAdı;
//     [Erişim belirleyici] [Geri Dönüş Tipi] metotAdı([Parametre Listesi])
//     {
//         Metot Komutları
//     }

// }

//Erişim Belirleyiciler
//*Public : Her yerden erişilebilir.
//*Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.
//*Internal : Sadece bulunduğu proje içerisinden erişilebilir
//*Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.

Employee employee1=new Employee();
employee1.name="Ayşe";
employee1.lastName="Kara";
employee1.employeeNo=1000132;
employee1.departmant="İnsan Kaynakları";

employee1.employeeInformation();

Employee employee2=new Employee();
employee2.name="Deniz";
employee2.lastName="Arda";
employee2.employeeNo=1000456;
employee2.departmant="Satın Alma";

employee2.employeeInformation();

Console.WriteLine("\nPlease touch a key to close it..");
Console.ReadKey();

class Employee
{
    public string name;
    public string lastName;
    public int employeeNo;
    public string departmant;

    public void employeeInformation()
    {
        Console.WriteLine("\nÇalışanın adı: {0}", name);
        Console.WriteLine("Çalışanın soyadı: {0}", lastName);
        Console.WriteLine("Çalışanın numarası: {0}", employeeNo);
        Console.WriteLine("Çalışanın departmanı: {0}", departmant);
    }
}