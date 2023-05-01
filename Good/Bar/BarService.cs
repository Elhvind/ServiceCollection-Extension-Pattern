﻿using Microsoft.Extensions.Options;

namespace Bar;

internal sealed class BarService : IBarService
{
    private readonly BarRepository _barRepository;
    private readonly BarOptions _options;

    public BarService(
        BarRepository barRepository,
        IOptions<BarOptions> options)
    {
        _barRepository = barRepository;
        _options = options.Value;
    }

    public async Task GetBar()
    {
        var amount = _options.Amount;
        await _barRepository.GetBar(amount);
    }
}
