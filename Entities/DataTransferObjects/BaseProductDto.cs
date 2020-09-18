using Entities.Enums;
using System;

namespace Entities.DataTransferObjects
{
    public abstract class BaseProductDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? Arrived { get; set; }
        public ProductAvailabilityEnum Availability { get; set; }
        public ProductTypeEnum Type { get; set; }
        public ProductSizeEnum? Size { get; set; }
    }
}