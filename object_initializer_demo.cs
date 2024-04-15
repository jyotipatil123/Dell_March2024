////// object initializers in c#
////using System;

////public class Student
////{
////    public int StudentID { get; set; }
////    public string StudentName { get; set; }
////    public int Age { get; set; }
////    public string Address { get; set; }
////}

////class Program
////{
////    static void Main(string[] args)
////    {
////        Student std = new Student()
////        {
////            StudentID = 1, StudentName = "Bill",
////            Age = 20, Address = "New York"
////        };

////        Console.WriteLine(std.StudentID+"   "+ std.StudentName+"  "+std.Age+"  "+std.Address);
////        Console.ReadLine();

////    }
////}


//// access modifiers


//using System;

//public class parentclass
//{
//    protected void function1()
//    {
//        Console.WriteLine("private void function1() from parent class");
//    }
//}

//public class childclass : parentclass
//{
//    private void function2()
//    {
//        Console.WriteLine("private void function2() from child class");
//    }

//    public void function3()
//    {
//        childclass obj2= new childclass();
//        obj2.function1();
//        obj2.function2 ();
//        obj2.function3 ();
//    }
//}

//class MyClass
//{
//    static void Main(string[] args)
//    {
//        parentclass p1 = new parentclass();
        
//        childclass obj= new childclass();
        
//        Console.ReadLine();
//    }

//}
