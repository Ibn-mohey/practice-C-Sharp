using System.CodeDom;

namespace mosh_csharp_intermediate.Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            DbMigrator dbMigrator = new DbMigrator(new Logger());

            Logger logger = new Logger();
            Installer installer = new Installer(logger);

            dbMigrator.Migrate();

            installer.Install();
        }
    }
}
