//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using System.Reflection;
using System.Runtime.Serialization;

namespace WAQS.SerializableExpressions
{
    [DataContract(Namespace = "http://WAQS/QuerySerialization", IsReference = true)]
    public class SerializablePropertySetterExpression : SerializableMemberExpression
    {
        [DataMember]
        public SerializableExpression Value { get; set; }
        [DataMember]
        public int Type { get; set; }
    
        protected internal override void Visit(SerializableExpressionVisitor visitor)
        {
            visitor.VisitPropertySetter(this);
        }
    }
}