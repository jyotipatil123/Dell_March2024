////// OOPS demo
////using System;

////class vehicle
////{ 
////   public int vehicle_id;
////   public string vehicle_name;    
////    string vehicle_type;
////    int vehicle_speed;
////    string vehicle_speed_type;

////    public void move()
////    {
////        Console.WriteLine("Vehicle is moving");
////        computer obj1= new computer();
////        obj1.memory();
////    }

////    public void speed()
////    {
////        int vehicle_speed = 200;
////        Console.WriteLine("Vehicle speed is : "+vehicle_speed);
////    }
////}

////class computer
////{ 
////    int computer_id;
////    string computer_name;
////    public int brand;

////    public void memory()
////    {
////        Console.WriteLine("RAM and ROM");
////    }
////}


////class dell
////{
////    static void Main(string[] args)
////    {
////        vehicle veh = new vehicle();

////        veh.move();
////        veh.speed();

////        veh.vehicle_id = 1;
////        veh.vehicle_name="test";
////        Console.WriteLine(veh.vehicle_id);
////             Console.WriteLine(veh.vehicle_name);

////        computer obj = new computer();
////        obj.memory();

////        Console.ReadLine();
////    }
////}

////==============================================


//// inheritance 
//using System;

//class shape
//{
//    public void shape_type()
//    {
//        Console.WriteLine("Differnt types of shapes are present");
//    }
//}

//// single / simple/ single level inheritance 
//class square : shape   // :  inheritance operator
//{
//    public void sides()
//    {
//        Console.WriteLine("square has 4 sides");
//    }
//}
//class rectangle : shape      // hierarchical inheritance 
//{
//    public void sides()
//    {
//        Console.WriteLine("Rectangle is also having 4 sides.");
//    }
//}

//class circle : rectangle   // multi level inheritance 
//{
//   public void function1()
//    {
//        Console.WriteLine("circle -- rectangle is the parent");
//    }
//}

//class A
//{
//    static void Main(string[] args)
//    {

//        //// parent directly
//        //shape obj1 = new shape();
//        //obj1.shape_type();


//        // from child --parent also 
//        square obj2= new square();
//        obj2.sides();
//        obj2.shape_type();


//        // from child -- parent also 
//        rectangle obj3= new rectangle();    
//        obj3.sides();
//        obj3.shape_type();


//        // multi level inheritance
//        circle c1 = new circle();
//        c1.function1();
//        c1.shape_type();
//        c1.sides();

//        Console.ReadLine();
//    }
//}

// structures in c#

using System;
struct Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public void author()
    {
        Console.WriteLine("Microsoft");
    }

}

class MyClass
{
    static void Main(string[] args)
    {
        Book b1= new Book();
        b1.Id = 1;
        b1.Name = "C#";
        b1.Description = "2000 year published";

        Console.WriteLine("Book1 details :");
        Console.WriteLine(b1.Id + "     " + b1.Name + "   " + b1.Description);
        b1.author();



        Book b2 = new Book();
        b2.Id = 2;
        b2.Name = "Asp.net";
        b2.Description = "2004 year published";


        Console.WriteLine("Book2 details :");
        Console.WriteLine(b2.Id + "     " + b2.Name + "   " + b2.Description);


        Book b3 = new Book();
        b3.Id = 3;
        b3.Name = "WPF";
        b3.Description = "2008 year published";

        Console.WriteLine("Book3 details :");
        Console.WriteLine(b3.Id + "     " + b3.Name + "   " + b1.Description);




        Console.ReadLine();
    }
}