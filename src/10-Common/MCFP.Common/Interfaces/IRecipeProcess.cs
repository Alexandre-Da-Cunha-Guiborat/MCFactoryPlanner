using System;
using System.Collections.Generic;

namespace MCFP.Common.Interfaces;

public interface IRecipeProcess
{
    #region Public

    public IProcessor Processor { get; }

    public UInt64 TickDuration { get; }

    public IEnergy EnergyConsumption { get; }

    public Dictionary<string, object> Metadata { get; }

    #endregion Public
}
