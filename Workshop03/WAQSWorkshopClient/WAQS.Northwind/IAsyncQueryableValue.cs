//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using System;
using System.Threading.Tasks;

namespace WAQS.ClientContext.Interfaces
{
    public interface IAsyncQueryableValue : IAsyncQueryableBase
    {
    }
    
    public interface IAsyncQueryableValue<T> : IAsyncQueryableValue
    {
        Task<T> ExecuteAsync(MergeOption? mergeOption = null, Func<bool> cancel = null);
    }
}
