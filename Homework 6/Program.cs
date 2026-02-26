using Newtonsoft.Json;
using System.Diagnostics;
using System.Linq;

namespace Homework_6
{
    public class Program
    {
        static void Main(string[] args)
        {
            string serializeStr;
            TestInt resultInt;
            int iterations = 10_000_000;
            List<string> serializeList = new List<string>();

            Console.WriteLine("Собственная реализация сериализации:");
            Console.WriteLine($"\tКоличество замеров: {iterations} итераций.");
            Console.WriteLine("\tЗначения в объекте: int.");

            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < iterations; i++)
            {
                serializeStr = CustomSerializer.Serialize(TestInt.Get());
                serializeList.Add(serializeStr);
            }
            sw.Stop();

            Console.WriteLine($"\tВремя на сериализацию: {sw.ElapsedMilliseconds} мс");

            sw = Stopwatch.StartNew();
            foreach (var serialize in serializeList)
                resultInt = CustomSerializer.Deserialize<TestInt>(serialize);
            sw.Stop();

            Console.WriteLine($"\tВремя на десериализацию: {sw.ElapsedMilliseconds} мс");

            serializeList.Clear();

            Console.WriteLine("Json реализация сериализации:");
            Console.WriteLine($"\tКоличество замеров: {iterations} итераций.");
            Console.WriteLine("\tЗначения в объекте: int.");

            sw = Stopwatch.StartNew();
            for (int i = 0; i < iterations; i++)
            {
                serializeStr = JsonConvert.SerializeObject(TestInt.Get());
                serializeList.Add(serializeStr);
            }
            sw.Stop();

            Console.WriteLine($"\tВремя на сериализацию: {sw.ElapsedMilliseconds}  мс");

            sw = Stopwatch.StartNew();
            foreach (var serialize in serializeList)
                resultInt = JsonConvert.DeserializeObject<TestInt>(serialize);
            sw.Stop();

            Console.WriteLine($"\tВремя на десериализацию: {sw.ElapsedMilliseconds} мс");
            Console.WriteLine("-----------------------------------------------------");

            serializeList.Clear();

            TestStr resultStr;

            Console.WriteLine("Собственная реализация сериализации:");
            Console.WriteLine($"\tКоличество замеров: {iterations} итераций.");
            Console.WriteLine("\tЗначения в объекте: string.");

            sw = Stopwatch.StartNew();
            for (int i = 0; i < iterations; i++)
            {
                serializeStr = CustomSerializer.Serialize(TestStr.Get());
                serializeList.Add(serializeStr);
            }
            sw.Stop();

            Console.WriteLine($"\tВремя на сериализацию: {sw.ElapsedMilliseconds}  мс");

            sw = Stopwatch.StartNew();
            foreach (var serialize in serializeList)
                resultStr = CustomSerializer.Deserialize<TestStr>(serialize);
            sw.Stop();

            Console.WriteLine($"\tВремя на десериализацию: {sw.ElapsedMilliseconds}  мс");

            serializeList.Clear();

            Console.WriteLine("Json реализация сериализации:");
            Console.WriteLine($"\tКоличество замеров: {iterations} итераций.");
            Console.WriteLine("\tЗначения в объекте: string.");

            sw = Stopwatch.StartNew();
            for (int i = 0; i < iterations; i++)
            {
                serializeStr = JsonConvert.SerializeObject(TestStr.Get());
                serializeList.Add(serializeStr);
            }
            sw.Stop();

            Console.WriteLine($"\tВремя на сериализацию: {sw.ElapsedMilliseconds}  мс");

            sw = Stopwatch.StartNew();
            foreach (var serialize in serializeList)
                resultStr = JsonConvert.DeserializeObject<TestStr>(serialize);
            sw.Stop();

            Console.WriteLine($"\tВремя на десериализацию: {sw.ElapsedMilliseconds}  мс");
        }
    }


    public class TestInt
    {
        public int i1, i2, i3, i4, i5;
        public static TestInt Get() => new TestInt() { i1 = 1, i2 = 2, i3 = 3, i4 = 4, i5 = 5 };
        public override string ToString() => $"{this.i1};{this.i2};{this.i3};{this.i4};{this.i5}";
    }

    public class TestStr
    {
        public string s1, s2, s3, s4, s5;
        public static TestStr Get() => new TestStr() { s1 = "1", s2 = "2", s3 = "3", s4 = "4", s5 = "5" };
        public override string ToString() => $"{this.s1};{this.s2};{this.s3};{this.s4};{this.s5}";
    }
}
