namespace Homework_5
{
    public class SetAmountTiers : IGetVarFromPerson
    {
        public UIDialogType GetType() => UIDialogType.AmountSettings;
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

                if (result > 1)
                    return result;

                Console.WriteLine("Количество попыток не может быть меньше 1.");
            }
        }
    }
}
