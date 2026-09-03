using System;
using System.Collections.Generic;

namespace MCFP.Common.Interfaces;

public interface IRecipeInput
{
    #region Public

    public IResource Resource { get; }

    public UInt64 Amount { get; }

    public Dictionary<string, object> Metadata { get; }

    public Double Chance { get; }

    #endregion Public
}
