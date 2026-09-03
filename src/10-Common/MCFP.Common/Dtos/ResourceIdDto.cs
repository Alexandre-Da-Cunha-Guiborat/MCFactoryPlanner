using System;
using System.Text.Json.Serialization;

namespace MCFP.Common.Dtos;

public class ResourceIdDto
{
    #region Public

    [JsonPropertyName("Id")]
    public String Id { get; }

    [JsonConstructor]
    public ResourceIdDto(String id)
    {
        Id = id;
    }

    #endregion Public
}
