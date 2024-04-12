//// Selection sort in c#
//using System;

//namespace ConsoleApp_Dell2024
//{
//    class selection_sort
//    {
//        static void Main(string[] args)
//        {
//            int[] NumArray = new int[5] { 10, 6, 5, 4, 3 };

//            var arrayLength = NumArray.Length;  //10

//            for (int i = 0; i < arrayLength - 1; i++)
//            {
//                var smallestVal = i;

//                for (int j = i + 1; j < arrayLength; j++)
//                {
//                    if (NumArray[j] < NumArray[smallestVal])
//                    {
//                        smallestVal = j;
//                    }
//                }
//                var tempVar = NumArray[smallestVal];
//                NumArray[smallestVal] = NumArray[i];
//                NumArray[i] = tempVar;
//            }

//            Console.WriteLine("Selection sort  elements are : ");
//            foreach (var item in NumArray)
//            {
//                Console.WriteLine(item);
//            }

//            Console.ReadKey();
//        }

//    }
//}


           
