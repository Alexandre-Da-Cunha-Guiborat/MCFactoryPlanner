using System;
using System.Collections.Generic;
using MCFP.Common.Enums;

namespace MCFP.Common.Interfaces;

public interface IEnergy
{
    #region Public

    public EnergyType Type { get; }

    public UInt64 TotalEnergy { get; }

    public Dictionary<string, object> Metadata { get; }

    #endregion Public
}
