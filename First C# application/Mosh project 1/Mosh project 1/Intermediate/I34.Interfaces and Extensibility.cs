using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Mosh_project_1.Intermediate;

namespace Mosh_project_1.Intermediate
{
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);

    }

    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);
        }
    }

    /* */
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string message)
        {
            Log(message , "Error");
        }

        public void LogInfo(string message)
        {
            Log(message, "Info");
        }

        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType+": " + message);
            }

        }

    }

    /* */
    public class DbMgrate
    {
        private readonly ILogger _loggerobj;

        // dependency injection
        public DbMgrate(ILogger loggerobj)
        {
            _loggerobj = loggerobj;
        }
        public void Migrate()
        {

            _loggerobj.LogInfo("started {0}" + DateTime.Now);
            _loggerobj.LogInfo("ended {0}" + DateTime.Now);
        }
    }



    /* */
    class I34
    {
        public static void Run()
        {
            var dbmig = new DbMgrate(new FileLogger("log.txt"));
            dbmig.Migrate();
        }
    }
}
