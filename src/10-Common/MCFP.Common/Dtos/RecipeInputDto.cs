using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MCFP.Common.Dtos;

public class RecipeInputDto
{
    #region Public

    [JsonPropertyName("Resource")]
    public ResourceDto Resource { get; }

    [JsonPropertyName("Amount")]
    public UInt64 Amount { get; }

    [JsonPropertyName("Chance")]
    public Double Chance { get; }

    [JsonPropertyName("Metadata")]
    public Dictionary<string, object> Metadata { get; }

    [JsonConstructor]
    public RecipeInputDto(ResourceDto resource, UInt64 amount, Double chance, Dictionary<string, object> metadata)
    {
        Resource = resource;
        Amount = amount;
        Chance = chance;
        Metadata = metadata;
    }

    #endregion Public
}
