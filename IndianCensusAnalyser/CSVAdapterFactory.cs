using IndianStateCensusDemo.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensusDemo
{
    class CSVAdapterFactory
    {
        public Dictionary<string, CensusDTO> LoadCsvData(string csvFilePath, string dataHeaders)
        {
            return new IndianCensusAdapter().LoadCensusData(csvFilePath, dataHeaders);   
        }
    }
}
