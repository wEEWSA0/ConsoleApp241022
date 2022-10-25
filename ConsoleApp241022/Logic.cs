using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp241022
{
    internal class Logic
    {
        public bool IsNumbersDifferenceCorrect(List<int> numbers)
        {
            bool lastF = numbers[1] - numbers[0] >= 0;

            for (int i = 2; i < numbers.Count; i++)
            {
                if ((numbers[i] - numbers[i-1] >= 0 && !lastF) || (numbers[i] - numbers[i - 1] < 0 && lastF))
                {
                    lastF = !lastF;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public void NumbersDifferenceCorrectWithChanges(ref List<int> numbers)
        {
            bool lastF = numbers[1] - numbers[0] >= 0;

            for (int i = 2; i < numbers.Count; i++)
            {
                if ((numbers[i] - numbers[i - 1] >= 0 && !lastF) || (numbers[i] - numbers[i - 1] < 0 && lastF))
                {
                    lastF = !lastF;
                }
                else
                {
                    numbers.RemoveAt(i);

                    Console.WriteLine();
                    numbers.ForEach((s) => Console.Write(s + ", "));

                    NumbersDifferenceCorrectWithChanges(ref numbers);

                    break;
                }
            }

            if (numbers.Count == 2)
            {
                numbers.Clear();
            }
        }
    }
}
