namespace Homework_5
{
    public class SettingsInMemoryRepository : ISetSettingsRepository, IGetSettingsRepository
    {
        private RangeNatureNumbs rangeNumbers;
        private int amount = 2;
        public async Task SetAmountTries(int amount) => this.amount = amount;
        public async Task SetRangeNumbs(RangeNatureNumbs range) => this.rangeNumbers = range;
        public Task<int> GetAmountTries() => Task.FromResult(amount);
        public Task<RangeNatureNumbs> GetRangeNumbs() => Task.FromResult(rangeNumbers);
    }
}
