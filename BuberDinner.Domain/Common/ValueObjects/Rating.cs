using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Common.ValueObjects
{
    public sealed class Rating : ValueObject
    {
        public double Value { get; private set; }
        
        private Rating(double value)
        {
            Value = value;
        }

        public static Rating Create(double rating)
        {
            return new(rating);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

#pragma warning disable CS8618
        private Rating()
        {
        }
#pragma warning restore CS8618
    }
}