using System;
using System.Collections.Generic;

namespace MCFP.Common.Interfaces;

public interface IFactoryComponent
{
    #region Public

    public String Id { get; }
    public IRecipe Recipe { get; }
    public IEnumerable<FactoryComponent> Inputs { get; }
    public Dictionary<IRecipeOutput, IRecipeInput> InputsToRecipeInputsMapping { get; }
    public IEnumerable<IEnergyGenerator> EnergyGenerators { get; }

    #endregion Public
}
