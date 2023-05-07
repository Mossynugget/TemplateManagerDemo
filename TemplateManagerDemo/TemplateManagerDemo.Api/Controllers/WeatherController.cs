using MediatR;
using Microsoft.AspNetCore.Mvc;
using TemplateManagerDemo.App.Weather.Contracts.Queries;
using TemplateManagerDemo.Data.Models.Dtos;

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

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<List<CountryWeatherDto>> Get([FromBody] GetWeatherByCountry request)
    {
      return await _mediator.Send(request).ConfigureAwait(false);
    }
  }
}