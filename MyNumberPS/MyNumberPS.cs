using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Management.Automation;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using MyNumberNET;

namespace MyNumberPS
{
    [Cmdlet(VerbsCommon.Get, "MyNumber")]
    [OutputType(typeof(int[]))]
    [OutputType(typeof(string))]
    public class GetMyNumber : Cmdlet
    {
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = false, HelpMessage = "Generate MyNumber in string format.")]
        public SwitchParameter String { get; set; }
    
        private MyNumber _myNumber;
        
        protected override void BeginProcessing()
        {
            _myNumber = new MyNumber();
        }

        protected override void ProcessRecord()
        {
            if (String)
            {
                WriteObject(string.Join("", _myNumber.GenerateRandomNumber()));
            }
            else
            {
                WriteObject(_myNumber.GenerateRandomNumber());
            }
        }
    }

    [Cmdlet(VerbsDiagnostic.Test, "MyNumber")]
    [OutputType(typeof(bool))]
    public class TestMyNumber : Cmdlet
    {
        private bool _result;
        
        [ValidateNotNullOrEmpty]
        [Parameter(Position = 0, Mandatory = true, HelpMessage = "MyNumber to test.")]
        public object MyNumberData { get; set; }
        
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = false,
            HelpMessage =
                "Type of data input (string for text string, and array for integer array)")]
        [ValidateSet("string", "array")]
        public string DataType = "array";

        protected override void ProcessRecord()
        {
            switch (DataType)
            {
                case "string":
                {
                    var data = (string) MyNumberData;
                    _result = MyNumber.VerifyNumber(data.Select(c => c - '0').ToArray());
                    break;
                }

                case "array":
                {
                    _result = MyNumber.VerifyNumber(((object[]) MyNumberData).Cast<int>().ToArray());
                    break;
                }
            }
        }

        protected override void EndProcessing()
        {
            WriteObject(_result);
        }
    }
}
