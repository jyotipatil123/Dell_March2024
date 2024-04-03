//// demo for string and string builder
//using System;
//using System.Text;


//namespace ConsoleApp_Dell2024
//{
//     class string_stringbuilder_demo
//    {
//        static void Main(string[] args)
//        {
//            string s1 = "Bangalore";
//            string s2 = "Mysore";

//            Console.WriteLine("First string is :"+ s1);
//            Console.WriteLine("Second string is :" + s2);
            

//            //=====================================

//            StringBuilder sb= new StringBuilder();
//            sb.Append("hello  ");
//            sb.Append(" all ");
//            sb.Append(" welcome to ");
//            sb.Append(" c#");

//            Console.WriteLine(sb);

//            // remove the characters (starting index, count of chars)
//            sb.Remove(0, 5);
//            Console.WriteLine(sb);

//            sb.Insert(0, "HELLO");
//            Console.WriteLine(sb);

//            Console.ReadLine();
//        }
//    }
//}
