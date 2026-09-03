using System;
using MCFP.Common.Enums;
using MCFP.Common.Model;

namespace MCFP.Console.Demo.Resources;

internal class Chest : Resource
{
    #region Public

    public Chest() : base(_id, _mod, _displayName, ResourceType.ITEM, false, []) { }

    #endregion Public

    #region Private

    private static ResourceId _id => new ResourceId($"{_mod}_{_displayName}");
    private static String _mod = $"minecraft";
    private static String _displayName = $"{nameof(Chest)}";

    #endregion Private
}
