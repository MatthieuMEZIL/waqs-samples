//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace WAQS.DAL.Interfaces
{
    public interface IAsyncQueryProviderFactory
    {
        Task<object> ExecuteAsync(IQueryProvider queryProvider, Expression expression, CancellationToken cancellationToken = default(CancellationToken));
        Task<T> ExecuteAsync<T>(IQueryProvider queryProvider, Expression expression, CancellationToken cancellationToken = default(CancellationToken));
        IAsyncEnumerableFactory AsyncEnumerableFactory { get; }
    }
}
