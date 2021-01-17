using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mosh_project_1.Advanced
{
    public class Video
    {
        public string Title { get; set;}
    }


    // method to confirms with signature and the subscribers
    public class MailService
    {
        public void OnVideoEncoded(object obj, VideoEventArgs e)
        {
            Console.WriteLine("Mailed" + e.Video.Title);
        }
    }

    public class MessageService
    {
        public void OnVideoEncoded(object obj, VideoEventArgs e)
        {
            Console.WriteLine("texted " + e.Video.Title);
        }
    }

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }

    }

    public class VideoEncoder
    {

        //  1- delegate
        //  2- event
        //  3- sent envent

        //  1- delegate
        //public delegate void VideoEncodedEventHandler(object obj, VideoEventArgs args); 1 deleted

        //  2- event
        //public event VideoEncodedEventHandler Videoenced; 2 deleted

        //  1- delegate
        //  2- event
        public event EventHandler<VideoEventArgs> Videoenced;

        //  3- sent envent
        protected virtual void OnVideoEncoded(Video vid1)
        {
            if (Videoenced != null)
            {
                Videoenced(this ,new VideoEventArgs() {Video = vid1 });
            }
        }

        
        /* main class contents */
        public void Encode(Video vid1)
        {
            Console.WriteLine("encoding video....");
            Thread.Sleep(2000);
            OnVideoEncoded(vid1);
        }

    }

    class AD08
    {
        public static void Run()
        {
            var vid = new Video() {Title = "Vid1"};
            var videnc = new VideoEncoder(); // publisher
            var mailser = new MailService(); // subscriber
            var messega = new MessageService(); // subscriber


            videnc.Videoenced += mailser.OnVideoEncoded; // regester a handler to the event
            videnc.Videoenced += messega.OnVideoEncoded;

            videnc.Encode(vid);
        }
    }
}
