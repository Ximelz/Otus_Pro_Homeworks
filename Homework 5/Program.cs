namespace Homework_5
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            RangeNatureNumbs range = new RangeIntegerNumbs();
            ConsoleGameUI gameUi = new ConsoleGameUI(range);
            IGetVarFromPerson setAmount = new SetAmountTiers();
            IGetVarFromPerson setLimit = new SetLimitRange();
            IEnumerable<IGetVarFromPerson> uiDialogs = new List<IGetVarFromPerson>() { setAmount, setLimit };
            
            SettingsInMemoryRepository settings = new SettingsInMemoryRepository();
            SetSettings setSettings = new SetSettings(settings, uiDialogs);
            INumberGenerator generator = new NumberGenerator();
            IChecker checker = new Checker(generator);
            GameGuessNumb game = new GameGuessNumb(settings, checker, gameUi, gameUi);
            while (true)
            {
                await setSettings.EntrySettings(range);
                await game.Start();

                Console.WriteLine("Хотите сыграть еще раз?\r\n" +
                                  "Введите \"Да\" для еще одной игры:");
                var input = Console.ReadLine();

                if (input.ToLower() == "да")
                    continue;

                break;
            }
        }
    }
}
