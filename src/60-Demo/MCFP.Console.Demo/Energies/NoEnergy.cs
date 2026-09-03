using MCFP.Common.Enums;
using MCFP.Common.Model;

namespace MCFP.Console.Demo.Energies;

internal class NoEnergy : Energy
{
    #region Public

    public NoEnergy() : base(EnergyType.EnergyType_NONE, 0, []) { }

    #endregion Public
}
