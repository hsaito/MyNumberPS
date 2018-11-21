using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using MyNumberNET;

namespace MyNumberPS
{
    [Cmdlet(VerbsCommon.Get, "MyNumber")]
    [OutputType(typeof(int[]))]
    [OutputType(typeof(string))]
    public class GetMyNumber : Cmdlet
    {
        private MyNumber _myNumber;

        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = false, HelpMessage = "Generate MyNumber in string format.")]
        public SwitchParameter String { get; set; }

        protected override void BeginProcessing()
        {
            _myNumber = new MyNumber();
        }

        protected override void ProcessRecord()
        {
            if (String)
                WriteObject(string.Join("", _myNumber.GenerateRandomNumber()));
            else
                WriteObject(_myNumber.GenerateRandomNumber());
        }
    }

    [Cmdlet(VerbsCommon.Get, "MyNumberRange")]
    [OutputType(typeof(int[][]))]
    [OutputType(typeof(string))]
    public class GetMyNumberRange : Cmdlet
    {
        private MyNumber _myNumber;

        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = false, HelpMessage = "Generate MyNumber in string format.")]
        public SwitchParameter String { get; set; }

        [Parameter(Position = 0, Mandatory = true, HelpMessage = "Minimum value for MyNumber generation.")]
        public ulong Minimum { get; set; }

        [Parameter(Position = 1, Mandatory = true, HelpMessage = "Maximum value for MyNumber generation.")]
        public ulong Maximum { get; set; }

        protected override void BeginProcessing()
        {
            _myNumber = new MyNumber();
            if (Minimum > 999999999999 || Maximum > 999999999999)
                throw new MyNumberPSMyNumberOutOfBoundException("Range value out of bound.");
        }

        protected override void ProcessRecord()
        {
            if (String)
            {
                var result = new List<string>();
                for (var i = Minimum; i < Maximum; i++)
                    if (MyNumber.VerifyNumber(Fill(i.ToString()).Select(c => c - '0').ToArray()))
                        result.Add(Fill(i.ToString()));

                WriteObject(result.ToArray());
            }
            else
            {
                var result = new List<int[]>();

                for (var i = Minimum; i < Maximum; i++)
                {
                    var numArray = Fill(i.ToString()).Select(c => c - '0').ToArray();
                    if (MyNumber.VerifyNumber(numArray)) result.Add(numArray);
                }

                WriteObject(result.ToArray());
            }
        }

        private string Fill(string input)
        {
            var reminder = 12;

            reminder = reminder - input.Length;
            if (reminder == 0) return input;
            for (var i = 0;
                i < reminder;
                i++)
                input = "0" + input;
            return input;
        }
    }

    [Cmdlet(VerbsDiagnostic.Test, "MyNumber")]
    [OutputType(typeof(bool))]
    public class TestMyNumber : Cmdlet
    {
        private bool _result;

        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = false,
            HelpMessage =
                "Type of data input (string for text string, and array for integer array)")]
        [ValidateSet("string", "array")]
        public string DataType = "array";

        [ValidateNotNullOrEmpty]
        [Parameter(Position = 0, Mandatory = true, HelpMessage = "MyNumber to test.")]
        public object MyNumberData { get; set; }

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