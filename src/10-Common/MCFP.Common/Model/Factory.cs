using System;
using System.Collections.Generic;
using MCFP.Common.Interfaces;

public class Factory : IFactory
{
    #region Public

    public String Id { get; }
    public IEnumerable<IFactoryComponent> Components { get; }

    public Factory(String id, IEnumerable<IFactoryComponent> components)
    {
        Id = id;
        Components = components;
    }

    #endregion Public
}
