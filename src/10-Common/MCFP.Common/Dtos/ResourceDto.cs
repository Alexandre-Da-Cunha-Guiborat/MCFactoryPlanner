using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using MCFP.Common.Enums;
using MCFP.Common.Model;

namespace MCFP.Common.Dtos;

public class ResourceDto
{
    #region Public

    [JsonPropertyName("Id")]
    public ResourceId Id { get; }

    [JsonPropertyName("ModId")]
    public String ModId { get; }

    [JsonPropertyName("DisplayName")]
    public String DisplayName { get; }

    [JsonPropertyName("Type")]
    public ResourceType Type { get; }

    [JsonPropertyName("IsHidden")]
    public Boolean IsHidden { get; }

    [JsonPropertyName("Metadata")]
    public Dictionary<string, object> Metadata { get; }

    [JsonConstructor]
    public ResourceDto(ResourceId id, String modId, String displayName, ResourceType type, Boolean isHidden, Dictionary<string, object> metadata)
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
