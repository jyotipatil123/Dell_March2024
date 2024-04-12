//// Bubble sort in c#
//using System;

//namespace ConsoleApp_Dell2024
//{
//    class bubblesort
//    {
//        static void Main(string[] args)
//        {
//            int[] number = { 89, 76, 45, 92, 67, 12, 99 };
//            //  1st pass  76  89  45 92 67 12 99
//            //  2nd pass  76  45  89 92 67 12 99
//            // 3rd pass   76  45  89 67 92 12 99
//            // 4th pass   76  45  89 67 12 92 99
//            // 5th pass   76  45  89 12 67 92 99
//            // 6th pass   76  45  ..........................................

//            bool flag = true;
//            int temp; 
//            int numLength = number.Length;   //7  

//            //sorting an array
//            for (int i = 1; (i <= (numLength - 1)) && flag; i++)  // i=1   i<6 &&flag==true 
//            {
//                flag = false;
//                for (int j = 0; j < (numLength - 1); j++)
//                {
//                    if (number[j + 1] < number[j])
//                    {
//                        temp = number[j];
//                        number[j] = number[j + 1];
//                        number[j + 1] = temp;
//                        flag = true;
//                    }
//                }
//            }

//            //Sorted array
//            foreach (int num in number)
//            {
//                Console.Write("\t {0}", num);
//            }
//            Console.Read();
//        }
//    }
//}

