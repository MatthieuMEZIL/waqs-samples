//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using System.Runtime.Serialization;
using WAQS.SerializableExpressions;

namespace WAQS.Service.Interfaces
{
    [DataContract(Namespace = "http://WAQS/Query")]
    public class QuerySerialization
    {
    	[DataMember]
    	public SerializableExpression Expression { get; set; }
    
    	[DataMember]
    	public SerializableType SerializableType { get; set; }
    	
    	[DataMember]
    	public string[] WithSpecificationsProperties { get; set; }
    }
}
