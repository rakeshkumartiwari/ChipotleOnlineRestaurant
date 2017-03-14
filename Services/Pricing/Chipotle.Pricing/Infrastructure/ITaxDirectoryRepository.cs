using System.Collections.Generic;
using Chipotle.Pricing.Models;

namespace Chipotle.Pricing.Infrastructure
{
    public interface ITaxDirectoryRepository
    {
        void SaveTaxDirectory(string stateName, double tax);
        List<TaxDirectory> GetTaxDirectories();
        double GetTaxByStateName(string stateName);
    }
}