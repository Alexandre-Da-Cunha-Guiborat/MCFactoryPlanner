using System;
using System.Collections.Generic;
using MCFP.Common.Interfaces;
using MCFP.Console.Demo.Energies;
using MCFP.Console.Demo.Resources;

namespace MCFP.Console.Demo.EnergyGenerator;

internal class EuGenerator : IEnergyGenerator
{
    #region Public

    public IEnumerable<IFactoryComponent> Inputs { get; }

    public EuGenerator(IEnumerable<IFactoryComponent> inputs)
    {
        Inputs = inputs;
    }

    public IEnergy GenerateEnergy(IResource resource, UInt64 amount)
    {
        IEnergy resultUnit;
        if (_resourceIdToGeneratedEnergyMapping.ContainsKey(resource.Id))
        {
            resultUnit = _resourceIdToGeneratedEnergyMapping[resource.Id];
        }
        else
        {
            resultUnit = new EuEnergy(0);
        }

        return new EuEnergy(resultUnit.TotalEnergy * amount);
    }


    #endregion Public

    #region Private

    private static Dictionary<IResourceId, IEnergy> _resourceIdToGeneratedEnergyMapping = new Dictionary<IResourceId, IEnergy> { { new CreosoteOil().Id, new EuEnergy(48000 / 1000) } };

    #endregion Private
}
