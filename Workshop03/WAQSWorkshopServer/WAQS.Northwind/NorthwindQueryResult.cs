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
using WAQSWorkshopServer;
using WAQS.Service.Interfaces;

namespace WAQSWorkshopServer.Service.Interfaces
{
    [DataContract(Namespace = "http://Northwind/QueryResult")]
    [KnownType(typeof(int))]
    [KnownType(typeof(uint))]
    [KnownType(typeof(short))]
    [KnownType(typeof(ushort))]
    [KnownType(typeof(byte))]
    [KnownType(typeof(long))]
    [KnownType(typeof(ulong))]
    [KnownType(typeof(decimal))]
    [KnownType(typeof(double))]
    [KnownType(typeof(char))]
    [KnownType(typeof(DateTime))]
    [KnownType(typeof(DateTimeOffset))]
    [KnownType(typeof(TimeSpan))]
    [KnownType(typeof(int?))]
    [KnownType(typeof(uint?))]
    [KnownType(typeof(short?))]
    [KnownType(typeof(ushort?))]
    [KnownType(typeof(byte?))]
    [KnownType(typeof(long?))]
    [KnownType(typeof(ulong?))]
    [KnownType(typeof(decimal?))]
    [KnownType(typeof(double?))]
    [KnownType(typeof(char?))]
    [KnownType(typeof(DateTime?))]
    [KnownType(typeof(DateTimeOffset?))]
    [KnownType(typeof(TimeSpan?))]
    [KnownType(typeof(string))]
    [KnownType(typeof(int[]))]
    [KnownType(typeof(uint[]))]
    [KnownType(typeof(short[]))]
    [KnownType(typeof(ushort[]))]
    [KnownType(typeof(byte[]))]
    [KnownType(typeof(long[]))]
    [KnownType(typeof(ulong[]))]
    [KnownType(typeof(decimal[]))]
    [KnownType(typeof(double[]))]
    [KnownType(typeof(char[]))]
    [KnownType(typeof(DateTime[]))]
    [KnownType(typeof(DateTimeOffset[]))]
    [KnownType(typeof(TimeSpan[]))]
    [KnownType(typeof(int?[]))]
    [KnownType(typeof(uint?[]))]
    [KnownType(typeof(short?[]))]
    [KnownType(typeof(ushort?[]))]
    [KnownType(typeof(byte?[]))]
    [KnownType(typeof(long?[]))]
    [KnownType(typeof(ulong?[]))]
    [KnownType(typeof(decimal?[]))]
    [KnownType(typeof(double?[]))]
    [KnownType(typeof(char?[]))]
    [KnownType(typeof(DateTime?[]))]
    [KnownType(typeof(DateTimeOffset?[]))]
    [KnownType(typeof(TimeSpan?[]))]
    [KnownType(typeof(string[]))]
    [KnownType(typeof(Category))]
    [KnownType(typeof(Category[]))]
    [KnownType(typeof(Customer))]
    [KnownType(typeof(Customer[]))]
    [KnownType(typeof(Employee))]
    [KnownType(typeof(Employee[]))]
    [KnownType(typeof(Invoice))]
    [KnownType(typeof(Invoice[]))]
    [KnownType(typeof(InvoiceDetail))]
    [KnownType(typeof(InvoiceDetail[]))]
    [KnownType(typeof(Order))]
    [KnownType(typeof(Order[]))]
    [KnownType(typeof(OrderDetail))]
    [KnownType(typeof(OrderDetail[]))]
    [KnownType(typeof(Product))]
    [KnownType(typeof(Product[]))]
    public partial class NorthwindQueryResult : QueryResult
    {
    	[DataMember]
    	public object Values { get; set; }
    
    	[DataMember]
    	public object Value { get; set; }
    }
}
