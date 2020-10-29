using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StateCodeAnalyser
{
    class CodeAdapter
    {
        protected string[] GetCodeData(string csvFilePath, string dataHeaders)
        {
            if (!File.Exists(csvFilePath))
            {
                throw new CodeAnalyserException("File Not Found", CodeAnalyserException.ExceptionType.FILE_NOT_FOUND);
            }
            if (Path.GetExtension(csvFilePath) != ".csv")
            {
                throw new CodeAnalyserException("Invalid File Type", CodeAnalyserException.ExceptionType.INVALID_FILE_TYPE);
            }
            string[] codeData = File.ReadAllLines(csvFilePath);
            if (codeData[0] != dataHeaders)
            {
                throw new CodeAnalyserException("Incorrect header in Data", CodeAnalyserException.ExceptionType.INCORRECT_HEADER);
            }
            return codeData;
        }
    }











}
