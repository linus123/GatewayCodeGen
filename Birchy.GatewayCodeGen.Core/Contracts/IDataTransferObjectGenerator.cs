using Birchy.GatewayCodeGen.Core.Database;

namespace Birchy.GatewayCodeGen.Core.Contracts
{
    public interface IDataTransferObjectGenerator
    {
        string GenerateCode(CodeGenerationConfiguration config, DatabaseTableDefinition tableDefinition);
    }
}