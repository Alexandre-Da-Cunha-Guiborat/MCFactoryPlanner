using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MCFP.Common.Dtos;

public class RecipeProcessDto
{
    #region Public

    [JsonPropertyName("Processor")]
    public ProcessorDto Processor { get; }

    [JsonPropertyName("TickDuration")]
    public UInt64 TickDuration { get; }

    [JsonPropertyName("EnergyConsumption")]
    public EnergyDto EnergyConsumption { get; }

    [JsonPropertyName("Metadata")]
    public Dictionary<string, object> Metadata { get; }

    [JsonConstructor]
    public RecipeProcessDto(ProcessorDto processor, UInt64 tickDuration, EnergyDto energyConsumption, Dictionary<string, object> metadata)
    {
        Processor = processor;
        TickDuration = tickDuration;
        EnergyConsumption = energyConsumption;
        Metadata = metadata;
    }

    #endregion Public
}
