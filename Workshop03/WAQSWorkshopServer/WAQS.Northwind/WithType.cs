//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace WAQS.DAL.Interfaces
{
    public class WithType
    {
        public Type Type { get; set; }
        public Func<object, object> TransformToOriginalType { get; set; }
    }
}
