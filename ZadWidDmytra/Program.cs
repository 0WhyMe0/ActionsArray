using System.ComponentModel.Design;
using ZadWidDmytra;

class Program
{
    static void Main(string[] args)
    {      

        Console.WriteLine("Введвть величену масива: ");
        int aelichenArray = int.Parse(Console.ReadLine());

        double[] arrray = new double[aelichenArray];
        double[] arrray2 = new double[aelichenArray];

        for (int i = 0; i < arrray.Length; i++)
        {
            Console.WriteLine("Введіть числа в масив");
            string str = Console.ReadLine();
            bool ara = double.TryParse(str, out arrray[i]);
            if (ara)
            {
                arrray2 = arrray;
            }
            else
            {
                Console.WriteLine("Введена не правильна іншормація");
            }
        }
            double result = ActionsArrays.MaxArray(arrray2);
        Console.WriteLine(result);

        Console.WriteLine();
    }
}