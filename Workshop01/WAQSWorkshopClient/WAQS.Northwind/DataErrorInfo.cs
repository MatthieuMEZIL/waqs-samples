//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace WAQS.ComponentModel
{
    public partial class DataErrorInfo
    {
    	private Dictionary<string, List<ErrorInfo>> _currentErrors = new Dictionary<string, List<ErrorInfo>>();
    	
    	public void AddErrorForProperty(string propertyName, ErrorInfo error)
    	{
    		OnAddingErrorForProperty(propertyName, error);
    		if (GetOrCreatePropertyErrorList(propertyName).FirstOrDefault(err => err.ErrorCode == error.ErrorCode) == null)
    			_currentErrors[propertyName].Add(error);
    	}
    	partial void OnAddingErrorForProperty(string propertyName, ErrorInfo error);
    
    	public string Error 
    	{
    		get 
    		{ 
    			if (_currentErrors.Any())
    			{
    				StringBuilder sb = new StringBuilder();
    				foreach (var error in _currentErrors.Values.SelectMany(e => e))
    					sb.Append(error);
    				return sb.ToString();
    			}
    			return null;
    		}
    	}
    
    	public string this[string columnName]
    	{
    		get 
    		{
    			List<ErrorInfo> errorInfos;
    			if (_currentErrors.TryGetValue(columnName, out errorInfos))
    			{
    				var sb = new StringBuilder();
    				var errorsInfoEnumerator = errorInfos.GetEnumerator();
    				if (errorsInfoEnumerator.MoveNext())
    				{
    					for (; ; )
    					{
    						sb.Append(errorsInfoEnumerator.Current.Message);
    						if (errorsInfoEnumerator.MoveNext())
    							sb.Append(Environment.NewLine);
    						else
    							break;
    					}
    				}
    				return sb.ToString();
    			}
    			return null;
    		}
    	}
    		
    	public void AddErrorForProperty<T>(Expression<Func<T>> exp, ErrorInfo error)
    	{
    		var propertyName = PropertyName.GetPropertyName(exp);
    		AddErrorForProperty(propertyName, error);
    	}
    		
    	public void RemoveErrorFromProperty(string propertyName, string errorCode)
    	{
    		var error = GetPropertyErrorList(propertyName).FirstOrDefault(err => err.ErrorCode == errorCode);
    		
    		if (error != null)
    		{
    			_currentErrors[propertyName].Remove(error);
    			if (_currentErrors[propertyName].Count == 0)
    				_currentErrors.Remove(propertyName);
    		}
    	}
    		
    	public void RemoveErrorFromProperty<T>(Expression<Func<T>> exp, string errorCode)
    	{
    		RemoveErrorFromProperty(PropertyName.GetPropertyName(exp), errorCode);
    	}
    		
    	public IEnumerable GetErrors(string propertyName)
    	{
    		if (string.IsNullOrEmpty(propertyName))
    			return _currentErrors.Values;
    		
    		return GetPropertyErrorList(propertyName);
    	}
    		
    	public bool HasErrors
    	{
    		get { return _currentErrors.Count != 0; }
    	}
    		
    	private List<ErrorInfo> GetOrCreatePropertyErrorList(string propertyName)
    	{
    		List<ErrorInfo> result;
    		if (!_currentErrors.TryGetValue(propertyName, out result))
    			_currentErrors.Add(propertyName, result = new List<ErrorInfo>());
    		return result;
    	}
    		
    	private List<ErrorInfo> GetPropertyErrorList(string propertyName)
    	{
    		return _currentErrors.ContainsKey(propertyName) ? _currentErrors[propertyName] : new List<ErrorInfo>();
    	}
    }
}
