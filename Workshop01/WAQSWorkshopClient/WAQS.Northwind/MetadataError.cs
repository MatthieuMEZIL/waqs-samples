//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using WAQS.ComponentModel;

namespace WAQS.ClientContext.Interfaces.Errors
{
    public class MetadataError : Error
    {
        public ErrorInfo ErrorInfo { get; set; }
    	public override string Message 
    	{ 
    		get { return (ErrorInfo == null ? "" : (ErrorInfo.PropertyName + ": ")) + base.Message; }
    		set { base.Message = value; }
    	}
    }
}