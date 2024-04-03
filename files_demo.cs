////  file handling  in c#
//using System;
//using System.IO;
//using System.Linq;

//namespace ConsoleApp_Dell2024
//{
//     class files_demo
//    {
//        static void Main(string[] args)
//        {
//            //FileInfo fi = new FileInfo("c:\\demo\\a.txt");
//            //Console.WriteLine(fi.FullName);
//            //Console.WriteLine(fi.Name);
//            //Console.WriteLine(fi.Extension);
//            //Console.WriteLine(fi.LastAccessTime);
//            //Console.WriteLine(fi.LastWriteTime);
//            //Console.WriteLine(fi.CreationTime);
//            ////---------------------------------------------------------

//            //DirectoryInfo d1 = new DirectoryInfo("c:\\demo\\ibm");
//            //Console.WriteLine(d1.FullName);
//            //Console.WriteLine(d1.Name);
//            //Console.WriteLine(d1.Extension);
//            //Console.WriteLine(d1.LastAccessTime);
//            //Console.WriteLine(d1.LastWriteTime);
//            //Console.WriteLine(d1.CreationTime);
//            //Console.WriteLine(d1.Parent);

//            ////====================================================
//            //DriveInfo d2 = new DriveInfo("c:");
//            //Console.WriteLine(d2.TotalSize);
//            //Console.WriteLine(d2.Name);
//            //Console.WriteLine(d2.AvailableFreeSpace);
//            //Console.WriteLine(d2.DriveType);

//            ////===========File class --create, remove, move, copy........

//            //File.AppendAllText("c:\\demo\\ibm\\a.txt", "this is new line"); //add / append the text

//            //File.WriteAllText("c:\\demo\\ibm\\a.txt", "dell bangalore");  //overrite

//            ////====================================================

//            //string dummyLines = Environment.NewLine + "This is first line." + Environment.NewLine +
//            //        "This is second line." + Environment.NewLine +
//            //        "This is third line.";

//            ////Opens DummyFile.txt and append lines. If file is not exists then create and open.
//            //File.AppendAllLines(@"c:\demo\ibm\a.txt", 
//            //    dummyLines.Split(Environment.NewLine.ToCharArray()).ToList<string>());



//            //  Directory 

//            var curDir = Directory.GetCurrentDirectory();
//            Console.WriteLine(curDir);

//            Console.WriteLine(Directory.GetDirectoryRoot(curDir));

//            //==============================================================
//            Console.WriteLine("Number of files in Demo folder : ");
//            string[] files = Directory.GetFiles("c:\\demo");

//            foreach (string f in files)
//            {
//                System.Console.WriteLine(f);
//            }
//            Console.ReadLine();
//        }
//    }
//}
