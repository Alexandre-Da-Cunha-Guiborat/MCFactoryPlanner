using System;
using System.Collections.Generic;
using MCFP.Common.Enums;
using MCFP.Common.Interfaces;

namespace MCFP.Common.Model;

public class Energy : IEnergy
{
    #region Public

    public EnergyType Type { get; }

    public UInt64 TotalEnergy { get; }

    public Dictionary<string, object> Metadata { get; }

    public Energy(EnergyType type, UInt64 totalEnergy, Dictionary<string, object> metadata)
    {
        Type = type;
        TotalEnergy = totalEnergy;
        Metadata = metadata;
    }

    #endregion Public
}
