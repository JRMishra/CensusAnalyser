using StateCodeAnalyser.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace StateCodeAnalyser
{
    public class CodeAnalyser
    {
        Dictionary<string, CodeDTO> dataMap;
        public Dictionary<string, CodeDTO> LoadCodeData(string csvFilePath, string dataHeaders)
        {
            dataMap = new CSVAdapterFactory().LoadCsvData(csvFilePath, dataHeaders);
            return dataMap;
        }

    }

}
