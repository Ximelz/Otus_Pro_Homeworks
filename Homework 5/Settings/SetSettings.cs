namespace Homework_5
{
    public class SetSettings
    {
        private readonly ISetSettingsRepository setSettings;
        private readonly IEnumerable<IGetVarFromPerson> getUiList;
        public SetSettings(ISetSettingsRepository setSettings, IEnumerable<IGetVarFromPerson> getUiList)
        {
            this.setSettings = setSettings;
            this.getUiList = getUiList;
        }
        public async Task EntrySettings(RangeNatureNumbs range)
        {
            int amount = 2;
            int min = 0;
            int max = 10;
            IGetVarFromPerson? getVar = getUiList.Where(x => x.GetType() == UIDialogType.AmountSettings).FirstOrDefault();

            if (getVar != null)
                amount = getVar.GetNumb("Введите количество попыток:");

            await setSettings.SetAmountTries(amount);

            getVar = getUiList.Where(x => x.GetType() == UIDialogType.LimitSettings).FirstOrDefault();

            if (getVar == null)
                return;
            
            min = getVar.GetNumb("Введите 1 границу диапазона:");
            max = getVar.GetNumb("Введите 2 границу диапазона:");

            range.SetRange(min, max);

            await setSettings.SetRangeNumbs(range);
        }
    }
}
