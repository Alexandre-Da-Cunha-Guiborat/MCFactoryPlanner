using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MCFP.Common.Dtos;

public class GtnhRecipeExportDto
{
    #region Public

    [JsonPropertyName("FormatVersion")]
    public String FormatVersion { get; }

    [JsonPropertyName("Source")]
    public GtnhRecipeExportSourceDto Source { get; }

    [JsonPropertyName("Recipes")]
    public List<RecipeDto> Recipes { get; }

    [JsonConstructor]
    public GtnhRecipeExportDto(String formatVersion, GtnhRecipeExportSourceDto source, List<RecipeDto> recipes)
    {
        FormatVersion = formatVersion;
        Source = source;
        Recipes = recipes;
    }

    #endregion Public
}
