using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tnayinayin
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] myArr = { 2, 4, 8, 6, 7, 23, 54, 12, 23 };

            int minValue = myArr[0];

            for (int i = 1; i < myArr.Length; i++)
                
            {
                if (myArr[i]<minValue)
                {
                    minValue = myArr[i];
                }
            }
            Console.WriteLine(minValue);

            int[] myArr1 = { 2, 4, 8, 6, 7, 23, 54, 12, 23 };

            int maxValue = myArr1[0];

            for (int i = 1; i < myArr1.Length; i++)

            {
                if (myArr1[i] > maxValue)
                {
                    maxValue = myArr1[i];
                }
            }
            Console.WriteLine(maxValue);
        }
        }
    }

