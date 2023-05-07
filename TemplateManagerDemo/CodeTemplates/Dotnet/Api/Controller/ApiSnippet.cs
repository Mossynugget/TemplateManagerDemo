
    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<$if:ReturnList$List<$endif:ReturnList$$ReturnedObject$$if:ReturnList$>$endif:ReturnList$> Get([FromBody] $ContractName$ request)
    {
      return await _mediator.Send<$if:ReturnList$List <$endif: ReturnList$$ReturnedObject$$if:ReturnList$>$endif: ReturnList$> (request).ConfigureAwait(false);
    }