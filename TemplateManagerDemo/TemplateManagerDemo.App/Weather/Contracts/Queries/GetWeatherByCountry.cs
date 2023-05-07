namespace TemplateManagerDemo.App.Weather.Contracts.Queries
{
  using System;
  using MediatR;

  /// <summary>
  /// Request to Get Weather By Country
  /// </summary>
  public partial class GetWeatherByCountry : IRequest<CountryWeather>
  {
  }
}
