using System;
using System.Collections.Generic;
using MCFP.Common.Interfaces;

namespace MCFP.Common.Model;

public class Processor : IProcessor
{
    #region Public

    public String Id { get; }

    public String Mode { get; }

    public String Name { get; }

    public Dictionary<string, object> Metadata { get; }

    public Processor(String id, String mode, String name, Dictionary<string, object> metadata)
    {
        Id = id;
        Mode = mode;
        Name = name;
        Metadata = metadata;
    }

    #endregion Public
}
