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

namespace WAQS.ClientContext.Interfaces.Errors
{
    public partial class ErrorException : Exception
    {
        public ErrorException(IEnumerable<Error> errors, ErrorSource source = ErrorSource.FromClient)
        {
            Errors = errors;
            Source = source;
        }
    
        public IEnumerable<Error> Errors { get; private set; }
    
        public new ErrorSource Source { get; private set; }
    
        public static ErrorException Throw(IEnumerable<Error> errors, ErrorSource source = ErrorSource.FromClient)
        {
            var exception = new ErrorException(errors, source);
            CustomThrowServerException(exception);
            throw exception;
        }
        protected static void CustomThrowServerException(ErrorException exception)
        {
            CustomThrow(exception);
        }
        static partial void CustomThrow(ErrorException exception);
    }
}
