using System;
using System.Collections.Generic;
using System.Text;

namespace StateCodeAnalyser.POCO
{
    public class CodeDataDAO
    {
        //SrNo,State Name,TIN,StateCode
        public int serialNo;
        public string stateName;
        public int TIN;
        public string stateCode;

        public CodeDataDAO(string serialNo, string stateName, string TIN, string stateCode)
        {
            this.serialNo = Int32.Parse(serialNo);
            this.stateName = stateName;
            this.TIN = Int32.Parse(TIN);
            this.stateCode = stateCode;
        }
    }
}
