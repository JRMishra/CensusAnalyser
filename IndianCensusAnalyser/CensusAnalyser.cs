using IndianStateCensusDemo.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensusDemo
{
    public class CensusAnalyser
    {
        Dictionary<string, CensusDTO> dataMap;
        public Dictionary<string, CensusDTO> LoadCensusData(string csvFilePath, string dataHeaders)
        {
            dataMap = new CSVAdapterFactory().LoadCsvData(csvFilePath, dataHeaders);
            return dataMap;
        }

    }

}
