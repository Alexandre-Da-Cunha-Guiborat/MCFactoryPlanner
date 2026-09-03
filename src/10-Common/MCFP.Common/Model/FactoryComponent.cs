using System;
using System.Collections.Generic;
using MCFP.Common.Interfaces;

public class FactoryComponent : IFactoryComponent
{
    #region Public

    public String Id { get; }
    public IRecipe Recipe { get; }
    public IEnumerable<FactoryComponent> Inputs { get; }
    public Dictionary<IRecipeOutput, IRecipeInput> InputsToRecipeInputsMapping { get; }
    public IEnumerable<IEnergyGenerator> EnergyGenerators { get; }

    public FactoryComponent(String id, IRecipe recipe, IEnumerable<FactoryComponent> inputs, Dictionary<IRecipeOutput, IRecipeInput> inputsToRecipeInputsMapping, IEnumerable<IEnergyGenerator> energyGenerators)
    {
        Id = id;
        Recipe = recipe;
        Inputs = inputs;
        InputsToRecipeInputsMapping = inputsToRecipeInputsMapping;
        EnergyGenerators = energyGenerators;
    }

    #endregion Public
}
