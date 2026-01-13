using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_3
{
    public class DefaultSummator : ISummator
    {
        public long GetSumm(int[] intArray) => intArray.Sum();
        string ISummator.GetType() => "Обычный сумматор";
    }
}
