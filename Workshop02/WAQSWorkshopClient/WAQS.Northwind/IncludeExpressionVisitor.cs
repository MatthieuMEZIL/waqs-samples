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
using System.Linq.Expressions;
using System.Reflection;
using WAQS.EntitiesTracking;
using WAQS.ClientContext.Interfaces;

namespace WAQS.ClientContext
{
    public class IncludeExpressionVisitor<QueryType> : ExpressionVisitor
    {
        private List<Func<IAsyncQueryableBase, QueryType>> _includeActions = new List<Func<IAsyncQueryableBase, QueryType>>();
            
        public IEnumerable<Func<IAsyncQueryableBase, QueryType>> IncludeActions
        {
            get { return _includeActions; }
        }
            
        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            if (node.Method.GetCustomAttributes(false).OfType<IncludeMethodAttribute>().Any())
            {
                MethodInfo method = node.Method;
                List<Expression> parameters = null;
                var queryParameter = Expression.Parameter(typeof(IAsyncQueryableBase), "p" + Guid.NewGuid().ToString());
    
                var includeMethod = method.DeclaringType.GetMethods(BindingFlags.Public | BindingFlags.Static).FirstOrDefault(m =>
                    {
                        var parametersLoop = new List<Expression>();
                        if (m.Name != method.Name)
                            return false;
                        var methodParametersEnumerator = method.GetParameters().Cast<ParameterInfo>().GetEnumerator();
                        var mParametersEnumerator = m.GetParameters().Cast<ParameterInfo>().GetEnumerator();
                        var nodeArgumentsEnumerator = node.Arguments.GetEnumerator();
                        int parameterIndex = 0;
                        while (methodParametersEnumerator.MoveNext())
                        {
                            nodeArgumentsEnumerator.MoveNext();
                            if (!mParametersEnumerator.MoveNext())
                                return false;
                            var methodParameterType = methodParametersEnumerator.Current.ParameterType;
                            var mParameterType = mParametersEnumerator.Current.ParameterType;
                            if (parameterIndex == 0)
                            {
                                parameterIndex++;
                                if (methodParameterType.IsGenericType && methodParameterType.GetGenericTypeDefinition() == typeof(IEnumerable<>) || !methodParameterType.IsGenericType && typeof(IEntity).IsAssignableFrom(methodParameterType))
                                {
                                    if (mParameterType == typeof(QueryType))
                                        parametersLoop.Add(Expression.Convert(queryParameter, typeof(QueryType)));
                                    else
                                        return false;
                                }
                                else
                                    return false;
                            }
                            else if (methodParameterType == mParameterType)
                                parametersLoop.Add(nodeArgumentsEnumerator.Current);
                            else
                                return false;
                        }
                        if (mParametersEnumerator.MoveNext())
                            return false;
                        parameters = parametersLoop;
                        return true;
                    });
    
                if (includeMethod == null)
                {
                    if (typeof(IAsyncQueryableValue).IsAssignableFrom(typeof(QueryType)))
                        throw new NotImplementedException("Not implemented yet. Use Take(1) instead of First or Single");
                    throw new NotImplementedException();
                }
            
                _includeActions.Add(Expression.Lambda<Func<IAsyncQueryableBase, QueryType>>(
                    Expression.Call(includeMethod, parameters), queryParameter).Compile());
                return Visit(node.Arguments[0]);
            }
            return base.VisitMethodCall(node);
        }
    }
}
