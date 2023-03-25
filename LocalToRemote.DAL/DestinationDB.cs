using Microsoft.Azure.Cosmos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LocalToRemote.DAL
{
    public class DestinationDB
    {
        private readonly CosmosClient _cosmosClient;
        private readonly Container _container;

        public DestinationDB(string connectionString, string databaseName, string containerName)
        {
            _cosmosClient = new CosmosClient(connectionString);
            _container = _cosmosClient.GetContainer(databaseName, containerName);
        }

        public async Task CreateDatabaseAsync(string databaseName)
        {
            await _cosmosClient.CreateDatabaseIfNotExistsAsync(databaseName);
        }

        public async Task CreateContainerAsync(string databaseName, string containerName, string partitionKeyPath)
        {
            var database = _cosmosClient.GetDatabase(databaseName);
            await database.CreateContainerIfNotExistsAsync(containerName, partitionKeyPath);
        }

        public async Task ImportProductsAsync(IEnumerable<Product> products)
        {
            foreach (var product in products)
            {
                await _container.UpsertItemAsync(product, new PartitionKey(product.SupplierID.ToString()));
            }
        }

        // Add other methods for querying Cosmos DB as needed
    }
}
}
