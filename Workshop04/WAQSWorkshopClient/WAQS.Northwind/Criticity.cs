//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using System;
using System.Runtime.Serialization;

namespace WAQS.ClientContext.Interfaces.Errors
{
    [DataContract(Namespace = "http://WAQS/Errors")]
    [Flags]
    public enum Criticity
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Information = 1,
        [EnumMember]
        Warning = 2,
        [EnumMember]
        Error = 8,
        [EnumMember]
        Mandatory = 12
    }
}
