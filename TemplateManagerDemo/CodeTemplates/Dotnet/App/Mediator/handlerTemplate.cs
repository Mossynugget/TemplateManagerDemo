namespace $setting:namespace$
{
  using System.Threading;
  using System.Threading.Tasks;$if:ReturnList$
  using System.Collections.Generic;$endif:ReturnList$
  using MediatR;
  using $setting:projectName$.$Domain$.Contracts.$RequestTypePlural$;
  using $setting:solution$.Data.Models.Dtos;

  /// <summary>
  /// The $ContractName:comment$ handler.
  /// </summary>
  public class $ContractName$Handler : IRequestHandler<$ContractName$, $if:ReturnList$List<$endif:ReturnList$$ReturnedObject$$if:ReturnList$>$endif:ReturnList$>
  {
    private readonly I$Domain$Repository _repository;

    /// <summary>
    /// Initializes a new instance of the <see cref="$ContractName$Handler"/> class.
    /// </summary>
    /// <param name="I$Domain$Repository">The $Domain:comment$ repository.</param>
    public $ContractName$Handler(I$Domain$Repository repository)
    {
      _repository = repository;
    }

    /// <inheritdoc/>
    public async Task<$if:ReturnList$List<$endif:ReturnList$$ReturnedObject$$if:ReturnList$>$endif:ReturnList$> Handle($ContractName$ request, CancellationToken cancellationToken)
    {
      return await _repository.$ContractName$().ConfigureAwait(false);
    }
  }
}
