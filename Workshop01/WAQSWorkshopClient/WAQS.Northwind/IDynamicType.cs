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
    public interface IDynamicType
    {
    	IEnumerable<PropertyDescriptor> GetCustomPropertyDescriptors();
    	void AddPropertyDescriptor(PropertyDescriptor propertyDescriptor);
    	void AddOrReplacePropertyDescriptor(PropertyDescriptor propertyDescriptor);
    	void RemovePropertyDescriptor(PropertyDescriptor propertyDescriptor);
    	void RemovePropertyDescriptor(string propertyName);
    }
}
