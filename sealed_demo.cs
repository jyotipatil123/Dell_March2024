////////// sealed class in c#  -- stop the inheritance

////////using System;

////////sealed class vehicle
////////{
////////    public void f1()
////////    {
////////        Console.WriteLine("f1() from vehicle class");
////////    }
////////}

////////class car : vehicle
////////{

////////}

////////class bus : car
////////{


////////}

////////============================================================

//////// interfaces : only function signatures / function names no body

//////// inheritance : single, multi level, hybrid, hierarchical 

//////// till 8.0 C#

//////using System;

//////interface IDellinterface1
//////{
//////     void function1();
//////}

//////interface IDellinterface2
//////{
//////     void function2();
//////}

//////class myclass : IDellinterface1, IDellinterface2
//////{
//////    public void function1()
//////    {
//////        Console.WriteLine("myclass--- function1() is invoked");
//////    }

//////    public void function2()
//////    {
//////        Console.WriteLine("myclass--- function2() is invoked");
//////    }
//////}

//////class mainclass
//////{
//////    static void Main(string[] args)
//////    {
//////        myclass m1= new myclass();
//////        m1.function1 ();
//////        m1.function2 ();

//////        Console.ReadLine    (); 
//////    }
//////}

//////=================================================================================

////// polymorphism

////// types : design time    function overloading, operator overloading 
//////         run time       function overriding 

////// function overloading : same function name with different parameters

////using System;
////using System.Runtime.InteropServices.WindowsRuntime;

////class calc
////{
////    public int add(int num1)
////    {
////        return (num1 + num1);
////    }
////    public int add(int num1, int num2)
////    {
////        return(num1+num2);
////    }
////    public double add(double num1, double num2)
////    {
////        return (num1 + num2);
////    }
////}
////class MyClass
////{
////    static void Main(string[] args)
////    {
////        calc obj = new calc();
////        Console.WriteLine(obj.add(10));
////        Console.WriteLine(obj.add(10.55, 11.20));
////        Console.WriteLine(obj.add(5, 6));
////        Console.ReadLine();
////    }
////}

////==========================================

//// function overriding 
//// same function name --parent class, derived class

//using System;

//class parentclass
//{
//    public virtual int add(int n1, int n2)
//    {
//        return (n1 + n2);
//    }
//}

//class childclass : parentclass
//{
//    public override int add(int n1, int n2)
//    {
//        int result = 100 + n1 + n2;
//        return result;
//    }
//}

//class myclass
//{
//    static void Main(string[] args)
//    {
//        childclass obj= new childclass();
//        Console.WriteLine(obj.add(10, 2));

//        parentclass obj1= new parentclass();
//        Console.WriteLine( obj1.add(10, 2));

//        Console.ReadLine();
//    }
//}

//=======================================================

// Abstract classes 

// features : abstract keyword --attached with the class
//            abstract class objects can not be created 
//            abstract class should have atleast 1 abstract method


using System;
//namespace X
//{
//   internal class A
//    {

//    }
//}
abstract class A
{
    int num1, num2;

    public A()
    {
        num1 = 10;
        num2 = 20;
    }
    public abstract void add();
    public void function1()
    {
        Console.WriteLine("A abstract class -- function1()");
        Console.WriteLine(num1+"    "+num2);
    }
}

class B : A
{
    public override void add()
    {
        
        Console.WriteLine("add() is invoked" );
    }
}

class myclass
{
    static void Main(string[] args)
    {
        B obj = new B();
        obj.function1();      

        Console.ReadLine();
    }

}