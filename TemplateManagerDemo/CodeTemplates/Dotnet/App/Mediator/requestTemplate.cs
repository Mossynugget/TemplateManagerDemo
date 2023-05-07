namespace $setting:namespace$
{
  using System;
  using MediatR;
  using $setting:solution$.Data.Models.Dtos;$if:ReturnList$
  using System.Collections.Generic;$endif:ReturnList$

  /// <summary>
  /// Request to $ContractName:comment$
  /// </summary>
  public partial class $ContractName$ : IRequest<$if:ReturnList$List<$endif:ReturnList$$ReturnedObject$$if:ReturnList$>$endif:ReturnList$>
  {
  }
}
