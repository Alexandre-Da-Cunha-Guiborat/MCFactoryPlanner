using System;
using System.Collections.Generic;
using MCFP.Common.Interfaces;

namespace MCFP.Common.Model;

public class RecipeProcess : IRecipeProcess
{
    #region Public

    public IProcessor Processor { get; }

    public UInt64 TickDuration { get; }

    public IEnergy EnergyConsumption { get; }

    public Dictionary<string, object> Metadata { get; }

    public RecipeProcess(IProcessor processor, UInt64 tickDuration, IEnergy energyConsumption, Dictionary<string, object> metadata)
    {
        Processor = processor;
        TickDuration = tickDuration;
        EnergyConsumption = energyConsumption;
        Metadata = metadata;
    }

    #endregion Public
}
