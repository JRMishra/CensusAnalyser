using NUnit.Framework;
using StateCodeAnalyser;
using StateCodeAnalyser.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAnalysers
{
    class TestStateCodeAnalyser
    {
        static string folder = @"C:\Users\user\Desktop\Training-CapG\CensusAnaluser\StateCodeAnalyser\CsvFiles\";
                               
        static string indianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";

        static string indianStateCodeFilePath = folder + "IndiaStateCode.csv";
        
        static readonly string wrongIndianStateCodeFilePath = folder + "WrongIndiaStateCode.csv";
        static readonly string wrongHeaderIndianStateCodeFilePath = folder + "WrongHeaderIndiaStateCode.csv";
        static readonly string delimiterIndianStateCodeFilePath = folder + "DelimiterIndiaStateCode.csv";
        static readonly string wrongIndianStateCodeFileType = folder + "IndiaStateCode.txt";

        CodeAnalyser codeAnalyser;
        Dictionary<string, CodeDTO> totalRecord;
        Dictionary<string, CodeDTO> stateRecord;

        [SetUp]
        public void Setup()
        {
            codeAnalyser = new CodeAnalyser();
            totalRecord = new Dictionary<string, CodeDTO>();
            stateRecord = new Dictionary<string, CodeDTO>();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void GivenStateCodeDataFile_WhenReaded_ShouldReturnCodeDataCount()
        {
            totalRecord = codeAnalyser.LoadCodeData(indianStateCodeFilePath, indianStateCodeHeaders);
            Assert.AreEqual(37, totalRecord.Count);
        }

        [Test]
        public void GivenWrongStateCodeDataFile_WhenReaded_ShouldReturnCustomException()
        {
            var codeException = Assert.Throws<CodeAnalyserException>(() => codeAnalyser.LoadCodeData(wrongIndianStateCodeFilePath, indianStateCodeHeaders));
            Assert.AreEqual(CodeAnalyserException.ExceptionType.FILE_NOT_FOUND, codeException.eType);
        }

        [Test]
        public void GivenWrongHeaderStateCodeDataFile_WhenReaded_ShouldReturnCustomException()
        {
            var codeException = Assert.Throws<CodeAnalyserException>(() => codeAnalyser.LoadCodeData(wrongHeaderIndianStateCodeFilePath, indianStateCodeHeaders));
            Assert.AreEqual(CodeAnalyserException.ExceptionType.INCORRECT_HEADER, codeException.eType);
        }

        [Test]
        public void GivenWrongFileTypeStateCodeDataFile_WhenReaded_ShouldReturnCustomException()
        {
            var codeException = Assert.Throws<CodeAnalyserException>(() => codeAnalyser.LoadCodeData(wrongIndianStateCodeFileType, indianStateCodeHeaders));
            Assert.AreEqual(CodeAnalyserException.ExceptionType.INVALID_FILE_TYPE, codeException.eType);
        }

        [Test]
        public void GivenWrongDelimiterStateCodeDataFile_WhenReaded_ShouldReturnCustomException()
        {
            var codeException = Assert.Throws<CodeAnalyserException>(() => codeAnalyser.LoadCodeData(delimiterIndianStateCodeFilePath, indianStateCodeHeaders));
            Assert.AreEqual(CodeAnalyserException.ExceptionType.INCORRECT_DELIMITER, codeException.eType);
        }
    }
}
