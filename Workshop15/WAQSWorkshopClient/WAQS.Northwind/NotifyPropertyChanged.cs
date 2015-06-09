//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace WAQS.ComponentModel
{
    public partial class NotifyPropertyChanged
    {
    	private object _sender;
    	private Func<PropertyChangedEventHandler> _getRaiseEvent;
    	private Action<string> _actionOnRaise;
    	
    	public NotifyPropertyChanged(object sender, Func<PropertyChangedEventHandler> getRaiseEvent, Action<string> actionOnRaise = null)
    	{
    		_getRaiseEvent = getRaiseEvent;
    		_sender = sender;
    		_actionOnRaise = actionOnRaise;
    	}
    	
    	public void RaisePropertyChanged(string propName)
    	{
    		PropertyChangedEventHandler propertyChanged = _getRaiseEvent();
    		if (propertyChanged != null)
    		{
    			propertyChanged(_sender, new PropertyChangedEventArgs(propName));
    			if (_actionOnRaise != null)
    				_actionOnRaise(propName);
    		}
    	}
    	
    	public void RaisePropertyChanged<T>(Expression<Func<T>> exp)
    	{
    		string propertyName = PropertyName.GetPropertyName(exp);
    		if (propertyName != null)
    			RaisePropertyChanged(propertyName);
    	}
    
    	public void RaisePropertyChanged<TSource, TProp>(Expression<Func<TSource, TProp>> exp)
    	{
    		string propertyName = PropertyName.GetPropertyName(exp);
    		if (propertyName != null)
    			RaisePropertyChanged(propertyName);
    	}
    }
}
