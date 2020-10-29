using System;
using System.Collections.Generic;
using System.Text;

namespace StateCodeAnalyser
{
    public class CodeAnalyserException : Exception
    {
        public enum ExceptionType
        {
            FILE_NOT_FOUND,
            INVALID_FILE_TYPE,
            INCORRECT_DELIMITER,
            INCORRECT_HEADER,
            NO_SUCH_COUNTRY
        }
        
        public ExceptionType eType;
        public CodeAnalyserException(string message, ExceptionType exceptionType) : base(message)
        {
            this.eType = exceptionType;
        }

    }
}
