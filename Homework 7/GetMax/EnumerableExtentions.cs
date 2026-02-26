using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Homework_7
{
    public static class EnumerableExtentions
    {
        public static T GetMax<T>(this IEnumerable collection, Func<T, float> convertToNumber) where T : class
        {
            var enumirator = collection.GetEnumerator();

            if (!enumirator.MoveNext())
                throw new ArgumentNullException("Коллекция пуста!");

            if (enumirator.Current is not T)
                throw new Exception("Неверный тип коллекции!");

            T result = (T)enumirator.Current;
            float max = convertToNumber(result);
            while (enumirator.MoveNext())
            {
                T currentObj = (T)enumirator.Current;
                var current = convertToNumber(currentObj);
                if (current > max)
                {
                    max = current;
                    result = currentObj;
                }
            }
            return result;
        }

        public static T GetMin<T>(this IEnumerable collection, Func<T, float> convertToNumber) where T : class
        {
            var enumirator = collection.GetEnumerator();

            if (!enumirator.MoveNext())
                throw new ArgumentNullException("Коллекция пуста!");

            if (enumirator.Current is not T)
                throw new Exception("Неверный тип коллекции!");

            T result = (T)enumirator.Current;
            float max = convertToNumber(result);
            while (enumirator.MoveNext())
            {
                T currentObj = (T)enumirator.Current;
                var current = convertToNumber(currentObj);
                if (current < max)
                {
                    max = current;
                    result = currentObj;
                }
            }
            return result;
        }
    }
}
