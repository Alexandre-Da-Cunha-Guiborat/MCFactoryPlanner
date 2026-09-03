using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MCFP.Common.Dtos;

public class ProcessorDto
{
    #region Public

    [JsonPropertyName("Id")]
    public String Id { get; }

    [JsonPropertyName("Mode")]
    public String Mode { get; }

    [JsonPropertyName("Name")]
    public String Name { get; }

    [JsonPropertyName("Metadata")]
    public Dictionary<string, object> Metadata { get; }

    [JsonConstructor]
    public ProcessorDto(String id, String mode, String name, Dictionary<string, object> metadata)
    {
        Id = id;
        Mode = mode;
        Name = name;
        Metadata = metadata;
    }

    #endregion Public
}
