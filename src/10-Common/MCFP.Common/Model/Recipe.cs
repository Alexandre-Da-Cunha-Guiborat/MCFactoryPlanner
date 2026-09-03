using System;
using System.Collections.Generic;
using MCFP.Common.Interfaces;

namespace MCFP.Common.Model;

public class Recipe : IRecipe
{
    #region Public

    public IRecipeId Id { get; }

    public IEnumerable<IRecipeInput> Inputs { get; }

    public IEnumerable<IRecipeOutput> Outputs { get; }

    public IRecipeProcess Process { get; }

    public Boolean IsHidden { get; }

    public Dictionary<string, object> Metadata { get; }

    public Recipe(IRecipeId id, IEnumerable<IRecipeInput> inputs, IEnumerable<IRecipeOutput> outputs, IRecipeProcess process, Boolean isHidden, Dictionary<string, object> metadata)
    {
        Id = id;
        Inputs = inputs;
        Outputs = outputs;
        Process = process;
        IsHidden = isHidden;
        Metadata = metadata;
    }

    #endregion Public
}
