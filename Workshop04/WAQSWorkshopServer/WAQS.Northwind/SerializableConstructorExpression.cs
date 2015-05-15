//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace WAQS.SerializableExpressions
{
    [DataContract(Namespace = "http://WAQS/QuerySerialization", IsReference = true)]
    public class SerializableConstructorExpression : SerializableExpression
    {
        [DataMember]
        public SerializableType Type { get; set; }
        [DataMember]
        public List<SerializableType> ArgumentTypes { get; set; }
        [DataMember]
        public List<SerializableExpression> Arguments { get; set; }
    
        protected internal override void Visit(SerializableExpressionVisitor visitor)
        {
            visitor.VisitConstructor(this);
        }
    }
}
