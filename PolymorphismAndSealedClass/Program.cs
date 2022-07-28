class Program  //Polymorphism:Çok biçimlilik
{
    public class Base  
    {  
        public virtual void Show()  
        {  
            Console.WriteLine("Show From Base Class.");  
        }  
    }  
    public class Derived : Base  
    {  
        //the keyword "override" change the base class method.  
        public override void Show()  
        {  
            Console.WriteLine("Show From Derived Class.");  
        }  
    }  
    static void Main(string[] args)  
    {  
        Base objBaseRefToDerived  = new Derived();  
        objBaseRefToDerived .Show();//Output--> Show From Derived Class.  
        Console.ReadLine();  
    } 
}