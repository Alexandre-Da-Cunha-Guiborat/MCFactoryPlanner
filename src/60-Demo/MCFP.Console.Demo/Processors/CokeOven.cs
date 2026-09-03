using System;
using MCFP.Common.Model;

namespace MCFP.Console.Demo.Processors;

internal class CokeOven : Processor
{
    #region Public

    public CokeOven() : base(_id, _modId, _displayName, []) { }

    #endregion Public

    #region Private

    private static String _id => $"{_modId}_{_displayName}";
    private static String _modId = $"gregtech";
    private static String _displayName = $"{nameof(CokeOven)}";

    #endregion Private
}
