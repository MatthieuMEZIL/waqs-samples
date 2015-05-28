//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using System;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace WAQS.WCFService
{
    public class WCFExceptionHandlerEndpointBehavior : BehaviorExtensionElement, IEndpointBehavior
    {
    	public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
    	{
    	}
    
    	public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
    	{
    	}
    
    	public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
    	{
    		var exceptionHandlerMessageInspector = new ExceptionHandlerMessageInspector();
    		endpointDispatcher.DispatchRuntime.MessageInspectors.Add(exceptionHandlerMessageInspector);
    		endpointDispatcher.ChannelDispatcher.ErrorHandlers.Add(new WCFExceptionHandler());
    	}
    
    	public void Validate(ServiceEndpoint endpoint)
    	{
    	}
    
    	public override Type BehaviorType
    	{
    		get { return typeof(WCFExceptionHandlerEndpointBehavior); }
    	}
    
    	protected override object CreateBehavior()
    	{
    		return new WCFExceptionHandlerEndpointBehavior();
    	}
    }
}
