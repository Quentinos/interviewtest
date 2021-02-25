using System;

namespace interviewtest
{
    class Program
    {
        static void Main(string[] args)
        {

           // Algorithme de Quentin

            int[] myArray = { 1, -3, 165, 1, -1, 9, -5, 15, 175, -2 , 5 , 9, 300, -500, 900, 650,-450 };
            int sumOfArray = 0;
            int maxSubarray = 0;
            int index1 = 0;
            int index2 = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                sumOfArray = 0;
                Console.WriteLine("itération" + i);
                for (int y = i; y < myArray.Length; y++)
                {
                    sumOfArray = sumOfArray + myArray[y];

                    if (sumOfArray > maxSubarray)
                    {
                        maxSubarray = sumOfArray;
                        index1 = i;
                        index2 = y;
                    }
                    Console.WriteLine("itération" + y);
                    Console.WriteLine("sumOfArray : " + sumOfArray);
                    Console.WriteLine("maxSubArray : " + maxSubarray);
                }
            }
            Console.WriteLine("Le subarray max " + maxSubarray + " à l'index i : " + index1 + " et index y : " + index2);



            // Algorythme de Kadane

            int max_current;
            int max_global;
            max_current = myArray[0];
            max_global = myArray[0];

            for(int z = 1; z <myArray.Length-1; z++)
            {
                max_current = Math.Max(myArray[z], max_current + myArray[z]);
                if(max_current > max_global)
                {
                    max_global = max_current;
                }
            }
            Console.WriteLine("le subarray maxglobal est : " + max_global);

        }
    }
}
