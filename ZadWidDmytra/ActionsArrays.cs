using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadWidDmytra
{
    internal class ActionsArrays
    {
        public static double SumArray(params double [] array)
        {
            double result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];

            }
            return result;
        }

        public static double MinArray(params double[] array)
        {
            double result = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < result)
                    result = array[i];
            }
            return result;
        }

        public static double MaxArray(params double[] array)
        {
            double result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= result)
                    result = array[i];
            }
            return result;
        }
    }
}
