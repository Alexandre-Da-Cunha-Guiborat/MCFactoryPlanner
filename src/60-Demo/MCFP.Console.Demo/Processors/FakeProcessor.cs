using System;
using MCFP.Common.Model;

namespace MCFP.Console.Demo.Processors;

internal class FakeProcessor : Processor
{
    #region Public

    public FakeProcessor() : base(_id, _modId, _displayName, []) { }

    #endregion Public

    #region Private

    private static String _id => $"{_modId}_{_displayName}";
    private static String _modId = $"fake";
    private static String _displayName = $"{nameof(FakeProcessor)}";

    #endregion Private
}
