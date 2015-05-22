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
using System.Runtime.Serialization;

namespace WAQS.ClientContext.Interfaces.ExpressionSerialization
{
    [DataContract(Namespace = "http://WAQS/QuerySerialization", IsReference = true)]
    public class SerializableLambdaExpression : SerializableExpression
    {
        public SerializableLambdaExpression()
        {
        }
        public SerializableLambdaExpression(List<SerializableParameterExpression> parameters, Type returnType, SerializableExpression body)
            : this(parameters, new SerializableType(returnType), body)
        {
        }
        public SerializableLambdaExpression(List<SerializableParameterExpression> parameters, SerializableType returnType, SerializableExpression body)
        {
            Parameters = parameters;
            ReturnType = returnType;
            Body = body;
        }
        
        [DataMember]
        public List<SerializableParameterExpression> Parameters { get; set; }
        [DataMember]
        public SerializableType ReturnType { get; set; }
        [DataMember]
        public SerializableExpression Body { get; set; }
    
        protected internal override SerializableExpression Visit(SerializableExpressionRewriter rewriter)
        {
            return rewriter.VisitLambda(this);
        }
    }
}
