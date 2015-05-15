//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WAQS.ClientContext.Interfaces.ExpressionSerialization;

namespace WAQS.ClientContext.Interfaces
{
    public interface IAsyncQueryableBase
    {
        IClientContextBase Context { get; }
        ParameterMode ParameterMode { get; }
        SerializableExpression Expression { get; }
        Type Type { get; }
        IEnumerable<Func<IAsyncQueryableBase, AsyncQueryableInclude>> Includes { get; }
        IEnumerable<string> WithSpecificationsProperties { get; }
        IEnumerable<string> SelectedProperties { get; }
    }
}
