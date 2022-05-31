using System;
using System.Collections.Generic;


namespace StringCalculator.models
{
    public class ValidatorResult
    {
        public List<int> ValidNumbers { get; set; }
        public List<int> InvalidNumbers { get; set; }

        public ValidatorResult()
        {
            ValidNumbers = new List<int>();
            InvalidNumbers = new List<int>();
        }
    }
}
