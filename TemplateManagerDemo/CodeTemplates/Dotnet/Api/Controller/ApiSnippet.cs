
    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<$ReturnedObject$> Get([FromBody] $ContractName$ request)
    {
      return await _mediator.handle(request).ConfigureAwait(false);
    }