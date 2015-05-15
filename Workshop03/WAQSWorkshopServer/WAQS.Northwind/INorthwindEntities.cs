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
using System.Linq;
using System.Linq.Expressions;
using WAQS.DAL.Interfaces;
using WAQS.DAL.Interfaces.L2E;

namespace WAQSWorkshopServer.DAL.Interfaces
{
    public partial interface INorthwindEntities : IObjectContext, IDisposable
    {
        #region EntitySet Properties
    
        IEntitySet<WAQSWorkshopServer.Customer> Customers { get; }
        Expression<Func<IQueryable<WAQSWorkshopServer.Customer>>> CustomersExpression { get; }
    
        IEntitySet<WAQSWorkshopServer.Employee> Employees { get; }
        Expression<Func<IQueryable<WAQSWorkshopServer.Employee>>> EmployeesExpression { get; }
    
        IEntitySet<WAQSWorkshopServer.InvoiceDetail> InvoiceDetails { get; }
        Expression<Func<IQueryable<WAQSWorkshopServer.InvoiceDetail>>> InvoiceDetailsExpression { get; }
    
        IEntitySet<WAQSWorkshopServer.Invoice> Invoices { get; }
        Expression<Func<IQueryable<WAQSWorkshopServer.Invoice>>> InvoicesExpression { get; }
    
        IEntitySet<WAQSWorkshopServer.OrderDetail> OrderDetails { get; }
        Expression<Func<IQueryable<WAQSWorkshopServer.OrderDetail>>> OrderDetailsExpression { get; }
    
        IEntitySet<WAQSWorkshopServer.Order> Orders { get; }
        Expression<Func<IQueryable<WAQSWorkshopServer.Order>>> OrdersExpression { get; }
    
        IEntitySet<WAQSWorkshopServer.Product> Products { get; }
        Expression<Func<IQueryable<WAQSWorkshopServer.Product>>> ProductsExpression { get; }
    
        IEntitySet<WAQSWorkshopServer.Category> Categories { get; }
        Expression<Func<IQueryable<WAQSWorkshopServer.Category>>> CategoriesExpression { get; }

        #endregion

     
    }
}
