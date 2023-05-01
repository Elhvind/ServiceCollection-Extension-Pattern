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

    public async Task<BarDTO> GetBar()
    {
        var id = _config.GetValue<int>("Bar:Id");
        return await _barRepository.GetBar(id);
    }
}
