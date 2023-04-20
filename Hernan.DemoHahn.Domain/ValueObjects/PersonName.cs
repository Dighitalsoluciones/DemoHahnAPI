using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hernan.DemoHahn.Domain.ValueObjects
{
    public record PersonName
    {
        public string Value { get; init; }
        internal PersonName(string value)
        {
            this.Value = value;
        }
        public static PersonName Create(string value)
        {
            Validate(value);
            return new PersonName(value);
        }
        private static void Validate(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("El valor no puede ser Nulo");
            }
        }
    }
}
