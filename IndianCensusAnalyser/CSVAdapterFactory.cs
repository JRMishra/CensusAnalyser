using IndianCensusAnalyser.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IndianCensusAnalyser
{
    class CSVAdapterFactory
    {
        public Dictionary<string, CensusDTO> LoadCsvData(string csvFilePath, string dataHeaders)
        {
            return new IndianCensusAdapter().LoadCensusData(csvFilePath, dataHeaders);   
        }
    }
}
