
    [HttpGet(Name = "GetWeatherForecast")]
    public $ReturnedObject$ Get([FromBody] $ContractName$ request)
    {
      return await _mediator.handle(request).ConfigureAwait(false);
    }