using IndianCensusAnalyser;
using IndianCensusAnalyser.DTO;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestAnalysers
{
    public class TestCensusAnalyser
    {
        //CensusAnalyser.CensusAnalyser censusAnalyser;
        static string folder = @"C:\Users\user\Desktop\Training-CapG\CensusAnaluser\IndianCensusAnalyser\CsvFiles\";

        static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
        
        static string indianStateCensusFilePath = folder + "IndiaStateCensusData.csv";

        static readonly string wrongIndianStateCensusFilePath = folder + "WrongIndiaStateCensusData.csv";
        static readonly string wrongHeaderIndianStateCensusFilePath = folder + "WrongHeaderIndiaStateCensusData.csv";
        static readonly string delimiterIndianStateCensusFilePath = folder + "DelimiterIndiaStateCensusData.csv";
        static readonly string wrongIndianStateCensusFileType = folder + "IndiaStateCensusData.txt";
        
        CensusAnalyser censusAnalyser;
        Dictionary<string, CensusDTO> totalRecord;
        Dictionary<string, CensusDTO> stateRecord;

        [SetUp]
        public void Setup()
        {
            censusAnalyser = new CensusAnalyser();
            totalRecord = new Dictionary<string, CensusDTO>();
            stateRecord = new Dictionary<string, CensusDTO>();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void GivenIndianCensusDataFile_WhenReaded_ShouldReturnCensusDataCount()
        {
            totalRecord = censusAnalyser.LoadCensusData(indianStateCensusFilePath, indianStateCensusHeaders);
            Assert.AreEqual(29, totalRecord.Count);
        }

        [Test]
        public void GivenWrongIndianCensusDataFile_WhenReaded_ShouldReturnCustomException()
        {
            var censusException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(wrongIndianStateCensusFilePath, indianStateCensusHeaders));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.FILE_NOT_FOUND, censusException.eType);
        }
        
        [Test]
        public void GivenWrongHeaderIndianCensusDataFile_WhenReaded_ShouldReturnCustomException()
        {
            var censusException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(wrongHeaderIndianStateCensusFilePath, indianStateCensusHeaders));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INCORRECT_HEADER, censusException.eType);
        }
        
        [Test]
        public void GivenWrongFileTypeIndianCensusDataFile_WhenReaded_ShouldReturnCustomException()
        {
            var censusException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(wrongIndianStateCensusFileType, indianStateCensusHeaders));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INVALID_FILE_TYPE, censusException.eType);
        }
        
        [Test]
        public void GivenWrongDelimiterIndianCensusDataFile_WhenReaded_ShouldReturnCustomException()
        {
            var censusException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(delimiterIndianStateCensusFilePath, indianStateCensusHeaders));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INCORRECT_DELIMITER, censusException.eType);
        }

    }
}