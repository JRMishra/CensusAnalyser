using StateCodeAnalyser.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace StateCodeAnalyser
{
    class CSVAdapterFactory
    {
        public Dictionary<string, CodeDTO> LoadCsvData(string csvFilePath, string dataHeaders)
        {
            return new IndianCodeAdapter().LoadCodeData(csvFilePath, dataHeaders);   
        }
    }
}
