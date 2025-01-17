//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using System;
using System.Linq.Expressions;
using WAQS.Service;
using WAQSWorkshopServer;
using WAQSWorkshopServer.DAL.Interfaces;

namespace WAQSWorkshopServer.Service
{
    public partial class NorthwindEntitiesFilters
    {
        private readonly INorthwindEntities _context;
    
        public NorthwindEntitiesFilters(INorthwindEntities context)
        {
            _context = context;
        }
    
        private Expression<Func<Customer, bool>> _customerFilterExpression;
        private bool _customerFilterExpressionInitialized = false;
        public Expression<Func<Customer, bool>> CustomerFilterExpression
        {
            get 
            { 
                if (!_customerFilterExpressionInitialized)
                {
                    ApplyCustomersServerWhere(ref _customerFilterExpression);
                    _customerFilterExpressionInitialized = true;
                }
                return _customerFilterExpression;
            }
        }
        partial void ApplyCustomersServerWhere(ref Expression<Func<Customer, bool>> filterExpression);
    
        private Expression<Func<Employee, bool>> _employeeFilterExpression;
        private bool _employeeFilterExpressionInitialized = false;
        public Expression<Func<Employee, bool>> EmployeeFilterExpression
        {
            get 
            { 
                if (!_employeeFilterExpressionInitialized)
                {
                    ApplyEmployeesServerWhere(ref _employeeFilterExpression);
                    _employeeFilterExpressionInitialized = true;
                }
                return _employeeFilterExpression;
            }
        }
        partial void ApplyEmployeesServerWhere(ref Expression<Func<Employee, bool>> filterExpression);
    
        private Expression<Func<InvoiceDetail, bool>> _invoiceDetailFilterExpression;
        private bool _invoiceDetailFilterExpressionInitialized = false;
        public Expression<Func<InvoiceDetail, bool>> InvoiceDetailFilterExpression
        {
            get 
            { 
                if (!_invoiceDetailFilterExpressionInitialized)
                {
                    ApplyInvoiceDetailsServerWhere(ref _invoiceDetailFilterExpression);
                    _invoiceDetailFilterExpressionInitialized = true;
                }
                return _invoiceDetailFilterExpression;
            }
        }
        partial void ApplyInvoiceDetailsServerWhere(ref Expression<Func<InvoiceDetail, bool>> filterExpression);
    
        private Expression<Func<Invoice, bool>> _invoiceFilterExpression;
        private bool _invoiceFilterExpressionInitialized = false;
        public Expression<Func<Invoice, bool>> InvoiceFilterExpression
        {
            get 
            { 
                if (!_invoiceFilterExpressionInitialized)
                {
                    ApplyInvoicesServerWhere(ref _invoiceFilterExpression);
                    _invoiceFilterExpressionInitialized = true;
                }
                return _invoiceFilterExpression;
            }
        }
        partial void ApplyInvoicesServerWhere(ref Expression<Func<Invoice, bool>> filterExpression);
    
        private Expression<Func<OrderDetail, bool>> _orderDetailFilterExpression;
        private bool _orderDetailFilterExpressionInitialized = false;
        public Expression<Func<OrderDetail, bool>> OrderDetailFilterExpression
        {
            get 
            { 
                if (!_orderDetailFilterExpressionInitialized)
                {
                    ApplyOrderDetailsServerWhere(ref _orderDetailFilterExpression);
                    _orderDetailFilterExpressionInitialized = true;
                }
                return _orderDetailFilterExpression;
            }
        }
        partial void ApplyOrderDetailsServerWhere(ref Expression<Func<OrderDetail, bool>> filterExpression);
    
        private Expression<Func<Order, bool>> _orderFilterExpression;
        private bool _orderFilterExpressionInitialized = false;
        public Expression<Func<Order, bool>> OrderFilterExpression
        {
            get 
            { 
                if (!_orderFilterExpressionInitialized)
                {
                    ApplyOrdersServerWhere(ref _orderFilterExpression);
                    _orderFilterExpressionInitialized = true;
                }
                return _orderFilterExpression;
            }
        }
        partial void ApplyOrdersServerWhere(ref Expression<Func<Order, bool>> filterExpression);
    
        private Expression<Func<Product, bool>> _productFilterExpression;
        private bool _productFilterExpressionInitialized = false;
        public Expression<Func<Product, bool>> ProductFilterExpression
        {
            get 
            { 
                if (!_productFilterExpressionInitialized)
                {
                    ApplyProductsServerWhere(ref _productFilterExpression);
                    _productFilterExpressionInitialized = true;
                }
                return _productFilterExpression;
            }
        }
        partial void ApplyProductsServerWhere(ref Expression<Func<Product, bool>> filterExpression);
    
    }
}
