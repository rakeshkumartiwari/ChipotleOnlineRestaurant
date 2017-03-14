using System;
using System.Collections.Generic;
using Chipotle.Pricing.Models;

namespace Chipotle.Pricing.Infrastructure
{
    public class TaxDirectoryInMemoryRepository : ITaxDirectoryRepository
    {
        static readonly IDictionary<string, TaxDirectory> Db = new Dictionary<string, TaxDirectory>();
        public void SaveTaxDirectory(string stateName, double tax)
        {
            throw new NotImplementedException();
        }

        public List<TaxDirectory> GetTaxDirectories()
        {
            throw new NotImplementedException();
        }

        public double GetTaxByStateName(string stateName)
        {
            throw new NotImplementedException();
        }

        public void SaveTaxDirectory(TaxDirectory taxDirectory)
        {
            if (Db.ContainsKey(taxDirectory.StateName))
                Db[taxDirectory.StateName] = taxDirectory;

            Db.Add(taxDirectory.StateName, taxDirectory);
        }
    }
}