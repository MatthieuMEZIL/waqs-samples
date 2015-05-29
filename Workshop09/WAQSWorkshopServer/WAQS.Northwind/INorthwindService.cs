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
using WAQS.DAL.Interfaces;
using WAQS.SerializableExpressions;
using WAQS.Service.Interfaces;
using WAQSWorkshopServer;
using WAQSWorkshopServer.WAQSDTO;

namespace WAQSWorkshopServer.Service.Interfaces
{
    public partial interface INorthwindService : WAQS.Service.Interfaces.IService, IDisposable
    {	
    	IEntitySet<WAQSWorkshopServer.Customer> Customers { get; }
    	void ApplyChanges(WAQSWorkshopServer.Customer entity);
     
    	IEntitySet<WAQSWorkshopServer.Employee> Employees { get; }
    	void ApplyChanges(WAQSWorkshopServer.Employee entity);
     
    	IEntitySet<WAQSWorkshopServer.InvoiceDetail> InvoiceDetails { get; }
    	void ApplyChanges(WAQSWorkshopServer.InvoiceDetail entity);
     
    	IEntitySet<WAQSWorkshopServer.Invoice> Invoices { get; }
    	void ApplyChanges(WAQSWorkshopServer.Invoice entity);
     
    	IEntitySet<WAQSWorkshopServer.OrderDetail> OrderDetails { get; }
    	void ApplyChanges(WAQSWorkshopServer.OrderDetail entity);
     
    	IEntitySet<WAQSWorkshopServer.Order> Orders { get; }
    	void ApplyChanges(WAQSWorkshopServer.Order entity);
     
    	IEntitySet<WAQSWorkshopServer.Product> Products { get; }
    	void ApplyChanges(WAQSWorkshopServer.Product entity);
     
    	IEntitySet<WAQSWorkshopServer.Category> Categories { get; }
    	void ApplyChanges(WAQSWorkshopServer.Category entity);
     
    	NorthwindQueryResult Execute(QuerySerialization query);
    
    	NorthwindQueriesResult ExecuteMany(QueriesSerialization queries);
    
    	NorthwindQueryResultPage LoadPage(int pageSize, SerializableExpression queryExpression, IEnumerable<string> withSpecificationsProperties, LoadPageParameter[] identifiers);
    
    	DateTime GetDbDateTime();
    	
    	void SaveChanges();
    
    	IEnumerable<Error> Validate(Customer entity);
    
    	IEnumerable<Error> Validate(Employee entity);
    
    	IEnumerable<Error> Validate(InvoiceDetail entity);
    
    	IEnumerable<Error> Validate(Invoice entity);
    
    	IEnumerable<Error> Validate(OrderDetail entity);
    
    	IEnumerable<Error> Validate(Order entity);
    
    	IEnumerable<Error> Validate(Product entity);
    
    	IEnumerable<Error> Validate(Category entity);
    
    	bool AlreadySoldTo(Employee employee, Customer customer);
    
    	Invoice AddInvoice(int orderId);
    
    	InvoiceDetail CreateInvoiceDetail(OrderDetail od);
    
    	LastOrderDTO GetLastOrder();
    }
}
