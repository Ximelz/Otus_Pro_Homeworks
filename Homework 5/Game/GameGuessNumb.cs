namespace Homework_5
{
    public class GameGuessNumb
    {
        private readonly IGetSettingsRepository getSettings;
        private readonly IChecker checker;
        private readonly IGetVarFromPerson getDialog;
        private readonly ISendMsgForPerson sendDialog;
        public GameGuessNumb(IGetSettingsRepository getSettings, IChecker checker, IGetVarFromPerson getDialog, ISendMsgForPerson sendDialog)
        {
            this.getSettings = getSettings;
            this.checker = checker;
            this.getDialog = getDialog;
            this.sendDialog = sendDialog;
        }
        public async Task Start()
        {
            int triesAmount = await getSettings.GetAmountTries();
            var gameResult = GameResult.Lose;
            CheckResult checkResult;
            int numberFromPerson;
            await checker.SetHiddenNumb(await getSettings.GetRangeNumbs());

            for (int i = 0; i < triesAmount; i++)
            {
                numberFromPerson = getDialog.GetNumb("Введите число:");
                checkResult = await checker.CheckNumb(numberFromPerson);

                if (checkResult == CheckResult.Equal)
                {
                    gameResult = GameResult.Win;
                    break;
                }

                if (checkResult == CheckResult.More)
                    sendDialog.SendMsg("Загаданное число больше введенного!");
                else
                    sendDialog.SendMsg("Загаданное число меньше введенного!");
            }

            if (gameResult == GameResult.Lose)
                sendDialog.SendMsg("Вы проиграли!");
            else
                sendDialog.SendMsg("Вы победили!");
        }
    }
}
