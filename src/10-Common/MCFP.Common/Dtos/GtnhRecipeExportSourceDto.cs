using System;
using System.Text.Json.Serialization;

namespace MCFP.Common.Dtos;

public class GtnhRecipeExportSourceDto
{
    #region Public

    [JsonPropertyName("Game")]
    public String Game { get; }

    [JsonPropertyName("MinecraftVersion")]
    public String MinecraftVersion { get; }

    [JsonPropertyName("Modpack")]
    public String Modpack { get; }

    [JsonPropertyName("ModpackVersion")]
    public String ModpackVersion { get; }

    [JsonPropertyName("GT5UnofficialVersion")]
    public String GT5UnofficialVersion { get; }

    [JsonPropertyName("Exporter")]
    public String Exporter { get; }

    [JsonPropertyName("ExporterVersion")]
    public String ExporterVersion { get; }

    [JsonConstructor]
    public GtnhRecipeExportSourceDto(String game, String minecraftVersion, String modpack, String modpackVersion, String gt5UnofficialVersion, String exporter, String exporterVersion)
    {
        Game = game;
        MinecraftVersion = minecraftVersion;
        Modpack = modpack;
        ModpackVersion = modpackVersion;
        GT5UnofficialVersion = gt5UnofficialVersion;
        Exporter = exporter;
        ExporterVersion = exporterVersion;
    }

    #endregion Public
}
