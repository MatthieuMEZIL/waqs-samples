//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright (c) Matthieu MEZIL.  All rights reserved.
// matthieu.mezil@live.fr

 
using System;
using System.Windows.Input;

namespace WAQS.ComponentModel
{
    public partial class RelayCommand : ICommand
    {
    	private Action<object> _execute;
    	private Func<object, bool> _canExecute;
    
    	public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
    	{
    		_execute = execute;
    		_canExecute = canExecute;
    	}
    
    	public RelayCommand(Action execute)
    		: this(o => execute())
    	{
    	}
    
    	public RelayCommand(Action execute, Func<bool> canExecute)
    		: this(o => execute(), o => canExecute())
    	{
    	}
    
    	public static RelayCommand Create(Action execute, Func<bool> canExecute = null)
    	{
    		return new RelayCommand(o => execute(), canExecute == null ? (Func<object, bool>)null : o => canExecute());
    	}
    	public static RelayCommand Create<T>(Action<T> execute, Func<T, bool> canExecute = null)
    	{
    		return new RelayCommand(o => execute((T)o), canExecute == null ? (Func<object, bool>)null : o => canExecute((T)o));
    	}
    
    	public bool CanExecute(object parameter)
    	{
    		return _canExecute == null ? true : _canExecute(parameter);
    	}
    
    	public void RaiseCanExecuteChanged()
    	{
    		if (CanExecuteChanged != null)
    			CanExecuteChanged(this, EventArgs.Empty);
    	}
    	public event EventHandler CanExecuteChanged;
    
    	public void Execute(object parameter)
    	{
    		_execute(parameter);
    	}
    }
}
