////// Properties in c#

////// different types of properties : read only, write only, read write property,
////// automatic property 

////using System;


////namespace ConsoleApp_Dell2024
////{
////    class employee
////    {
////        // automatic property
////        public int Id { get; set; }    //accessors
////        public string Name { get; set; }
////        public string Description { get; set; }
////    }
////    class property_demo
////    {
////        static void Main(string[] args)
////        {
////            employee e1 = new employee();
////            e1.Id = 1;
////            e1.Name = "suhas";
////            e1.Description = "15 yrs of experience";

////            Console.WriteLine("Employee id : "+e1.Id+ "Employee Name : "+ e1.Name+"Employee description : "+e1.Description);

////            employee e2 = new employee();
////            e2.Id = 2;
////            e2.Name = "Anil";
////            e2.Description = "10 yrs of experience";

////            Console.WriteLine("Employee id : {0} Employee Name : {1} Employee description :{2}",e2.Id,e2.Name,e2.Description);


////            Console.WriteLine("============================================================"   );
////            Console.WriteLine(String.Format("Employee id {0}", e2.Id) + Environment.NewLine+
////                              String.Format("Employee name is : {0}", e2.Name)+"\n"+
////                              String.Format("Employee description is : {0}", e2.Description));

////            Console.ReadLine();
////        }
////    }
////}


////// read only property

////using System;

////class employee
////{
////    string n = "pooja";
////    public int Id { get; set; } 
////    public string Name 
////    { 
////        get
////        {
////            return n;
////        }

////    }   //read only property
////}

////class MyClass
////{
////    static void Main(string[] args)
////    {            
////        employee e1= new employee();
////        e1.Id = 1;
////        Console.WriteLine(e1.Name);



////        Console.ReadLine();
////    }
////}

//// write only property

//// read only property

//using System;

//class employee
//{
//    string n;
//    public int Id { get; set; }
//    public string Name
//    {
//        set
//        {
//          n=value ;
//        }

//    }   //read only property
//}

//class MyClass
//{
//    static void Main(string[] args)
//    {
//        employee e1 = new employee();
//        e1.Id = 1;

//        e1.Name = "Test";  // this is not an error 



//        // reading ---- error
//       // Console.WriteLine(e1.Name);



//        Console.ReadLine();
//    }
//}