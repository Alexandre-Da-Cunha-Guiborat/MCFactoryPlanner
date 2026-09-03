using System;
using System.Text.Json.Serialization;

namespace MCFP.Common.Dtos;

public class RecipeIdDto
{
    #region Public

    [JsonPropertyName("Id")]
    public String Id { get; }

    [JsonPropertyName("ModId")]
    public String ModId { get; }

    [JsonPropertyName("DisplayName")]
    public String DisplayName { get; }

    [JsonConstructor]
    public RecipeIdDto(String id, String modId, String displayName)
    {
        Id = id;
        ModId = modId;
        DisplayName = displayName;
    }

    #endregion Public
}
