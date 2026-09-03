using System;
using System.Collections.Generic;

namespace MCFP.Common.Interfaces;

public interface IFactory
{
    #region Public

    public String Id { get; }

    public IEnumerable<IFactoryComponent> Components { get; }

    #endregion Public
}
