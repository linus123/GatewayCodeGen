using System.IO;

namespace Birchy.GatewayCodeGen.Core.Contracts
{
    public interface IFileSystemCodeExporer
    {
        DiagnosticResults ExportCode(GeneratedDataAccessLayer generatedCode, DirectoryInfo baseDirectory);
    }
}