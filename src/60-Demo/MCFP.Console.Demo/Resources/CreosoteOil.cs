using System;
using MCFP.Common.Enums;
using MCFP.Common.Model;

namespace MCFP.Console.Demo.Resources;

internal class CreosoteOil : Resource
{
    #region Public

    public CreosoteOil() : base(_id, _mod, _displayName, ResourceType.FLUID, false, []) { }

    #endregion Public

    #region Private

    private static ResourceId _id => new ResourceId($"{_mod}_{_displayName}");
    private static String _mod = $"gregtech";
    private static String _displayName = $"{nameof(CreosoteOil)}";

    #endregion Private
}
