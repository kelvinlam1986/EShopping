﻿using Catalog.Core.Entities;
using MongoDB.Driver;
using System.Text.Json;

namespace Catalog.Infrastructure.Data
{
    public class TypeContextSeed
    {
        public static void SeedData(IMongoCollection<ProductType> typeCollection)
        {
            bool checkTypes = typeCollection.Find(b => true).Any();
            string path = Path.Combine("Data", "SeedData", "types.json");
            if (!checkTypes)
            {
                var typeData = File.ReadAllText(path);
                var types = JsonSerializer.Deserialize<List<ProductType>>(typeData);
                if (types != null)
                {
                    foreach (var productType in types)
                    {
                        typeCollection.InsertOneAsync(productType);
                    }
                }
            }
        }
    }
}
