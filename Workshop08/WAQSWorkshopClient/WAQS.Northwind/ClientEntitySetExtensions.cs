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
using System.Linq;
using WAQS.EntitiesTracking;
using WAQS.ClientContext.Interfaces.ExpressionSerialization;
using WAQS.ClientContext.Interfaces;
using System.Collections.Concurrent;

namespace WAQS.ClientContext
{
    public static partial class ClientEntitySetExtensions
    {
        public static IAsyncQueryable<TSource> AsAsyncQueryable<TContext, TSource>(this IClientEntitySet<TContext, TSource> entitySet)
            where TContext : class, IClientContext
            where TSource : IObjectWithChangeTracker
        {
            return AsAsyncQueryable(entitySet, ParameterMode.OnDefinition);
        }
        public static IAsyncQueryable<TSource> AsAsyncQueryable<TContext, TSource>(this IClientEntitySet<TContext, TSource> entitySet, ParameterMode parameterMode)
            where TContext : class, IClientContext
            where TSource : IObjectWithChangeTracker
        {
            return new AsyncQueryable<TSource>(entitySet.Context, entitySet.Expression, parameterMode);
        }
    
        private static ConcurrentDictionary<Type, ConcurrentDictionary<Guid, WeakReference>> _entitySetPerEntity = new ConcurrentDictionary<Type, ConcurrentDictionary<Guid, WeakReference>>();
            
        public static bool AddEntityInDico(IClientEntitySet entitySet, IObjectWithChangeTracker entity)
        {
            if (entity == null)
                return false;
            ConcurrentDictionary<Guid, WeakReference> entitySetPerEntityForEntityType;
            var entityType = entity.GetType();
            if (!_entitySetPerEntity.TryGetValue(entityType, out entitySetPerEntityForEntityType))
            {
                entitySetPerEntityForEntityType = new ConcurrentDictionary<Guid, WeakReference>();
                entitySetPerEntityForEntityType.TryAdd(entity.UniqueIdentifier, new WeakReference(entitySet));
                _entitySetPerEntity.TryAdd(entityType, entitySetPerEntityForEntityType);
                return true;
            }
            WeakReference entitySetInDico = null;
            if (entitySetPerEntityForEntityType.TryGetValue(entity.UniqueIdentifier, out entitySetInDico))
            {
                if (!entitySetInDico.IsAlive)
                {
                    WeakReference _;
                    entitySetPerEntityForEntityType.TryRemove(entity.UniqueIdentifier, out _);
                }
                else
                {
                    if (entitySetInDico.Target != entitySet)
                        throw new InvalidOperationException("An entity can be attached only on one context");
                    return false;
                }
            }
            entitySetPerEntityForEntityType.TryAdd(entity.UniqueIdentifier, new WeakReference(entitySet));
            return true;
        }
            
        public static IClientEntitySet GetClientEntitySet(IObjectWithChangeTracker entity)
        {
            ConcurrentDictionary<Guid, WeakReference> entitySetPerEntityForEntityType;
            if (!_entitySetPerEntity.TryGetValue(entity.GetType(), out entitySetPerEntityForEntityType))
                return null;
            WeakReference value = null;
            if (entitySetPerEntityForEntityType.TryGetValue(entity.UniqueIdentifier, out value) && value.IsAlive)
                return (IClientEntitySet)value.Target;
            return null;
        }
            
        public static void RemoveEntityInDico(IObjectWithChangeTracker entity)
        {
            ConcurrentDictionary<Guid, WeakReference> entitySetPerEntityForEntityType;
            if (!_entitySetPerEntity.TryGetValue(entity.GetType(), out entitySetPerEntityForEntityType))
                return;
            WeakReference _;
            entitySetPerEntityForEntityType.TryRemove(entity.UniqueIdentifier, out _);
        }
            
        public static void ClearDico(IClientContext context)
        {
            foreach (var entitySetPerEntityForEntityType in _entitySetPerEntity.Values)
    		{
                foreach (var e in entitySetPerEntityForEntityType.Where(kv => !kv.Value.IsAlive || ((IClientEntitySet)kv.Value.Target).Context == context).Select(kv => kv.Key))
                {
                    WeakReference _;
                    entitySetPerEntityForEntityType.TryRemove(e, out _);
                }
    		}
        }
        
        public static bool Contains<ClientContext, EntityType>(ClientEntitySet<ClientContext, EntityType> entitySet, EntityType entity)
            where ClientContext : class, IClientContext
            where EntityType : class, IObjectWithChangeTracker
        {
            return entitySet.EntitiesContains(entity);
        }
    }
}