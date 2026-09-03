using System;
using System.Collections.Generic;

namespace MCFP.Common.Interfaces;

public interface IEnergyGenerator
{
    #region Public

    public IEnumerable<IFactoryComponent> Inputs { get; }

    public IEnergy GenerateEnergy(IResource resource, UInt64 amount);

    #endregion Public
}
