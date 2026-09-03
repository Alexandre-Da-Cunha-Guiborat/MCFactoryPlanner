using System;
using System.Collections.Generic;
using MCFP.Common.Enums;

namespace MCFP.Common.Interfaces;

public interface IResource
{
    #region Public

    public IResourceId Id { get; }

    public String ModId { get; }

    public String DisplayName { get; }

    public ResourceType Type { get; }

    public Boolean IsHidden { get; }

    public Dictionary<string, object> Metadata { get; }

    #endregion Public
}
