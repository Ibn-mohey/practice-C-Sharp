using System;
using System.IO;

namespace Mosh_project_1.walkthrow
{
    public class working_with_files
    {
        /* file info > instance security check in is done inly once during creation of the file info object */
        /* fil > static > every time check in for each file more time if alot of files */
        public static void Run()
        {
            // var fromPath = @"E:\career\Dataa\github\practice-C#\First C# application\Mosh project 1";
            // var toPath = @"E:\career\Dataa\github\practice-C#\First C# application\Mosh project 1\Mosh project 1";
            /*
            File.
                copy
                delete
            if (File.Exists()) {}
            File.Read
            File.Replace
             */
            /*
             var fileInfo = new FileInfo(path);
             fileInfo.CopyTo(anotherPath);
             fileInfo.Delete();
             Directory.Create
             .CreateDirectory()
             .GetFiles()

             */

            var files = Directory.GetFiles(@"E:\career\Dataa\github\practice-C#\First C# application\Mosh project 1\Mosh project 1", "*.*" ,SearchOption.AllDirectories);
            foreach (var file in files)
                Console.WriteLine(file);
            // Path.GetExtension(wantedpath);
            // Path.GetFileName(wantedfile);
        }


    }
}