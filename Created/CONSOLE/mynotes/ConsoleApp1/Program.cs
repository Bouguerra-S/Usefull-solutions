using Emgu.CV;
using Emgu.CV.Structure;
using scanmynotes;
using System;
using System.Collections.Generic;
using System.Drawing;
//using System.Drawing;
using System.IO;

namespace scanmynotes
{
    public class Program
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

                Image<Bgr, byte> myImage = new Image<Bgr, byte>(jpegFile);
                Image<Gray, byte> ImgCanny = new Image<Gray, byte>(myImage.Width, myImage.Height, new Gray(0));
                ImgCanny = myImage.Canny(310, 90);




                if (!Directory.Exists(currentdir + "\\notes"))
                {
                    Directory.CreateDirectory(currentdir + "\\notes");
                }
                byte[] bitmap = ImgCanny.ToJpegData();
                Bitmap transformedBitMap;

                using (var ms = new MemoryStream(bitmap))
                {
                    transformedBitMap = new Bitmap(ms);
                }

                //find list x y w h
                List<zone> noteszones = calculerZonesNotes(transformedBitMap);
                foreach (zone thiszone in noteszones)
                {
                    myNotes.Add(transformedBitMap.Clone(new System.Drawing.Rectangle(thiszone.X, thiszone.Y, thiszone.W, thiszone.H), transformedBitMap.PixelFormat));
                }


                using (Image image = Image.FromStream(new MemoryStream(bitmap)))
                {

                    string outputfile = currentdir + "\\notes" + jpegFile.Replace(currentdir, "");
                    image.Save(outputfile, System.Drawing.Imaging.ImageFormat.Jpeg);  // Or Png
                }


                // for each note find text and tags
                int i = 0;
                foreach (var item in myNotes)
                {

                    string outputfile = currentdir + "\\notes" + jpegFile.Replace(currentdir, "");
                    outputfile.Replace(".jpg", i + ".jpg");
                    item.Save(outputfile, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
            //now i have note text and note tags

            // for each note find actions and apply them
            Console.WriteLine("script is finished");
        }

        private static List<zone> calculerZonesNotes(Bitmap transformedBitMap)
        {
            List<zone> result = new List<zone>();
            result.Add(new zone(0, 0, 200, 200));
            result.Add(new zone(200, 200, 200, 200));
            result.Add(new zone(400, 400, 200, 200));
            result.Add(new zone(600, 600, 200, 200));
            return result;
        }
    }
}
