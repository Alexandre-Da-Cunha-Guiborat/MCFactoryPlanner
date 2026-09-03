using System;
using System.Collections.Generic;

namespace MCFP.Common.Interfaces;

public interface IRecipe
{
    #region Public

    public IRecipeId Id { get; }

    public IEnumerable<IRecipeInput> Inputs { get; }

    public IEnumerable<IRecipeOutput> Outputs { get; }

    public IRecipeProcess Process { get; }

    public Boolean IsHidden { get; }

    public Dictionary<string, object> Metadata { get; }

    #endregion Public
}
