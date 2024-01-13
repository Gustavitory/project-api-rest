using Microsoft.AspNetCore.Mvc;
using services;

namespace project_rest.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloWorldController : Controller
{
    private readonly ILogger<HelloWorldController> _logger;
    IHelloWorldService helloWorldService;

    public HelloWorldController(ILogger<HelloWorldController> logger, IHelloWorldService helloWorld)
    {
        _logger = logger;
        helloWorldService = helloWorld;
    }

    [HttpGet]
    public IActionResult Get()
    {
        _logger.LogInformation("Hola mundoo");
        return Ok(helloWorldService.GetHelloWorld());
    }
}