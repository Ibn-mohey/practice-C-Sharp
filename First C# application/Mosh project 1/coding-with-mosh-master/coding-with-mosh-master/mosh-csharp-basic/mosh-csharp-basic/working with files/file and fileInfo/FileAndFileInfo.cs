using System;
using System.IO; //Used for file and FileInfo Class

namespace mosh_csharp_basic.working_with_files.file_and_fileInfo
{
    public class FileAndFileInfo
    {
        public void GetFileAndFileInfo()
        {
            string path = @"c:\somefile.jpg";

            //File.Copy("c:\\temp\\myfile.jpg", "d:\\temp\\myfile.\\jpg");

            //File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.\jpg");

            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.\jpg", true); //The method can take two arguments i.e bool to check if the file is thare

            File.Delete(path);
            if (File.Exists(path))
            {

            }

            string content = File.ReadAllText(path);

            FileInfo fileInfo = new FileInfo(path);
            fileInfo.CopyTo("....");
            fileInfo.Delete(); //It takes no parameters
            if (fileInfo.Exists) //Extists, It's not a method but a property
            {
                
            }
            
            //fileInfo.IsReadOnly 
            //FileInfo does not have a read all text method
            //It is only available as a static method in the file class 
            //with the file info you need to call the open read which returns a file stream
            // but the stream is a different way of reading a file
            //and Personally I'm not a fan of that becuase it's just a 
            //Little bit complex. Later in the section I will show you a very
            //simple way if you don't want to use IsReadOnly text

            //
            //
        }
    }
}
