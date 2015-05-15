//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using WAQS.DAL.Interfaces;

namespace WAQS.DAL
{
    public class EFAsyncEnumerableFactory : IAsyncEnumerableFactory
    {
        public IAsyncEnumerable GetAsyncEnumerable(IQueryable query)
        {
            var dbAsyncEnumerable = query as IDbAsyncEnumerable;
            if (dbAsyncEnumerable == null)
                throw new InvalidOperationException();
            return new AsyncEnumerable(new EFAsyncEnumerator(dbAsyncEnumerable.GetAsyncEnumerator()));
        }
    
        public IAsyncEnumerable<T> GetAsyncEnumerable<T>(IQueryable<T> query)
        {
            var dbAsyncEnumerable = query as IDbAsyncEnumerable<T>;
            if (dbAsyncEnumerable == null)
                throw new InvalidOperationException();
            return new AsyncEnumerable<T>(new EFAsyncEnumerator<T>(dbAsyncEnumerable.GetAsyncEnumerator()));
        }	
    }
}
