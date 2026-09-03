using System;
using MCFP.Common.Enums;
using MCFP.Common.Model;

namespace MCFP.Console.Demo.Resources;

internal class IronIngot : Resource
{
    #region Public

    public IronIngot() : base(_id, _mod, _displayName, ResourceType.ITEM, false, []) { }

    #endregion Public

    #region Private

    private static ResourceId _id => new ResourceId($"{_mod}_{_displayName}");
    private static String _mod = $"minecraft";
    private static String _displayName = $"{nameof(IronIngot)}";

    #endregion Private
}
