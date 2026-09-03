using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using MCFP.Common.Enums;

namespace MCFP.Common.Dtos;

public class EnergyDto
{
    #region Public

    [JsonPropertyName("Type")]
    public EnergyType Type { get; }

    [JsonPropertyName("TotalEnergy")]
    public UInt64 TotalEnergy { get; }

    [JsonPropertyName("Metadata")]
    public Dictionary<string, object> Metadata { get; }

    [JsonConstructor]
    public EnergyDto(EnergyType type, UInt64 totalEnergy, Dictionary<string, object> metadata)
    {
        Type = type;
        TotalEnergy = totalEnergy;
        Metadata = metadata;
    }

    #endregion Public
}
