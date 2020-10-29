using StateCodeAnalyser.POCO;
using System;
using System.Collections.Generic;
using System.Text;
using static StateCodeAnalyser.POCO.CodeDataDAO;

namespace StateCodeAnalyser.DTO
{
    public class CodeDTO
    {
        public int serialNo;
        public string stateName;
        public int TIN;
        public string stateCode;

        public CodeDTO(CodeDataDAO codeDataDao)
        {
            this.serialNo = codeDataDao.serialNo;
            this.stateName = codeDataDao.stateName;
            this.TIN = codeDataDao.TIN;
            this.stateCode = codeDataDao.stateCode;
        }
    }

}
