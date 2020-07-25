using System;

namespace DDD.Domain.ValueObjects
{
    public sealed class AreaId : ValueObject<AreaId>
    {

        public int Value { get; }

        public AreaId(int value)
        {
            Value = value;
        }
        protected override bool EqualsCore(AreaId other)
        {
            return Value == other.Value;
        }

        public string DisplayValue
        {
            get
            {
                return Value.ToString().PadLeft(4, '0');
            }
        }
    }
}
