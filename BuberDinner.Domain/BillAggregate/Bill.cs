using BuberDinner.Domain.BillAggregate.ValueObjects;
using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.BillAggregate
{
    public sealed class Bill : AggregateRoot<BillId>
    {
        private Bill(BillId billId) : base(billId)
        {
        }

        public static Bill Create()
        {
            return new(BillId.CreateUnique());
        }
    }
}