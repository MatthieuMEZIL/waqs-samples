//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using System;
using System.Drawing;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using WAQS.ClientContext.Interfaces.Errors;

namespace WAQS.Controls.Converters
{
    public class CritityConverter : IValueConverter
    {
    	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    	{
    		Icon icon;
    		switch ((Criticity)value)
    		{
    			case Criticity.Error:
    			case Criticity.Mandatory:
    				icon = SystemIcons.Error;
    				break;
    			case Criticity.Warning:
    				icon = SystemIcons.Warning;
    				break;
    			case Criticity.Information:
    				icon = SystemIcons.Information;
    				break;
    			default:
    				return null;
    		}
    		return Imaging.CreateBitmapSourceFromHIcon(icon.Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
    	}
    
    	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    	{
    		throw new NotImplementedException();
    	}
    }
}
