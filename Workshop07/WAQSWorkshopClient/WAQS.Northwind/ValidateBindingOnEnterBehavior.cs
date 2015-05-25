//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace WAQS.Controls
{
    public class ValidateBindingOnEnterBehavior : Behavior<TextBox>
    {
    	protected override void OnAttached()
    	{
    		base.OnAttached();
    		AssociatedObject.KeyDown += AssociatedObjectKeyDown;
    	}
    
    	private void AssociatedObjectKeyDown(object sender, KeyEventArgs e)
    	{
    		BindingExpression textBinding;
    		if (e.Key == Key.Enter && (textBinding = AssociatedObject.GetBindingExpression(TextBox.TextProperty)) != null)
    			textBinding.UpdateSource();
    	}
    
    	protected override void OnDetaching()
    	{
    		base.OnDetaching();
    		AssociatedObject.KeyDown -= AssociatedObjectKeyDown;
    	}
    }
}
