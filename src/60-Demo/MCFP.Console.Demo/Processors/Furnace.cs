using System;
using MCFP.Common.Model;

namespace MCFP.Console.Demo.Processors;

internal class Furnace : Processor
{
    #region Public

    public Furnace() : base(_id, _modId, _displayName, []) { }

    #endregion Public

    #region Private

    private static String _id => $"{_modId}_{_displayName}";
    private static String _modId = $"minecraft";
    private static String _displayName = $"{nameof(Furnace)}";

    #endregion Private
}
