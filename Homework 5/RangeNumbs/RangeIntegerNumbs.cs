using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5
{
    public class RangeIntegerNumbs : RangeNatureNumbs
    {
        public override void SetRange(int firstLimit, int secondLimit)
        {
            if (firstLimit > secondLimit)
            {
                var temp = firstLimit;
                firstLimit = secondLimit;
                secondLimit = temp;
            }

            min = firstLimit;
            max = secondLimit;
        }
    }
}
