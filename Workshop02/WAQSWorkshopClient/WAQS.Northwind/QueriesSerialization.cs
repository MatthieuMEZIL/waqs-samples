//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WAQS.ClientContext.Interfaces.Query
{
    [DataContract(Namespace = "http://WAQS/Query")]
    public class QueriesSerialization
    {
        private List<QuerySerialization> _querySerializations;
        [DataMember]
        public List<QuerySerialization> QuerySerializations 
        { 
            get { return _querySerializations ?? (_querySerializations = new List<QuerySerialization>()); } 
            set { _querySerializations = value; }
        }
    }
}
