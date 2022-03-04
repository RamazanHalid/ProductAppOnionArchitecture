using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Application.Exceptions
{
    public class ValidationException : Exception
    {
        //I used "this" keyword here because the second constructor will be assigned automatically for the string value we wrote in "this"
        public ValidationException() : this("Validation error occured")
        {
        }
        public ValidationException(String Message) : base(Message)
        {
        }

        public ValidationException(Exception ex) : this(ex.Message)
        {
        }
    }
}
