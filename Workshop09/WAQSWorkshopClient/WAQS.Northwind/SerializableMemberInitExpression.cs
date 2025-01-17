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

namespace WAQS.ClientContext.Interfaces.ExpressionSerialization
{
    [DataContract(Namespace = "http://WAQS/QuerySerialization", IsReference = true)]
    public class SerializableMemberInitExpression : SerializableExpression
    {
        public SerializableMemberInitExpression()
        {
        }
        public SerializableMemberInitExpression(SerializableConstructorExpression constructor, IEnumerable<SerializablePropertySetterExpression> setters)
        {
            Constructor = constructor;
            Setters = setters.ToList();
        }
    
        [DataMember]
        public SerializableConstructorExpression Constructor { get; set; }
        [DataMember]
        public List<SerializablePropertySetterExpression> Setters { get; set; }
    
        protected internal override SerializableExpression Visit(SerializableExpressionRewriter rewriter)
        {
            return rewriter.VisitMemberInit(this);
        }
    }
}
