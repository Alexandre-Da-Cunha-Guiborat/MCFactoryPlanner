using System;
using System.Collections.Generic;
using MCFP.Common.Model;

namespace MCFP.Console.Demo.Processors;

internal class BenderLV : Processor
{
    #region Public

    public BenderLV() : base(_id, _modId, _displayName, new Dictionary<string, object> { { "MachineTier", "LV" } }) { }

    #endregion Public

    #region Private

    private static String _id => $"{_modId}_{_displayName}";
    private static String _modId = $"gregtech";
    private static String _displayName = $"{nameof(BenderLV)}";

    #endregion Private
}
