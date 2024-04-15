//////////  Constructors demo

////////using System;

////////class car
////////{
////////    int car_id;
////////    string car_name;    

////////    public car()   // default constructor          // no return type
////////    {
////////        car_id = 100;
////////        car_name = "Maruti";
////////    }
////////    public void display()
////////    {
////////        Console.WriteLine("Car id is : "+ car_id);
////////        Console.WriteLine("Car name is : "+ car_name);

////////        car c1= new car();
////////        c1.car_id = 101;
////////        c1.car_name = "bmw";
////////        Console.WriteLine("Car id is : " + c1.car_id);
////////        Console.WriteLine("Car name is : " + c1.car_name);
////////    }
////////}

////////class MyClass
////////{
////////    static void Main(string[] args)
////////    {
////////        car c1 = new car();   // default constructor is invoked 
////////        c1.display();


////////        Console.ReadLine(); 
////////    }
////////}


////////========================================

//////// parameterized constructor

////////  Constructors demo

//////using System;

//////class car
//////{
//////    int car_id;    string car_name;
//////    public car(int cid , string cname)   // paramerized constructor          // no return type
//////    {
//////        car_id=cid ;
//////        car_name=cname;
//////    }
//////    public void display()
//////    {
//////        Console.WriteLine("Car id is : " + car_id);
//////        Console.WriteLine("Car name is : " + car_name);       
//////    }
//////}
//////class MyClass
//////{
//////    static void Main(string[] args)
//////    {
//////        car c1 = new car(100,"bmw");   // default constructor is invoked 
//////        c1.display();


//////        Console.ReadLine();
//////    }
//////}

//////-------------copy constructor

////using System;

////class employee
////{
////    private string name;
////    private int age;
////    public employee(employee emp)   // declaring Copy constructor.
////    {
////        name = emp.name;
////        age = emp.age;
////    }
////    public employee(string name1, int age1)  // Instance constructor.
////    {
////        this.name = name1;
////        this.age = age1;
////    }
////    public string Details     // Get deatils of employee
////    {
////        get
////        {
////            return " The age of " + name + " is " + age.ToString();
////        }
////    }
////}
////class empdetail
////{
////    static void Main()
////    {
////        employee emp1 = new employee("Vithal", 23);  // Create a new employee object.
////        employee emp2 = new employee(emp1);          // here is emp1 details is copied to emp2.

////        Console.WriteLine(emp2.Details);


////        Console.ReadLine();
////    }
////}


//// private constructor

//// C# program to illustrate the
//// concept of private Constructor
////using System;

//// class Dell
////{    // Private constructor without parameter
////    private Dell()
////    {
////        Console.WriteLine("Private Constructor");
////    }

////    public void display()
////    {
////        Dell d1= new Dell();
////        Console.WriteLine("private constructor is invoked from display function");
////    }
////}

////// Driver Class
////class myclass
////{
////    // Main Method
////    static void Main()
////    {

////        // This line raise error because
////        // the constructor is inaccessible
////        Dell obj=new Dell();
////        obj.display();

////        Console.ReadLine    
////    }
////}


////=========================private constructor

//// C# program to illustrate the
//// concept of private Constructor
//using System;

//class Dell
//{
//    // Variables
//    public static string name;
//    public static int num;

//    // Creating private Constructor
//    // using private keyword
//    private Dell()
//    {
//        Console.WriteLine("Welcome to Private Constructor");
//    }

//    // Default Constructor
//    // with parameters
//    public Dell(string a, int b)
//    {
//        name = a;
//        num = b;
//    }
//}

//// Driver Class
//class myclass
//{
//    // Main Method
//    static void Main()
//    {
//        // This line raises error because
//        // the constructor is inaccessible
//        // Dell obj1 = new Dell();

//        // Here, the only default 
//        // constructor will invoke
//        Dell obj2 = new Dell("Pooja", 2);

//        // Here, the data members of Dell
//        // class are directly accessed
//        // because they are static members
//        // and static members are accessed 
//        // directly with the class name
//        Console.WriteLine(Dell.name + ", " + Dell.num);

//        Console.ReadLine();
//    }
//}
