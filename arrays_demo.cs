//// arrays in c#
//using System;

//class arraydemo
//{
//    static void Main(string[] args)
//    {

//        // static array / fixed array
//        // dynamic arrays 

//        //============================================
//        //int[] empids;


//        //int[] arr = new int[5] { 1, 2, 3, 4, 5 };
//        //////or

//        ////int[] arr1= {1,2,3,4,6,9,8,7,7};

//        //////or
//        ////int[] arr5 = new int[4];
//        ////arr5[0] = 10;
//        ////arr5[1] = 20;
//        ////arr5[2] = 30;
//        ////arr5[3] = 40;

//        //Console.WriteLine("Array of numbers elements are : ");
//        //Console.WriteLine("for loop ---------------");
//        //for (int i = 0; i < 5; i++)
//        //{
//        //    Console.WriteLine(arr[i]);
//        //}


//        //Console.WriteLine("foreach loop -------------");
//        //foreach (var i in arr)   // var -implicitly typed local variable 
//        //{
//        //    Console.WriteLine(i);
//        //}

//        //char[] chars = { '1', '2', 'c', 'd' };

//        //Console.WriteLine("Array of chars elements are : ");
//        //for (int i = 0; i < 4; i++)
//        //{
//        //    Console.WriteLine(chars[i]);
//        //}

//        //string[] strings = { "123", "bb", "cc", "dd" };

//        //Console.WriteLine("Array of strings elements are : ");
//        //for (int i = 0; i < strings.Length; i++)
//        //{
//        //    Console.WriteLine(strings[i]);
//        //}


//        // multi dimensional / double dimensional 

//        //rows and columns --matrix 
//        //      0     1      2
//        //  0   11    12     13
//        //  1   14    16     18
//        //  2   15    17     19

//        //int[,] arr9 = new int[3, 3]  // rows, cols 
//        //{ 
//        //    { 11, 12, 13 },  //initialize the array elements 
//        //    { 14, 16, 18 }, 
//        //    { 15, 17, 19 }
//        //};

//        //Console.WriteLine("Double dimensional array is : ");
//        //for (int i = 0; i < 3; i++)   //rows      i=0                         i=1
//        //{
//        //    for (int j = 0; j < 3; j++) //columns     j=0  j=1  j=2  j=3    j=0  j=1  j=2  j=3
//        //    {
//        //        Console.Write(arr9[i,j]+ "    ");           11   12  13     
//        //    }                                               14   16  18
//        //    Console.WriteLine();
//        //}

//        //Jagged arrays 

//        int[][] arr1 = new int[2][];

//        arr1[0]= new int[3] {2,3,4};
//        arr1[1] = new int[4] { 8, 9, 7, 6 };

//        for(int i = 0; i < arr1.Length; i++) 
//        {
//            for (int j = 0; j < arr1[i].Length; j++)
//            {
//                Console.WriteLine(arr1[i][j]+"  ");
//            }
//            Console.WriteLine();
//        }



//        Console.ReadLine();
//    }
//}