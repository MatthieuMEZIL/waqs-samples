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
using System.ComponentModel;

namespace WAQS.ComponentModel
{
    public abstract class CustomPropertyDescriptor : PropertyDescriptor
    {
    	public CustomPropertyDescriptor(string name)
    		: base(name, new Attribute[0])
    	{
    	}
    
    	public IEnumerable<string> Properties { get; protected set; }
    }
}
