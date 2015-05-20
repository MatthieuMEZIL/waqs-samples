//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using System.Linq.Expressions;
using System.Runtime.Serialization;

namespace WAQS.ClientContext.Interfaces.ExpressionSerialization
{
    [DataContract(Namespace = "http://WAQS/QuerySerialization", IsReference = true)]
    public class SerializableParameterExpression : SerializableExpression
    {
        public SerializableParameterExpression()
        {
        }
        public SerializableParameterExpression(ParameterExpression parameter)
        {
            Name = parameter.Name;
            Type = new SerializableType(parameter.Type);
        }
    
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public SerializableType Type { get; set; }
    
        protected internal override SerializableExpression Visit(SerializableExpressionRewriter rewriter)
        {
            return rewriter.VisitParameter(this);
        }
    }
}