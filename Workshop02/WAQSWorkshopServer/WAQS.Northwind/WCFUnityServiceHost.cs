//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using System;
using System.ServiceModel;

namespace WAQS.WCFService
{
    public class WCFUnityServiceHost : ServiceHost
    {
    	public WCFUnityServiceHost()
    	{
    	}
    
    	public WCFUnityServiceHost(Type serviceType, Uri[] baseAddresses)
    		: base(serviceType, baseAddresses)
    	{
    	}
    
    	protected override void OnOpening()
    	{
    		Description.Behaviors.Add(new WCFUnityServiceBehavior());
    		base.OnOpening();
    	}
    }
}
