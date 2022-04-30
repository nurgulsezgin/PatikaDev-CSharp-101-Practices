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

Employee employee1=new Employee("Ayşe","Kara",1000132,"İnsan Kaynakları");

employee1.employeeInformation();

Employee employee2=new Employee();
employee2.Name="Deniz";
employee2.LastName="Arda";
employee2.EmployeeNo=1000456;
employee2.Departmant="Satın Alma";

employee2.employeeInformation();

Employee employee3=new Employee("Zikriye","Ürkmez");

employee3.employeeInformation();

Console.WriteLine("\nPlease touch a key to close it..");
Console.ReadKey();

class Employee
{
    public string Name;
    public string LastName;
    public int EmployeeNo;
    public string Departmant;

    public Employee(string name, string lastName, int employeeNo, string departmant)//Constructor Method
    {
        this.Name=name;
        this.LastName=lastName;
        this.EmployeeNo=employeeNo;
        this.Departmant=departmant;
    }
    public Employee(string name, string lastName)//Method Overloading
    {
        this.Name=name;
        this.LastName=lastName;
    }
    public Employee(){}

    public void employeeInformation()
    {
        Console.WriteLine("\nÇalışanın adı: {0}", Name);
        Console.WriteLine("Çalışanın soyadı: {0}", LastName);
        Console.WriteLine("Çalışanın numarası: {0}", EmployeeNo);
        Console.WriteLine("Çalışanın departmanı: {0}", Departmant);
    }
}

