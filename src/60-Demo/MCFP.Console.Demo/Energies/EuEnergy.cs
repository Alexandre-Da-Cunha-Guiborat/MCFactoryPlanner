using System;
using MCFP.Common.Enums;
using MCFP.Common.Model;

namespace MCFP.Console.Demo.Energies;

internal class EuEnergy : Energy
{
    #region Public

    public EuEnergy(UInt64 totalEnergy) : base(EnergyType.EU, totalEnergy, []) { }

    #endregion Public
}
