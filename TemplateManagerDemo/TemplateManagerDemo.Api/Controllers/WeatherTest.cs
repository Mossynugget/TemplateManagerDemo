using Microsoft.AspNetCore.Mvc;

namespace TemplateManagerDemo.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class WeatherTest : ControllerBase
  {
    private readonly ILogger<WeatherTest> _logger;

    public WeatherTest(ILogger<WeatherTest> logger)
    {
      _logger = logger;
    }
  }
}