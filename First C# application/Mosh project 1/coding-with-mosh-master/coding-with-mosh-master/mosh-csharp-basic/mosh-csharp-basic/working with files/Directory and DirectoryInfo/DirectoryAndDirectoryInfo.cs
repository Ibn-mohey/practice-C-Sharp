using System;
using System.IO; //This is also used with Directory and DirectoryInfo

namespace mosh_csharp_basic.working_with_files.Directory_and_DirectoryInfo
{
    class DirectoryAndDirectoryInfo
    {
        public void GetDirectoryAndDirectoryInfo()
        {
            Directory.CreateDirectory(@"c:\temp\folder1");

            //string[] files = Directory.GetFiles(@"C:\Users\sonol\Downloads\_pcloud\_repositories\github\coding-with-mosh", "*.*", SearchOption.AllDirectories);
            //This returns all files in every directory and every sub-directory starting from "c" drive

            string[] files = Directory.GetFiles(@"C:\Users\sonol\Downloads\_pcloud\_repositories\github\coding-with-mosh", "*.sln*", SearchOption.AllDirectories);
            //This returns only .sln files in every directory and every sub-directory starting from "c" drive

            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}

            //var directories = Directory.GetDirectories(@"C:\Users\sonol\Downloads\_pcloud\_repositories\github\coding-with-mosh", "*.*", SearchOption.AllDirectories);
            ////This returns only the directories
            //foreach (var directory in directories)
            //{
            //    Console.WriteLine(directory);
            //}


            bool IsDirectoryExist = Directory.Exists(@"C:\Users\sonol\Downloads\_pcloud\_repositories\github\coding-with-mosh");

            Console.WriteLine(IsDirectoryExist);

            //***The difference Directory vs DirectoryInfo

            DirectoryInfo directoryInfo = new DirectoryInfo(@"C: \Users\sonol\Downloads\_pcloud\_repositories\github\coding-with-mosh"); //This is like the other method of Directory Class
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
            

        }
    }
}
