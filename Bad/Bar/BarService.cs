using Microsoft.Extensions.Configuration;

namespace Bar;

public sealed class BarService : IBarService
{
    private readonly BarRepository _barRepository;
    private readonly IConfiguration _config;

    public BarService(
        BarRepository barRepository,
        IConfiguration config)
    {
        _barRepository = barRepository;
        _config = config;
    }

    public async Task GetBar()
    {
        var amount = _config.GetValue<int>("Bar:Amount");
        await _barRepository.GetBar(amount);
    }
}
