using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofthemeTest_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Зчитування
            Console.Write("Enter number: ");
            
            if (!int.TryParse(Console.ReadLine(), out int number))
                throw new ArgumentException("You must enter digit value", nameof(number));


            //получити дільники
            var dividers = GetDividers(number);

            //Вивід
            Console.WriteLine($"Dividers of number {number}:");

            dividers.ForEach(Console.WriteLine);
        }
        static List<int> GetDividers(int number)
        {
            if (number < 1)
                return new List<int>();

            List<int> dividers = new List<int>();

            dividers.Add(1);
            dividers.Add(number);

            for (int i = 2; i <= Math.Sqrt(number); i++)
                if (number % i == 0)
                {
                    dividers.Add(i);                    //добавляємо дільник і його доповнення
                    dividers.Add(number / i);           //добавляємо дільник і його доповнення
                }

            return dividers.Distinct().OrderBy(i=>i).ToList();
        }

    }
}
