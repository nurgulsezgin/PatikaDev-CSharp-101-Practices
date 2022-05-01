Console.WriteLine("Çalışan Sayısı: {0}",Employee.EmployeeCount);

//Static olmayan sinif üyesine erişim
Employee emploee1 = new Employee("Ayşe","Yılmaz","IK");
Console.WriteLine("Çalışan Sayısı: {0}",Employee.EmployeeCount);

Employee emploee2 = new Employee("Deniz","Arda","IK");
Employee emploee3 = new Employee("Zikriye","Ürkmez","IK");
Console.WriteLine("Çalışan Sayısı: {0}",Employee.EmployeeCount);


Console.WriteLine("Toplama işlemi sonucu: {0}",Operations.Sum(100,200));
Console.WriteLine("Çıkarma işlemi sonucu: {0}",Operations.Sub(200,100));

Console.ReadKey();
class Employee
{
    private static int employeeCount;

    public static int EmployeeCount { get => employeeCount; set => employeeCount = value; }
    private string Name;
    private string LastName;
    private string Departmant;
    static Employee()//Static Constructor
    {   employeeCount=0;


    }
    public Employee(string name, string lastName, string departmant)
    {
        this.Name = name;
        this.LastName = lastName;
        this.Departmant = departmant;
        employeeCount++;
    }
}
static class Operations
{
    public static long Sum(int num1,int num2)
    {
        return num1+num2;
    }
    public static long Sub(int num1,int num2)
    {
        return num1-num2;
    }
}