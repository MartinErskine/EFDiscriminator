using System.Collections.Generic;
using System.Linq;

namespace EFDiscriminator.Domain
{
    public class ConfiguredLaptop
    {
        public Laptop Laptop { get; set; }

        public HashSet<ConfigurationItem> ConfigurationItems { get; set; }

        public bool Equals(ConfiguredLaptop otherConfiguredLaptop)
        {
            if (otherConfiguredLaptop is null)
                return false;

            if (ReferenceEquals(this, otherConfiguredLaptop))
                return true;

            foreach (var ConfigurationItem in ConfigurationItems)
            {
                var item = otherConfiguredLaptop.ConfigurationItems.FirstOrDefault(w => w.Id == ConfigurationItem.Id && w.Equals(ConfigurationItem));

                if (item != null)
                {
                    if (Laptop.Equals(otherConfiguredLaptop.Laptop) && item.Equals(ConfigurationItem))
                    {
                        return true;
                    }
                }

                return false;
            }

            return Laptop.Equals(otherConfiguredLaptop.Laptop)
                   && ConfigurationItems.Equals(otherConfiguredLaptop.ConfigurationItems);
        }
    }
}
