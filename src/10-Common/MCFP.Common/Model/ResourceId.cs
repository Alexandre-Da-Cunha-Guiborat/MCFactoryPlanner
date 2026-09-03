using System;
using MCFP.Common.Interfaces;

namespace MCFP.Common.Model;

public class ResourceId : IResourceId
{
    #region Public

    public String Id { get; }

    public ResourceId(String id)
    {
        Id = id;
    }

    public override string ToString()
    {
        return Id;
    }

    #endregion Public
}
