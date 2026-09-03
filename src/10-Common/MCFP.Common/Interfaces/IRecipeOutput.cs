using System;
using System.Collections.Generic;

namespace MCFP.Common.Interfaces;

public interface IRecipeOutput
{
    #region Public

    public IResource Resource { get; }

    public UInt64 Amount { get; }

    public Double Chance { get; }

    public Dictionary<string, object> Metadata { get; }

    #endregion Public
}
