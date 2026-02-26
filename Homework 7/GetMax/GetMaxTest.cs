using System.Text;

namespace Homework_7
{
    public class GetMaxTest
    {
        public static void StartTest()
        {
            List<TestConvertInt> intsList = new List<TestConvertInt>();
            List<TestConvertString> strList = new List<TestConvertString>();

            Random random = new Random();
            for (int i = 0; i < 100; i++)
                intsList.Add(new TestConvertInt() { x = random.Next(-1000, 1000) });

            for (int i = 0; i < 100; i++)
            {
                StringBuilder sb = new StringBuilder();
                var strLength = random.Next(1, 30);
                for (int j = 0; j < strLength; j++)
                    sb.Append("kioa");

                strList.Add(new TestConvertString() { x = sb.ToString() });
            }

            IEnumerable<TestConvertInt> intCollection = intsList;
            IEnumerable<TestConvertString> strCollection = strList;

            GetMinMax<TestConvertInt>(x => (float)x.x, "Int", intCollection);
            GetMinMax<TestConvertString>(x => (float)x.x.Length, "String", strCollection);
        }

        private static void GetMinMax<T>(Func<T, float> convertToNumber, string type, IEnumerable<T> collection) where T : class
        {
            try
            {
                var maxStr = collection.GetMax<T>(convertToNumber);
                var minStr = collection.GetMin<T>(convertToNumber);
                Console.WriteLine($"{type}:\r\nMax = {maxStr}; min = {minStr}");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.ParamName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    public class TestConvertInt
    {
        public int x;
        public override string ToString() => x.ToString();
    }
    public class TestConvertString
    {
        public string x;
        public override string ToString() => x.ToString();
    }


}
