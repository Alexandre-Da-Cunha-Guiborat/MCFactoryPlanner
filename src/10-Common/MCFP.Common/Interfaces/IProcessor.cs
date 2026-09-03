using System;
using System.Collections.Generic;

namespace MCFP.Common.Interfaces;

public interface IProcessor
{
    #region Public

    public String Id { get; }

    public String Mode { get; }

    public String Name { get; }

    public Dictionary<string, object> Metadata { get; }

    #endregion Public
}
