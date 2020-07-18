using DDD.WinForm.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.ValueObjects
{
    public sealed class Temperature
    {
        public const string UnitName = "℃";
        public const int DecimalPoint = 2;

        public float Value { get; }

        public Temperature(float value)
        {
            Value = value;
        }

        public string DisplayValue
        {
            get
            {
                return CommonFunc.RoundString(Value, DecimalPoint) + " " + UnitName;
            }
        }
    }
}
