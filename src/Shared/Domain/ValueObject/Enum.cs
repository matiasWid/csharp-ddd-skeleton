using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CodelyTv.Shared.Domain.ValueObject
{
    public abstract class Enum : ValueObject, Stringable
    {
        private static List<String> cache = new List<String>();
        public string Value { get; }
        protected Enum(string value)
        {
            ensureIsBetweenAcceptedValues(value);
            Value = value;
        }

        private void ensureIsBetweenAcceptedValues(string value)
        {
            if (cache.Count < 1)
                GetConstants();

            if (!cache.Contains(value))
                throw new InvalidEnumArgumentException(value);

        }

        public override string ToString()
        {
            return Value;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;

            var item = obj as StringValueObject;
            if (item == null) return false;

            return Value == item.Value;
        }

        private void GetConstants()
        {
            foreach (var constant in this.GetType().GetFields())
            {
                if (constant.IsLiteral && !constant.IsInitOnly)
                    cache.Add((string)constant.GetValue(this));

            }
        }
    }
}
