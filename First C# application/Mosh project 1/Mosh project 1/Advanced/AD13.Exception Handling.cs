using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Mosh_project_1.Advanced
{
    public class Calculator
    {
        public int Divide(int numerator, int denomenator)
        {
            return numerator / denomenator;
        }
    }

        // public class Video
        // {
        // }


        public class YouTubeException : Exception
        {
            public YouTubeException(string message, Exception innerException)
                : base(message, innerException)
            {
            }
        }

        public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access YouTube web service 
                // Read the data 
                // Create a list of Video objects
                throw new Exception("Oops some low level YouTube error.");
            }
            catch (Exception ex)
            {
                // Log 

              throw new YouTubeException("Could not fetch the videos from YouTube.", ex);
            }

            return new List<Video>();
        }
    }



    class AD13
    {
        public static void Run()
        {
            // try
            // {
            //     var calculator = new Calculator();
            //     var result = calculator.Divide(5, 0);
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine(e);
            //     Console.WriteLine("Sorry /0 cant happen");
            // }
            // StreamReader streamReaded = null;
            // try
            // {
            //     streamReaded = new StreamReader("");
            //     var content = streamReaded.ReadToEnd();
            //     throw new Exception("opps");
            //
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine(e);
            //     Console.WriteLine("cant");
            // }
            // finally
            // {
            //     if (streamReaded != null)
            //     {
            //         streamReaded.Dispose();
            //     }
            // }

            try
            {
                using (var streamReaded = new StreamReader(""))
                {
                    var content = streamReaded.ReadToEnd();
                }
                throw new Exception("opps");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("cant");
            }

            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("mosh");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
