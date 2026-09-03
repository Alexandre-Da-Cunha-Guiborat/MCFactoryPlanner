using System;
using MCFP.Common.Interfaces;

namespace MCFP.Common.Model;

public class RecipeId : IRecipeId
{
    #region Public

    public String Id { get; }

    public String ModId { get; }

    public String DisplayName { get; }

    public RecipeId(String id, String modId, String displayName)
    {
        Id = id;
        ModId = modId;
        DisplayName = displayName;
    }

    #endregion Public
}
