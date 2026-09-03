using System;

namespace MCFP.Common.Interfaces;

public interface IRecipeId
{
    #region Public

    public String Id { get; }

    public String ModId { get; }

    public String DisplayName { get; }

    #endregion Public
}
