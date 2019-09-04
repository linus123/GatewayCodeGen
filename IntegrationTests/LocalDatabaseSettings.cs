using System.Data.SqlClient;
using Birchy.GatewayCodeGen.Core.Contracts;

namespace IntegrationTests
{
    public class LocalDatabaseSettings : IDatabaseSettings
    {
        public string ConnectionString => new SqlConnectionStringBuilder
        {
            DataSource = @"(local)\sqlexpress",
            InitialCatalog = "CardShop",
            IntegratedSecurity = true
        }.ToString();
    }
}