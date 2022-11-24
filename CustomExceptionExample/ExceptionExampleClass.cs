using System;

namespace CustomExceptionExample
{
    public class ExceptionExampleClass : Exception
    {
        public string InvalidName()
        {
            return "Name should not contain numbers or to be emty!";
        }
    }
}
