using System.Collections.Generic;
using Chipotle.Pricing.Infrastructure;
using Xunit;

namespace Chipotle.Pricing.Test
{
    public class TaxDirecctoryRepositotyTests
    {

        [Fact]
        public void ShouldSaveTaxDirectory()
        {
            var repository = new TaxDirectoryRepository();
            repository.SaveTaxDirectory("Odisha", 10.5);
            repository.SaveTaxDirectory("West Bengal", 15.5);
            repository.SaveTaxDirectory("Andhra Pradesh", 16.5);
            repository.SaveTaxDirectory("Telangana State", 18.5);
            repository.SaveTaxDirectory("Chattisgarh", 12.5);

            var taxDirectories = repository.GetTaxDirectories();

            Assert.NotNull(taxDirectories);
        }

        [Theory, MemberData("TaxData")]
        public void ShouldGetTaxByStateName(string stateName, double taxAmount)
        {
            var repository = new TaxDirectoryRepository();
            repository.SaveTaxDirectory(stateName, taxAmount);

            var tax = repository.GetTaxByStateName(stateName);

            Assert.Equal(taxAmount, tax);
        }

        public static IEnumerable<object[]> TaxData
        {
            get
            {
                yield return new object[] { "Odisha", 10.5 };
                yield return new object[] { "West Bengal", 15.5 };
                yield return new object[] { "Andhra Pradesh", 16.5 };
                yield return new object[] { "Telangana State", 18.5 };
                yield return new object[] { "Chattisgarh", 12.5 };
            }
        }

    }
}
