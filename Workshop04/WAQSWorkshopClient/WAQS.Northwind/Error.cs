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
using WAQS.ComponentModel;

namespace WAQS.ClientContext.Interfaces.Errors
{
    [DataContract(Namespace = "http://WAQS/Errors")]
    public partial class Error
    {
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public Criticity Criticity { get; set; }
        [DataMember]
        public string Key { get; set; }
        [DataMember]
        public ErrorDetail[] ErrorDetails { get; set; }
    
        public ErrorInfo ErrorInfo { get; set; }
    
        private ErrorSource _source = ErrorSource.FromClient;
        public ErrorSource Source
        {
            get { return _source; }
            private set { _source = value; }
        }
        [OnDeserializing]
        public void OnDeserializingMethod(StreamingContext context)
        {
            Source = ErrorSource.FromServer;
        }
    }
}
