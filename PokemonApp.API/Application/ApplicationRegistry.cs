using Lamar;

namespace PokemonApp.API.Application
{
    public class ApplicationRegistry : ServiceRegistry
    {
        public ApplicationRegistry()
        {
            Scan(scanner =>
            {
                scanner.TheCallingAssembly();
                scanner.WithDefaultConventions();
                scanner.AssembliesAndExecutablesFromApplicationBaseDirectory(assembly =>
                   assembly.GetName().Name.StartsWith("PokemonApp."));
            });
        }
    }
}
