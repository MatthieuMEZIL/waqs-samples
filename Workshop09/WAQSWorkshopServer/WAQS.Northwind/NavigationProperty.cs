//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using System.Reflection;

namespace WAQS.SerializableExpressions
{
    public class NavigationProperty
    {
        public NavigationProperty(PropertyInfo property, Multiplicity multiplicity)
        {
            Property = property;
            Multiplicity = multiplicity;
        }
        public PropertyInfo Property { get; private set; }
        public Multiplicity Multiplicity { get; private set; }
    }
}