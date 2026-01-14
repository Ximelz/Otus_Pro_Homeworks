using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5
{
    public class Checker : IChecker
    {
        private int hiddenNumb;
        private readonly INumberGenerator numberGen;
        public Checker(INumberGenerator numberGen) => this.numberGen = numberGen;
        public async Task<CheckResult> CheckNumb(int number)
        {
            if (number > hiddenNumb)
                return CheckResult.Less;

            if (number < hiddenNumb)
                return CheckResult.More;

            return CheckResult.Equal;
        }
        public async Task SetHiddenNumb(RangeNatureNumbs range) => hiddenNumb = await numberGen.GetNumber(range);
    }
}
