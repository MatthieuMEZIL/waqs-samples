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
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;

namespace WAQS.WCFService
{
    public class WCFUnityInstanceProvider : IInstanceProvider
    {
    	private Type _serviceType;
    
    	public WCFUnityInstanceProvider(Type serviceType)
    	{
    		_serviceType = serviceType;
    	}
    
    	public object GetInstance(InstanceContext instanceContext, Message message)
    	{
    		return ServiceLocator.Current.GetInstance<IUnityContainer>(_serviceType.FullName).Resolve(_serviceType);
    	}
    
    	public object GetInstance(InstanceContext instanceContext)
    	{
    		return GetInstance(instanceContext, null);
    	}
    
    	public void ReleaseInstance(InstanceContext instanceContext, object instance)
    	{
    	}
    }
}
