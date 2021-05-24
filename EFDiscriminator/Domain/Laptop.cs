using System;

namespace EFDiscriminator.Domain
{
    public class Laptop
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }

        public bool Equals(Laptop otherLaptop)
        {
            if (otherLaptop is null)
                return false;

            if (ReferenceEquals(this, otherLaptop))
                return true;

            return Id.Equals(otherLaptop.Id)
                   && Name.Equals(otherLaptop.Name)
                   && Price.Equals(otherLaptop.Price);
        }
    }
}
