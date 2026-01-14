using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5
{
    public class ConsoleGameUI : IGetVarFromPerson, ISendMsgForPerson
    {
        private readonly RangeNatureNumbs rangeNumbs;
        public ConsoleGameUI(RangeNatureNumbs rangeNumbs) => this.rangeNumbs = rangeNumbs;
        public UIDialogType GetType() => UIDialogType.Game;
        public int GetNumb(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                var inputStr = Console.ReadLine();

                if (!int.TryParse(inputStr, out int result))
                {
                    Console.WriteLine("Вы ввели не число.");
                    continue;
                }

                if (rangeNumbs.NumbInRange(result))
                    return result;

                Console.WriteLine("Вы ввели число вне диапазона.");
            }
        }

        public void SendMsg(string message) => Console.WriteLine(message);
    }
}
