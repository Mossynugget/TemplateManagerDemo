using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TemplateManagerDemo.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class WeatherController : ControllerBase
  {
    private readonly IMediator _mediator;
    private readonly ILogger<WeatherController> _logger;

    public WeatherController(ILogger<WeatherController> logger, IMediator mediator)
    {
      _mediator = mediator;
      _logger = logger;
    }
    // CodeTemplates

  }
}