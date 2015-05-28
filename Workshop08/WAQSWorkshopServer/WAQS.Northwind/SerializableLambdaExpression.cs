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

namespace WAQS.SerializableExpressions
{
    [DataContract(Namespace = "http://WAQS/QuerySerialization", IsReference = true)]
    public class SerializableLambdaExpression : SerializableExpression
    {
        [DataMember]
        public List<SerializableParameterExpression> Parameters { get; set; }
        [DataMember]
        public SerializableType ReturnType { get; set; }
        [DataMember]
        public SerializableExpression Body { get; set; }
    
        protected internal override void Visit(SerializableExpressionVisitor visitor)
        {
            visitor.VisitLambda(this);
        }
    }
}
