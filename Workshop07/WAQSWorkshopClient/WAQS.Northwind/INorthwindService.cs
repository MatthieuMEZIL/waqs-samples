// Copyright (c) Matthieu MEZIL.  All rights reserved.
[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://WAQS/Query", ClrNamespace = "WAQS.ClientContext.Interfaces.Query")]
[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://WAQS/QuerySerialization", ClrNamespace = "WAQS.ClientContext.Interfaces.ExpressionSerialization")]
[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://Northwind/SerializableContext", ClrNamespace = "WAQSWorkshopClient.ClientContext.Interfaces.Serialization")]
[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://Northwind/Entities", ClrNamespace = "WAQSWorkshopClient")]
[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://WAQS/EntityTracking", ClrNamespace = "WAQS.EntitiesTracking")]
[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://WAQS/Querying", ClrNamespace = "WAQS.ClientContext.Interfaces.Querying")]
[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://WAQS/QueryResult", ClrNamespace = "WAQS.ClientContext.QueryResult")]
[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://Northwind/QueryResult", ClrNamespace = "WAQSWorkshopClient.ClientContext.QueryResult")]
[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://Northwind/Fault", ClrNamespace = "WAQSWorkshopClient.ClientContext.Fault")]
[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://WAQS/Fault", ClrNamespace = "WAQS.ClientContext.Fault")]
[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://WAQS/Errors", ClrNamespace = "WAQS.ClientContext.Interfaces.Errors")]
// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 5.0.61118.0
// 
namespace WAQSWorkshopClient.ClientContext.ServiceReference
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://Northwind.net", ConfigurationName = "WAQSWorkshopClient.ClientContext.ServiceReference.INorthwindService")]
    public interface INorthwindService : System.ServiceModel.ICommunicationObject, System.IDisposable
    {
        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://Northwind.net/INorthwindService/Execute", ReplyAction = "http://Northwind.net/INorthwindService/ExecuteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.FaultDetail), Action = "FaultDetail", Name = "FaultDetail", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Interfaces.Errors.Error), Action = "Error", Name = "Error", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.ErrorCollection), Action = "ErrorCollection", Name = "ErrorCollection", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQSWorkshopClient.ClientContext.Fault.NorthwindFaultDetailEntities), Action = "NorthwindFaultDetailEntities", Name = "NorthwindFaultDetailEntities", Namespace = "")]
        System.IAsyncResult BeginExecute(WAQS.ClientContext.Interfaces.Query.QuerySerialization query, System.AsyncCallback callback, object asyncState);
        WAQSWorkshopClient.ClientContext.QueryResult.NorthwindQueryResult EndExecute(System.IAsyncResult result);
        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://Northwind.net/INorthwindService/ExecuteMany", ReplyAction = "http://Northwind.net/INorthwindService/ExecuteManyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.FaultDetail), Action = "FaultDetail", Name = "FaultDetail", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Interfaces.Errors.Error), Action = "Error", Name = "Error", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.ErrorCollection), Action = "ErrorCollection", Name = "ErrorCollection", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQSWorkshopClient.ClientContext.Fault.NorthwindFaultDetailEntities), Action = "NorthwindFaultDetailEntities", Name = "NorthwindFaultDetailEntities", Namespace = "")]
        System.IAsyncResult BeginExecuteMany(WAQS.ClientContext.Interfaces.Query.QueriesSerialization queries, System.AsyncCallback callback, object asyncState);
        WAQSWorkshopClient.ClientContext.QueryResult.NorthwindQueriesResult EndExecuteMany(System.IAsyncResult result);
        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://Northwind.net/INorthwindService/LoadPage", ReplyAction = "http://Northwind.net/INorthwindService/LoadPageResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.FaultDetail), Action = "FaultDetail", Name = "FaultDetail", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Interfaces.Errors.Error), Action = "Error", Name = "Error", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.ErrorCollection), Action = "ErrorCollection", Name = "ErrorCollection", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQSWorkshopClient.ClientContext.Fault.NorthwindFaultDetailEntities), Action = "NorthwindFaultDetailEntities", Name = "NorthwindFaultDetailEntities", Namespace = "")]
        System.IAsyncResult BeginLoadPage(int pageSize, WAQS.ClientContext.Interfaces.ExpressionSerialization.SerializableExpression queryExpression, string[] withSpecificationsProperties, WAQS.ClientContext.Interfaces.Querying.LoadPageParameter[] identifiers, System.AsyncCallback callback, object asyncState);
        WAQSWorkshopClient.ClientContext.QueryResult.NorthwindQueryResultPage EndLoadPage(System.IAsyncResult result);
        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://Northwind.net/INorthwindService/GetDbDateTime", ReplyAction = "http://Northwind.net/INorthwindService/GetDbDateTimeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.FaultDetail), Action = "FaultDetail", Name = "FaultDetail", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Interfaces.Errors.Error), Action = "Error", Name = "Error", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.ErrorCollection), Action = "ErrorCollection", Name = "ErrorCollection", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQSWorkshopClient.ClientContext.Fault.NorthwindFaultDetailEntities), Action = "NorthwindFaultDetailEntities", Name = "NorthwindFaultDetailEntities", Namespace = "")]
        System.IAsyncResult BeginGetDbDateTime(System.AsyncCallback callback, object asyncState);
        System.DateTime EndGetDbDateTime(System.IAsyncResult result);
        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://Northwind.net/INorthwindService/SaveChanges", ReplyAction = "http://Northwind.net/INorthwindService/SaveChangesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.FaultDetail), Action = "FaultDetail", Name = "FaultDetail", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Interfaces.Errors.Error), Action = "Error", Name = "Error", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.ErrorCollection), Action = "ErrorCollection", Name = "ErrorCollection", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQSWorkshopClient.ClientContext.Fault.NorthwindFaultDetailEntities), Action = "NorthwindFaultDetailEntities", Name = "NorthwindFaultDetailEntities", Namespace = "")]
        System.IAsyncResult BeginSaveChanges(WAQSWorkshopClient.ClientContext.Interfaces.Serialization.NorthwindSerializableContext context, System.AsyncCallback callback, object asyncState);
        WAQSWorkshopClient.ClientContext.Interfaces.Serialization.NorthwindSerializableContext EndSaveChanges(System.IAsyncResult result);
        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://Northwind.net/INorthwindService/ValidateCustomer", ReplyAction = "http://Northwind.net/INorthwindService/ValidateCustomerResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.FaultDetail), Action = "FaultDetail", Name = "FaultDetail", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Interfaces.Errors.Error), Action = "Error", Name = "Error", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.ErrorCollection), Action = "ErrorCollection", Name = "ErrorCollection", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQSWorkshopClient.ClientContext.Fault.NorthwindFaultDetailEntities), Action = "NorthwindFaultDetailEntities", Name = "NorthwindFaultDetailEntities", Namespace = "")]
        System.IAsyncResult BeginValidateCustomer(WAQSWorkshopClient.Customer entity, System.AsyncCallback callback, object asyncState);
        WAQS.ClientContext.Interfaces.Errors.Error[] EndValidateCustomer(System.IAsyncResult result);
        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://Northwind.net/INorthwindService/ValidateEmployee", ReplyAction = "http://Northwind.net/INorthwindService/ValidateEmployeeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.FaultDetail), Action = "FaultDetail", Name = "FaultDetail", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Interfaces.Errors.Error), Action = "Error", Name = "Error", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.ErrorCollection), Action = "ErrorCollection", Name = "ErrorCollection", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQSWorkshopClient.ClientContext.Fault.NorthwindFaultDetailEntities), Action = "NorthwindFaultDetailEntities", Name = "NorthwindFaultDetailEntities", Namespace = "")]
        System.IAsyncResult BeginValidateEmployee(WAQSWorkshopClient.Employee entity, System.AsyncCallback callback, object asyncState);
        WAQS.ClientContext.Interfaces.Errors.Error[] EndValidateEmployee(System.IAsyncResult result);
        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://Northwind.net/INorthwindService/ValidateInvoiceDetail", ReplyAction = "http://Northwind.net/INorthwindService/ValidateInvoiceDetailResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.FaultDetail), Action = "FaultDetail", Name = "FaultDetail", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Interfaces.Errors.Error), Action = "Error", Name = "Error", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.ErrorCollection), Action = "ErrorCollection", Name = "ErrorCollection", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQSWorkshopClient.ClientContext.Fault.NorthwindFaultDetailEntities), Action = "NorthwindFaultDetailEntities", Name = "NorthwindFaultDetailEntities", Namespace = "")]
        System.IAsyncResult BeginValidateInvoiceDetail(WAQSWorkshopClient.InvoiceDetail entity, System.AsyncCallback callback, object asyncState);
        WAQS.ClientContext.Interfaces.Errors.Error[] EndValidateInvoiceDetail(System.IAsyncResult result);
        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://Northwind.net/INorthwindService/ValidateInvoice", ReplyAction = "http://Northwind.net/INorthwindService/ValidateInvoiceResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.FaultDetail), Action = "FaultDetail", Name = "FaultDetail", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Interfaces.Errors.Error), Action = "Error", Name = "Error", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.ErrorCollection), Action = "ErrorCollection", Name = "ErrorCollection", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQSWorkshopClient.ClientContext.Fault.NorthwindFaultDetailEntities), Action = "NorthwindFaultDetailEntities", Name = "NorthwindFaultDetailEntities", Namespace = "")]
        System.IAsyncResult BeginValidateInvoice(WAQSWorkshopClient.Invoice entity, System.AsyncCallback callback, object asyncState);
        WAQS.ClientContext.Interfaces.Errors.Error[] EndValidateInvoice(System.IAsyncResult result);
        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://Northwind.net/INorthwindService/ValidateOrderDetail", ReplyAction = "http://Northwind.net/INorthwindService/ValidateOrderDetailResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.FaultDetail), Action = "FaultDetail", Name = "FaultDetail", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Interfaces.Errors.Error), Action = "Error", Name = "Error", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.ErrorCollection), Action = "ErrorCollection", Name = "ErrorCollection", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQSWorkshopClient.ClientContext.Fault.NorthwindFaultDetailEntities), Action = "NorthwindFaultDetailEntities", Name = "NorthwindFaultDetailEntities", Namespace = "")]
        System.IAsyncResult BeginValidateOrderDetail(WAQSWorkshopClient.OrderDetail entity, System.AsyncCallback callback, object asyncState);
        WAQS.ClientContext.Interfaces.Errors.Error[] EndValidateOrderDetail(System.IAsyncResult result);
        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://Northwind.net/INorthwindService/ValidateOrder", ReplyAction = "http://Northwind.net/INorthwindService/ValidateOrderResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.FaultDetail), Action = "FaultDetail", Name = "FaultDetail", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Interfaces.Errors.Error), Action = "Error", Name = "Error", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.ErrorCollection), Action = "ErrorCollection", Name = "ErrorCollection", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQSWorkshopClient.ClientContext.Fault.NorthwindFaultDetailEntities), Action = "NorthwindFaultDetailEntities", Name = "NorthwindFaultDetailEntities", Namespace = "")]
        System.IAsyncResult BeginValidateOrder(WAQSWorkshopClient.Order entity, System.AsyncCallback callback, object asyncState);
        WAQS.ClientContext.Interfaces.Errors.Error[] EndValidateOrder(System.IAsyncResult result);
        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://Northwind.net/INorthwindService/ValidateProduct", ReplyAction = "http://Northwind.net/INorthwindService/ValidateProductResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.FaultDetail), Action = "FaultDetail", Name = "FaultDetail", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Interfaces.Errors.Error), Action = "Error", Name = "Error", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.ErrorCollection), Action = "ErrorCollection", Name = "ErrorCollection", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQSWorkshopClient.ClientContext.Fault.NorthwindFaultDetailEntities), Action = "NorthwindFaultDetailEntities", Name = "NorthwindFaultDetailEntities", Namespace = "")]
        System.IAsyncResult BeginValidateProduct(WAQSWorkshopClient.Product entity, System.AsyncCallback callback, object asyncState);
        WAQS.ClientContext.Interfaces.Errors.Error[] EndValidateProduct(System.IAsyncResult result);
        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://Northwind.net/INorthwindService/ValidateCategory", ReplyAction = "http://Northwind.net/INorthwindService/ValidateCategoryResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.FaultDetail), Action = "FaultDetail", Name = "FaultDetail", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Interfaces.Errors.Error), Action = "Error", Name = "Error", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.ErrorCollection), Action = "ErrorCollection", Name = "ErrorCollection", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQSWorkshopClient.ClientContext.Fault.NorthwindFaultDetailEntities), Action = "NorthwindFaultDetailEntities", Name = "NorthwindFaultDetailEntities", Namespace = "")]
        System.IAsyncResult BeginValidateCategory(WAQSWorkshopClient.Category entity, System.AsyncCallback callback, object asyncState);
        WAQS.ClientContext.Interfaces.Errors.Error[] EndValidateCategory(System.IAsyncResult result);
        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://Northwind.net/INorthwindService/AlreadySoldTo", ReplyAction = "http://Northwind.net/INorthwindService/AlreadySoldToResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.FaultDetail), Action = "FaultDetail", Name = "FaultDetail", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Interfaces.Errors.Error), Action = "Error", Name = "Error", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.ErrorCollection), Action = "ErrorCollection", Name = "ErrorCollection", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQSWorkshopClient.ClientContext.Fault.NorthwindFaultDetailEntities), Action = "NorthwindFaultDetailEntities", Name = "NorthwindFaultDetailEntities", Namespace = "")]
        System.IAsyncResult BeginAlreadySoldTo(WAQSWorkshopClient.Employee employee, WAQSWorkshopClient.Customer customer, System.AsyncCallback callback, object asyncState);
        bool EndAlreadySoldTo(System.IAsyncResult result);
        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://Northwind.net/INorthwindService/AddInvoice", ReplyAction = "http://Northwind.net/INorthwindService/AddInvoiceResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.FaultDetail), Action = "FaultDetail", Name = "FaultDetail", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Interfaces.Errors.Error), Action = "Error", Name = "Error", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.ErrorCollection), Action = "ErrorCollection", Name = "ErrorCollection", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQSWorkshopClient.ClientContext.Fault.NorthwindFaultDetailEntities), Action = "NorthwindFaultDetailEntities", Name = "NorthwindFaultDetailEntities", Namespace = "")]
        System.IAsyncResult BeginAddInvoice(int orderId, System.AsyncCallback callback, object asyncState);
        WAQSWorkshopClient.Invoice EndAddInvoice(System.IAsyncResult result);
        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://Northwind.net/INorthwindService/CreateInvoiceDetail", ReplyAction = "http://Northwind.net/INorthwindService/CreateInvoiceDetailResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.FaultDetail), Action = "FaultDetail", Name = "FaultDetail", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Interfaces.Errors.Error), Action = "Error", Name = "Error", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQS.ClientContext.Fault.ErrorCollection), Action = "ErrorCollection", Name = "ErrorCollection", Namespace = "")]
        [System.ServiceModel.FaultContractAttribute(typeof (WAQSWorkshopClient.ClientContext.Fault.NorthwindFaultDetailEntities), Action = "NorthwindFaultDetailEntities", Name = "NorthwindFaultDetailEntities", Namespace = "")]
        System.IAsyncResult BeginCreateInvoiceDetail(WAQSWorkshopClient.OrderDetail od, System.AsyncCallback callback, object asyncState);
        WAQSWorkshopClient.InvoiceDetail EndCreateInvoiceDetail(System.IAsyncResult result);
    }
}
