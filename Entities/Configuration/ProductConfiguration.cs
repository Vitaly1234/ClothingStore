using Entities.Enums;
using Entities.Models;
using FizzWare.NBuilder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Linq;

namespace Entities.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            var daysGenerator = new RandomGenerator();
            var products = Builder<Product>.CreateListOfSize(1000)
                .All()
                .With(x => x.Name = $"Product {x.Id}")
                .With(x => x.Description = string.Concat(Faker.Lorem.Paragraph().Take(300)))
                .With(x => x.Availability = Faker.Enum.Random<ProductAvailabilityEnum>())
                .With(x => x.Size = Faker.Enum.Random<ProductSizeEnum>())
                .With(x => x.Type = Faker.Enum.Random<ProductTypeEnum>())
                .With(x => x.Arrived = DateTime.Now.AddDays(-daysGenerator.Next(1, 100)))
                .Build().ToArray();
            builder.HasData(products);
        }
    }
}