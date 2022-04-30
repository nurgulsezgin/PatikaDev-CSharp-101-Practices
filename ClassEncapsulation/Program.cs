Student student1=new Student();
student1.Name="Ayşe";
student1.LastName="Yılmaz";
student1.StudentNo=221;
student1.Grade=3;

student1.getStudentInformatin();

student1.passGrade();
student1.getStudentInformatin();

Student student2=new Student("Deniz","Arda",132,1);

student2.getStudentInformatin();

student2.downGrade();
student2.getStudentInformatin();


Console.WriteLine("\nPlease touch a key to close it..");
Console.ReadKey();

class Student
{
    private string name;
    private string lastName;
    private int studentNo;
    private int grade;

    public string Name 
    { 
        get { return name; } 
        set { name = value;}
    }
    public string LastName { get => lastName; set => lastName = value; }
    public int StudentNo { get => studentNo; set => studentNo = value; }
    public int Grade 
    { 
        get => grade; 
        set 
        {
            if(value<1)
            {
                Console.WriteLine("Sınıf en küçük 1 olabilir..");
                grade=1;
            }
            else
            {
                grade=value;
            }
        }
    }

    public Student(string name, string lastName, int studentNo, int grade)
    {
        Name = name;
        LastName = lastName;
        StudentNo = studentNo;
        Grade = grade;
    }

    public Student(){}

    public void getStudentInformatin()
    {
        Console.WriteLine("\nÖğrenci adı:    {0}",this.Name);
        Console.WriteLine("Öğrenci soyadı: {0}",this.LastName);
        Console.WriteLine("Öğrenci nosu:   {0}",this.StudentNo);
        Console.WriteLine("Öğrenci sınıfı: {0}",this.Grade);
    }
    public void passGrade()
    {
        this.Grade=this.Grade+1;
    }
    public void downGrade()
    {
        this.Grade=this.Grade-1;

    }
}