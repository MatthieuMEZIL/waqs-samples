//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using System;
using System.Linq;
using System.Linq.Expressions;
using WAQSWorkshopServer;

namespace WAQSWorkshopServer.DAL.Interfaces
{
    public interface IProductDALSpecifications 
    {
        Expression<Func<WAQSWorkshopServer.Product, string>> FullNameExpression { get; }
    }
}
