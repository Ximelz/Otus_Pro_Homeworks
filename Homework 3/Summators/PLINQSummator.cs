using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Homework_3
{
    public class PLINQSummator : ISummator
    {
        public long GetSumm(int[] intArray) => intArray.AsParallel().Sum();
        string ISummator.GetType() => "Параллельный сумматор с LINQ";
    }
}
