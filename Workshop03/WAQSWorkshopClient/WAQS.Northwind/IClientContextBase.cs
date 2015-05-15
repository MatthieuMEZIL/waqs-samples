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
using WAQS.ClientContext.Interfaces.Querying;
using WAQS.ComponentModel;
using WAQS.ClientContext.Interfaces.ExpressionSerialization;

namespace WAQS.ClientContext.Interfaces
{
    public interface IClientContextBase : IDisposable
    {
        string Name { get; }
        Task<IEnumerable<T>> ExecuteQueryAsync<T>(IAsyncQueryable<T> query, MergeOption? mergeOption = null, Func<bool> cancel = null);
        Task<T> ExecuteQueryAsync<T>(IAsyncQueryableValue<T> query, MergeOption? mergeOption = null, Func<bool> cancel = null);
        Task<object[]> ExecuteQueriesAsync(params IAsyncQueryableBase[] queries);
        Task<object[]> ExecuteQueriesAsync(IEnumerable<IAsyncQueryableBase> queries, MergeOption? mergeOption = null, Func<bool> cancel = null);
        Task<QueryPage<T>> LoadPageAsync<T>(int pageSize, IAsyncQueryable<T> query, LoadPageParameter[] identifiers, MergeOption? mergeOption = null, Func<bool> cancel = null);
        IExpressionTransformer GetTransformer();
    	void AddProperty<T>(string name, object value) where T : IBindableObject, IDynamicType;
    	void AddProperty<T, PropertyT>(string name, Func<T, PropertyT> get, Action<T, PropertyT> set = null, string[] properties = null) where T : IBindableObject, IDynamicType;
    }
}
