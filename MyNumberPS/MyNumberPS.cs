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
    [OutputType(typeof(MyNumberData))]
    public class GetMyNumber : Cmdlet
    {
        private MyNumber _myNumber;
        private MyNumberData _result;
        
        protected override void BeginProcessing()
        {
            _myNumber = new MyNumber();
            _result = new MyNumberData();
        }

        protected override void ProcessRecord()
        {
            _result.NumberSequence = _myNumber.GenerateRandomNumber();
        }

        protected override void EndProcessing()
        {
            WriteObject(_result);
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
                "Type of data input (data for MyNumberData, string for text string, and array for integer array")]
        [ValidateSet("data", "string", "array")]
        public string DataType = "data";

        protected override void ProcessRecord()
        {
            switch (DataType)
            {
                case "data":
                {
                    var data = (MyNumberData) MyNumberData;
                    _result = MyNumber.VerifyNumber(data.NumberSequence);
                    break;
                }

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

public class MyNumberData
{
    public int[] NumberSequence;
    public override string ToString()
    {
        return string.Join("", NumberSequence);
    }
}