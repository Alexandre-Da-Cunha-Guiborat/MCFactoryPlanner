using System;
using MCFP.Common.Enums;
using MCFP.Common.Model;

namespace MCFP.Console.Demo.Energies;

internal class FuelEnergy : Energy
{
    #region Public

    public FuelEnergy(UInt64 totalEnergy) : base(EnergyType.FUEL, totalEnergy, []) { }

    #endregion Public
}
