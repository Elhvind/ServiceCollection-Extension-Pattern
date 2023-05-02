using Bar;
using Foo;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class FooBarController : ControllerBase
{
    private readonly IBarService _barService;
    private readonly IFooService _fooService;

    public FooBarController(
        IBarService barService,
        IFooService fooService)
    {
        _barService = barService;
        _fooService = fooService;
    }

    [HttpGet]
    public async Task<FooDTO> Foo()
        => await _fooService.GetFoo();

    [HttpGet]
    public async Task<BarDTO> Bar()
        => await _barService.GetBar();
}
