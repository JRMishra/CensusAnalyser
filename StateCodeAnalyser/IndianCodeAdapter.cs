using StateCodeAnalyser.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateCodeAnalyser
{
    class IndianCodeAdapter : CodeAdapter
    {
        string[] codeData;
        Dictionary<string, CodeDTO> dataMap;
        public Dictionary<string, CodeDTO> LoadCodeData(string csvFilePath, string dataHeaders)
        {
            dataMap = new Dictionary<string, CodeDTO>();
            codeData = GetCodeData(csvFilePath, dataHeaders);
            foreach (string data in codeData.Skip(1))
            {
                if (!data.Contains(","))
                {
                    throw new CodeAnalyserException("File contains wrong delimiter", CodeAnalyserException.ExceptionType.INCORRECT_DELIMITER);
                }
                string[] column = data.Split(",");
                if (csvFilePath.Contains("IndiaStateCode.csv"))
                    dataMap.Add(column[0], new CodeDTO(new POCO.CodeDataDAO(column[0], column[1], column[2], column[3])));
            }
            return dataMap.ToDictionary(p => p.Key, p => p.Value);
        }
    }
}
