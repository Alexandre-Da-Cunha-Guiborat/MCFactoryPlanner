using System;
using System.Collections.Generic;
using MCFP.Common.Enums;
using MCFP.Common.Interfaces;

namespace MCFP.Common.Model;

public class Resource : IResource
{
    #region Public

    public IResourceId Id { get; }

    public String ModId { get; }

    public String DisplayName { get; }

    public ResourceType Type { get; }

    public Boolean IsHidden { get; }

    public Dictionary<string, object> Metadata { get; }

    public Resource(IResourceId id, String modId, String displayName, ResourceType type, Boolean isHidden, Dictionary<string, object> metadata)
    {
        Id = id;
        ModId = modId;
        DisplayName = displayName;
        Type = type;
        IsHidden = isHidden;
        Metadata = metadata;
    }

    #endregion Public
}
