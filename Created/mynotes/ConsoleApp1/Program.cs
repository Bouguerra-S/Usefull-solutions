using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
//using System.Drawing;
using System.IO;

namespace scanMyNotes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get all jpeg file names in this folder
            string currentdir = Environment.CurrentDirectory;
            List<string> myJpegs = new List<string>();
            myJpegs.AddRange(new List<string>(Directory.GetFiles(currentdir, "*.jpeg")));
            myJpegs.AddRange(new List<string>(Directory.GetFiles(currentdir, "*.jpg")));

            List<Bitmap> myNotes = new List<Bitmap>();
            //for each file get list of notes one note per circle (not really a circle)
            foreach (var jpegFile in myJpegs)
            {
                Bitmap myBitmap = new Bitmap(jpegFile);
                string outputfile = currentdir + "\\notes" + jpegFile.Replace(currentdir, "");

                Image<Bgr, byte> myImage = new Image<Bgr, byte>(jpegFile);
                Image<Gray, byte> ImgCanny = new Image<Gray, byte>(myImage.Width, myImage.Height, new Gray(0));
                ImgCanny = myImage.Canny(500, 90);





                if (!Directory.Exists(currentdir + "\\notes"))
                {
                    Directory.CreateDirectory(currentdir + "\\notes");
                }
                byte[] bitmap = ImgCanny.ToJpegData();

                using (Image image = Image.FromStream(new MemoryStream(bitmap)))
                {
                    image.Save(outputfile, System.Drawing.Imaging.ImageFormat.Jpeg);  // Or Png
                }
                
                
                //myBitmap.Save(outputfile, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            // for each note find text and tags

            //now i have note text and note tags

            // for each note find actions and apply them
            Console.WriteLine("script is finished");
        }
    }
}
