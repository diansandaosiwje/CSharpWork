using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No._7
{
    class NumArray
    {
        static void Main(string[] args)
        {
            //示例数组  其余数组通过调用这个类的方法即可求最大最小值 和 及平均值 
            int[] numArray = { 6, 8 ,9, 7, 8, 1, 3, 85, 96, 76 };

            Console.WriteLine("The max number is : " + GetMaxNum(numArray));
            Console.WriteLine("The min number is : " + GetMinNum(numArray));
            Console.WriteLine("The sum number is : " + GetSumOfArray(numArray));
            Console.WriteLine("The average of number is : " + GetAverageOfArray(numArray));  
        }

        static int GetMaxNum(int[] numArray)
        {
            int maxNum=numArray[0];
            
            foreach(int num in numArray)
            {
                if (num > maxNum)
                    maxNum = num;                
            }
            return maxNum;
        }

        static int GetMinNum(int[] numArray)
        {
            int minNum = numArray[0];

            foreach (int num in numArray)
            {
                if (num < minNum)
                    minNum = num;
            }
            return minNum;
        }

        static int GetSumOfArray(int[] numArray)
        {
            int sumOfArray = 0;

            foreach(int num in numArray)
            {
                sumOfArray += num;
            }
            return sumOfArray;
        }

        static int GetAverageOfArray(int[] numArray)
        {
            int averageOfArray=0;

            int i = 0;
            foreach(int num in numArray)
            {
                i++;
            }

            averageOfArray = GetSumOfArray(numArray) / i;

            return averageOfArray;
        }


    }
}
