//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using System.Runtime.Serialization;

namespace WAQSWorkshopClient.ClientContext.QueryResult
{
    [DataContract(Namespace = "http://Northwind/QueryResult")]
    public class NorthwindQueriesResult
    {
        [DataMember]
        public NorthwindQueryResult[] QueryResults { get; set; }
    }
}