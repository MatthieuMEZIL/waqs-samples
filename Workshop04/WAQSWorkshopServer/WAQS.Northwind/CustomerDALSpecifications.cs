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
using WAQS.Common;
using WAQSWorkshopServer;
using WAQSWorkshopServer.DAL.Interfaces;

namespace WAQSWorkshopServer.DAL
{
    public partial class CustomerDALSpecifications : ICustomerDALSpecifications
    {
        private NorthwindEntities _context;
    
        public CustomerDALSpecifications(NorthwindEntities context)
        {
            _context = context;
        }
    
        Expression<Func<WAQSWorkshopServer.Customer, double>> ICustomerDALSpecifications.TotalSpentExpression
        {
            get { return CustomerDALSpecifications.GetTotalSpentExpression(); }
        }
    
        private static Expression<Func<WAQSWorkshopServer.Customer, double>> _getTotalSpentExpression;
        protected internal static Expression<Func<WAQSWorkshopServer.Customer, double>> GetTotalSpentExpression(bool isCoalesceEnabled = true)
        {
            if (_getTotalSpentExpression == null)
            {
                Func<WAQSWorkshopServer.Order, double> getTotal_Order = (_) => default(double);
                Expression<Func<WAQSWorkshopServer.Customer, double>> exp = (customer) => customer.Orders.Sum(o => getTotal_Order(o));
                Func<InvocationExpression, Expression> replaceExpFunc = null;
                replaceExpFunc = invocationExpression =>
                    {
                        MemberExpression memberExpression = invocationExpression.Expression as MemberExpression;
                        if (memberExpression == null)
                            return invocationExpression;
                        switch (memberExpression.Member.Name)
                        {
                            case "getTotal_Order":
                            {
                                var getTotal_OrderSubExp = OrderDALSpecifications.GetTotalExpression(isCoalesceEnabled : false);
                                if (getTotal_OrderSubExp == null)
                                    return null;
                                Expression subExp = getTotal_OrderSubExp.Body.ReplaceParameter(parameter => 
                                    {
                                        int index = getTotal_OrderSubExp.Parameters.IndexOf(parameter);
                                        if (index == -1)
                                            return parameter;
                                        return invocationExpression.Arguments[index].ReplaceInvocation(replaceExpFunc);
                                    });
                                return subExp;
                            }
                            default:
                                return invocationExpression;
                        }
                    };
                exp = (Expression<Func<WAQSWorkshopServer.Customer, double>>)exp.ReplaceInvocation(replaceExpFunc);
                if (exp != null && isCoalesceEnabled)
                    exp = (Expression<Func<WAQSWorkshopServer.Customer, double>>)exp.ReplaceExpression(exp.Body, Expression.Coalesce(Expression.Convert(exp.Body, typeof(double?)), Expression.Constant(default(double))));
                _getTotalSpentExpression = exp;
            }
            GetTotalSpentExpression(ref _getTotalSpentExpression);
            return _getTotalSpentExpression;
        }
        static partial void GetTotalSpentExpression(ref Expression<Func<WAQSWorkshopServer.Customer, double>> exp);
    
        Expression<Func<WAQSWorkshopServer.Customer, string>> ICustomerDALSpecifications.FullNameExpression
        {
            get { return CustomerDALSpecifications.GetFullNameExpression(); }
        }
    
        private static Expression<Func<WAQSWorkshopServer.Customer, string>> _getFullNameExpression;
        protected internal static Expression<Func<WAQSWorkshopServer.Customer, string>> GetFullNameExpression(bool isCoalesceEnabled = true)
        {
            if (_getFullNameExpression == null)
            {
                Expression<Func<WAQSWorkshopServer.Customer, string>> exp = (customer) => customer.CompanyName + " " + customer.ContactName;
                _getFullNameExpression = exp;
            }
            GetFullNameExpression(ref _getFullNameExpression);
            return _getFullNameExpression;
        }
        static partial void GetFullNameExpression(ref Expression<Func<WAQSWorkshopServer.Customer, string>> exp);
    
    }
}
