//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using System.Runtime.Serialization;

namespace WAQS.WCFService.Contract
{
    [DataContract(Namespace = "http://WAQS/Fault")]
    public partial class FaultDetail
    {
    	[DataMember]
    	public string ErrorType { get; set; }
    
    	[DataMember]
    	public string ErrorMessage { get; set; }
    }
}
