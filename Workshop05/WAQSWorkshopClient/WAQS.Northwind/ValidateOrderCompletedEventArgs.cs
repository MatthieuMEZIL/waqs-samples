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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ValidateOrderCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        private object[] results;
        public ValidateOrderCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState): base (exception, cancelled, userState)
        {
            this.results = results;
        }

        public WAQS.ClientContext.Interfaces.Errors.Error[] Result
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return ((WAQS.ClientContext.Interfaces.Errors.Error[])(this.results[0]));
            }
        }
    }
}
