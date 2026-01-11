using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4
{
    public interface IMyCloneable<T> where T : class
    {
        public T MyClone();
    }
}
