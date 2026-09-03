using System;
using MCFP.Common.Enums;
using MCFP.Common.Model;

namespace MCFP.Console.Demo.Resources;

internal class IronPlate : Resource
{
    #region Public

    public IronPlate() : base(_id, _mod, _displayName, ResourceType.ITEM, false, []) { }

    #endregion Public

    #region Private

    private static ResourceId _id => new ResourceId($"{_mod}_{_displayName}");
    private static String _mod = $"gregtech";
    private static String _displayName = $"{nameof(IronPlate)}";

    #endregion Private
}
