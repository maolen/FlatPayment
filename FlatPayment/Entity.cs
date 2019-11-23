using System;

namespace FlatPayment
{
    public class Entity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}