using Bar;
using Foo;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers;

[ApiController]
[Route("[controller]")]
public class AppController : ControllerBase
{
    private readonly IBarService _barService;
    private readonly IFooService _fooService;

    public AppController(
        IBarService barService,
        IFooService fooService)
    {
        _barService = barService;
        _fooService = fooService;
    }

    [HttpGet]
    public async Task<(FooDTO, BarDTO)> Get()
    {
        var foo = await _fooService.GetFoo();
        var bar = await _barService.GetBar();
        return (foo, bar);
    }
}
