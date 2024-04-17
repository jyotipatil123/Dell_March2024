//// upcasting and downcasting demo

//using System;


//namespace ConsoleApp_Dell2024
//{
//    public class Shape
//    {
//        protected int m_xpos;
//        protected int m_ypos;
//        public Shape()
//        {
//        }
//        public Shape(int x, int y)
//        {
//            m_xpos = x;
//            m_ypos = y;
//        }
//        public virtual void Draw()
//        {
//            Console.WriteLine("Drawing a SHAPE at {0},{1}", m_xpos, m_ypos);
//        }
//    }

//    public class Square : Shape
//    {
//        public Square()
//        {
//        }
//        public Square(int x, int y) : base(x, y)
//        {
//        }
//        public override void Draw()
//        {
//            Console.WriteLine("Drawing a SQUARE at {0},{1}", m_xpos, m_ypos);
//        }
//    }

//    public class Circle : Shape
//    {
//        public Circle()
//        {
//        }
//        public Circle(int x, int y) : base(x, y)
//        {
//        }
//        public override void Draw()
//        {
//            Console.WriteLine("Drawing a CIRCLE at {0},{1}", m_xpos, m_ypos);
//        }

//        public void FillCircle()
//        {
//            Console.WriteLine("Filling CIRCLE at {0},{1}", m_xpos, m_ypos);
//        }

//    }

//    class MyClass
//    {
//        static void Main(string[] args)
//        {
//            Shape sh = new Shape(100, 100);
//            sh.Draw();

//            Square sq = new Square(200, 200);
//            sq.Draw();

//            Circle ci = new Circle(300, 300);
//            ci.Draw();

//            Shape s = new Circle(100, 100);
//            s.Draw(); 
//            // xxx not getting fillcircle() here.

//            Circle c;
//            c = (Circle)s;
//            c.Draw();
//            c.FillCircle();

//            Console.ReadLine();
//        }
//    }

//}


// value types and reference types 
// Boxing and unboxing 

using System;

class MyClass
{
    static void Main(string[] args)
    {
        // Boxing 
        int a = 100;
        object b = new object();
        b = a;
        Console.WriteLine("b="+b);

        // Unboxing 
        object ob1 = new object();
        ob1= "sachin";
        string x =(string) ob1;
        Console.WriteLine("x="+x);


        Console.ReadLine();
    }
}