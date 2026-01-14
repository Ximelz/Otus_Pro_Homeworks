namespace Homework_5
{
    public class SetLimitRange : IGetVarFromPerson
    {
        public UIDialogType GetType() => UIDialogType.LimitSettings;
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

                return result;
            }
        }
    }
}
