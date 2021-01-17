using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_project_1.Advanced
{
    // is ref for methods


    public class Photo
    {
        public static Photo Load(string path)
        {
            return new Photo();
        }

        public void Save()
        {

        }
    }

    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize photo");
        }
    }

    public class PhotoProcessor
    {
       // public delegate void PhotoFilterHandler(Photo photo);

        // we can use built in delegate 
        // system.action > generic and non generic > void
        // system.func > value

        //public void Process(string path, PhotoFilterHandler filterHandler) //pass handler
        public void Process(string path, Action<Photo> filterHandler)

        {
            var photo = Photo.Load(path);

            filterHandler(photo); // doesnt know what filter will be applied 

            photo.Save();
        }
    }



    class AD06
    {
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");

        }


        public static void Run()
        {
            var processor = new PhotoProcessor(); // instantiated
            var filters = new PhotoFilters();  // create instance of photofilter
            //PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness; // creat instance of this delegate
            Action <Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg", filterHandler);
        }


    }
    
}
