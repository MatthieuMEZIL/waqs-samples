//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace WAQS.ClientContext.Interfaces.ExpressionSerialization
{
    [DataContract(Namespace = "http://WAQS/QuerySerialization", IsReference = true)]
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
    [KnownType(typeof(DateTimeOffset?[]))]
    [KnownType(typeof(DateTime?[]))]
    [KnownType(typeof(TimeSpan?[]))]
    [KnownType(typeof(string[]))]
    public class SerializableConstantExpression : SerializableExpression
    {
        public SerializableConstantExpression()
        {
        }
        public SerializableConstantExpression(object value, Type type)
        {
            Value = value;
            Type = new SerializableType(type);
        }
        public SerializableConstantExpression(Delegate @delegate, Type type)
        {
            Delegate = @delegate;
            Type = new SerializableType(type);
        }
    
        public Delegate Delegate { get; set; }
    
        private object _value;
        [DataMember]
        public object Value 
        {
            get
            {
                if (Delegate != null)
                    _value = Delegate.DynamicInvoke();
                if (_value is Enum)
                    _value = (int)_value;
                if (!(_value is IEnumerable) || _value is string)
                    return _value;
                var enumerable = _value.GetType().GetInterfaces().FirstOrDefault(f => f.IsGenericType && f.GetGenericTypeDefinition() == typeof(IEnumerable<>));
                if (enumerable == null)
                    throw new NotImplementedException();
                return typeof(Enumerable).GetMethod("ToArray").MakeGenericMethod(enumerable.GetGenericArguments()[0]).Invoke(null, new object[] { _value });
            }
            set { _value = value; } 
        }
        [DataMember]
        public SerializableType Type { get; set; }
    
        protected internal override SerializableExpression Visit(SerializableExpressionRewriter rewriter)
        {
            return rewriter.VisitConstant(this);
        }
    }
}
