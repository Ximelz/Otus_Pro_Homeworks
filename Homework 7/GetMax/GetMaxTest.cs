namespace Homework_7
{
    public class GetMaxTest
    {
        public static void StartTest()
        {
            try
            {
                List<TestConvertInt> intsList = new List<TestConvertInt>();
                List<TestConvertString> strList = new List<TestConvertString>();

                Random random = new Random();
                for (int i = 0; i < 100; i++)
                    intsList.Add(new TestConvertInt() { x = random.Next(-1000, 1000) });

                for (int i = 0; i < 100; i++)
                {
                    string str = "";
                    for (int j = 0; j < random.Next(1, 30); j++)
                        str += "kioa";

                    strList.Add(new TestConvertString() { x = str });
                }

                IEnumerable<TestConvertInt> intCollection = intsList;
                IEnumerable<TestConvertString> strCollection = strList;

                var maxInt = intCollection.GetMax<TestConvertInt>(x => (float)x.x);
                var minInt = intCollection.GetMin<TestConvertInt>(x => (float)x.x);
                Console.WriteLine($"Int:\r\nMax = {maxInt}; min = {minInt}");

                var maxStr = strCollection.GetMax<TestConvertString>(x => (float)x.x.Length);
                var minStr = strCollection.GetMin<TestConvertString>(x => (float)x.x.Length);
                Console.WriteLine($"String:\r\nMax = {maxStr}; min = {minStr}");
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
