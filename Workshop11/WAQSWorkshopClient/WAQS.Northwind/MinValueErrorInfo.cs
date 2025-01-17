//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 

namespace WAQS.ComponentModel
{
    public partial class MinValueErrorInfo<T> : ErrorInfo
    {
    	public const string MinValueErrorCode = "MinValue";
    
    	public MinValueErrorInfo(string propertyName, T maxValue)
    		: base(propertyName, MinValueErrorCode)
    	{
    		MinValue = maxValue;
    	}
    
    	public override string Message
    	{
    		get 
    		{
    			string message = string.Format("Min value error ({0})", MinValue);
    			SetMessage(ref message);
    			return message;
    		}
    	}
    	partial void SetMessage(ref string message);
    
    	public T MinValue { get; private set; }
    }
}
