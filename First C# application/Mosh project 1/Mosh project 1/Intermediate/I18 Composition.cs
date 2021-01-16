using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_project_1.Intermediate
{

    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    /*           */

    public class DbMigrator
    {
        private readonly Logger _loggerobj;

        public DbMigrator(Logger loggerobj)

        {
            _loggerobj = loggerobj;
            
        }

        public void Migrate()
        {
            _loggerobj.Log("miggrated");
        }
    }


    /*   */
    public class Installer
    {
        private readonly Logger _loggerobj;

        public Installer(Logger loggerobj)

        {
            _loggerobj = loggerobj;

        }

        public void Install()
        {
            _loggerobj.Log("installed");
        }
    }







    /* program */
    class I18
    {
        public static void Run()
        {
            var mirgrator = new DbMigrator(new Logger());

            var loggerins = new Logger();
            var installer = new Installer(loggerins);

            mirgrator.Migrate();
            installer.Install();

        }


    }
}
