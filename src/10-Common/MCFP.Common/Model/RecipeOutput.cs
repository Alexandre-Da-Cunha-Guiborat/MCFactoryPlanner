using System;
using System.Collections.Generic;
using MCFP.Common.Interfaces;

namespace MCFP.Common.Model;

public class RecipeOutput : IRecipeOutput
{
    #region Public

    public IResource Resource { get; }

    public UInt64 Amount { get; }

    public Double Chance { get; }

    public Dictionary<string, object> Metadata { get; }

    public RecipeOutput(IResource resource, UInt64 amount, Double chance, Dictionary<string, object> metadata)
    {
        Resource = resource;
        Amount = amount;
        Chance = chance;
        Metadata = metadata;
    }

    #endregion Public
}
