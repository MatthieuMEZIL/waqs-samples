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

namespace WAQS.ClientContext.Interfaces.ExpressionSerialization
{
    [DataContract(Namespace = "http://WAQS/QuerySerialization", IsReference = true)]
    public class SerializablePropertySetterExpression : SerializableMemberExpression
    {
        public SerializablePropertySetterExpression()
        {
        }
        public SerializablePropertySetterExpression(SerializableExpression source, PropertyInfo property, SerializableExpression value)
            : base(source, property)
        {
            Value = value;
            Property = property;
        }
        
        [DataMember]
        public SerializableExpression Value { get; set; }
        [DataMember]
        public int Type { get; set; }
        public PropertyInfo Property { get; private set; }
    
        protected internal override SerializableExpression Visit(SerializableExpressionRewriter rewriter)
        {
            return rewriter.VisitPropertySetter(this);
        }
    }
}
