using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MCFP.Common.Dtos;

public class RecipeDto
{
    #region Public

    [JsonPropertyName("Id")]
    public RecipeIdDto Id { get; }

    [JsonPropertyName("Inputs")]
    public List<RecipeInputDto> Inputs { get; }

    [JsonPropertyName("Outputs")]
    public List<RecipeOutputDto> Outputs { get; }

    [JsonPropertyName("Process")]
    public RecipeProcessDto Process { get; }

    [JsonPropertyName("IsHidden")]
    public Boolean IsHidden { get; }

    [JsonPropertyName("Metadata")]
    public Dictionary<string, object> Metadata { get; }

    [JsonConstructor]
    public RecipeDto(RecipeIdDto id, List<RecipeInputDto> inputs, List<RecipeOutputDto> outputs, RecipeProcessDto process, Boolean isHidden, Dictionary<string, object> metadata)
    {
        Id = id;
        Inputs = inputs;
        Outputs = outputs;
        Process = process;
        IsHidden = isHidden;
        Metadata = metadata;
    }

    #endregion Public
}
