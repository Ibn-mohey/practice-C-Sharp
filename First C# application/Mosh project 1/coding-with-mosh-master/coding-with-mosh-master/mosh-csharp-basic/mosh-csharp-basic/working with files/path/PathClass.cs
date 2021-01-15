using System;
using System.IO;

namespace mosh_csharp_basic.working_with_files.path
{
    class PathClass
    {
        public void GetPath()
        {
            //This class provides a number of methods that makes it easy to work with a string
            //that represent a path and extract different parts of that path
            //So we don't have to do the string process ourselves e.g;

            //See this path like this if we want to extract only the extension here and sell
            //in the poor way of doing that used to used to use the string class and search for index of say Dot

            string path = @"C:C:\Users\sonol\Downloads\_pcloud\_repositories\github\coding-with-mosh\mosh-csharp-basic\mosh-csharp-basic.sln";

            //Used this to search for the dot and that would return the dog team next.
            int dotIndex = path.IndexOf('.');

            //And then I can say past a substring from that dot index that would return the extension.
            string extension = path.Substring(dotIndex);

            //So we don't want to do at these low level string processing ourself
            //And that's when we use the **Path Class**

            //So with the path we can say get extension now that this is a static method
            //we can't provide our past

            //Console.WriteLine("Extension: " + Path.GetExtension(path)); //we can provide the our path variable here and to simple display the result on the console
            Console.WriteLine($"Extension:{Path.GetExtension(path)}"); //Alternate way

            //Or we can use dot get file name to only extract the name namme in that path
            Console.WriteLine($"File Name: {Path.GetFileName(path)}");
            Console.WriteLine($"File Name without Extension: {Path.GetFileNameWithoutExtension(path)}");
            Console.WriteLine($"Directory Name: {Path.GetDirectoryName(path)}");

            //Path Class make it easy to work with a string that represent a path
            //Has a look at MSD Documentation for more insight about the many methods you can use





        }
    }
}
