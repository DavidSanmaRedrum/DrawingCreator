using DrawingCreator.Model;
using DrawingCreator.View;
using System;
using System.Drawing;
using System.IO;

namespace DrawingCreator
{
    class Controller
    {
        private static string[] FILE_FORMATS = { "PNG (*.png)|*.png", "JPG (*.jpg)|*.jpg", "ICO (*.ico)|*.ico" };
        private static Color currentColor;
        private static Drawing drawing;

        public static void saveFile(string path, Bitmap image)
        {
            const int SUB_STRING_LEN = 4; // Longitud de la extensión con el punto.
                                          //const char SEPARATOR = '|';

            switch (path.Substring(path.Length - SUB_STRING_LEN, SUB_STRING_LEN))
            {
                case ".png":
                    image.Save(path);
                    break;
                case ".jpg":
                    image.Save(path);
                    break;
                case ".ico":
                    IntPtr pointer = image.GetHicon();
                    Icon icon = Icon.FromHandle(pointer);
                    FileStream fs = new FileStream(path, FileMode.Create);
                    icon.Save(fs);
                    break;
            }
        }

        public static string getFileFormats()
        {
            string formats = "";
            string separator = "|";
            for (int pos = 0; pos < FILE_FORMATS.Length; pos++)
            {
                if (pos == FILE_FORMATS.Length - 1) separator = "";
                formats += FILE_FORMATS[pos] + separator;
            }
            return formats;
        }

        public static bool isCanvasVoid() // Provisional
        {
            bool isPixelVoid = true;
            Bitmap currentBitmap = drawing.getDrawingBitmap();
            for (int x = 0; x < currentBitmap.Width; x++)
            {
                for (int y = 0; y < currentBitmap.Height; y++)
                {
                    if (!currentBitmap.GetPixel(x, y).Equals(Color.FromArgb(0, 0, 0, 0)))
                    {
                        isPixelVoid = false;
                        y = currentBitmap.Height;
                        x = currentBitmap.Width;
                    }
                }
            }
            return isPixelVoid;
        }

        public static Color getRGBColorWithMix(int redCode, int greenCode, int blueCode)
        {
            currentColor = Color.FromArgb(redCode, greenCode, blueCode);
            return currentColor;
        }

        public static Color getCurrentColor()
        {
            return currentColor;
        }

        public static void openOptionsView()
        {
            var optionsView = new OptionsView();
            optionsView.Show();
        }

        public static void setDrawingSize(int width, int height)
        {
            drawing = new Drawing(width, height);
        }

        public static Bitmap getDrawingBitmap()
        {
            return drawing.getDrawingBitmap();
        }

    }
}
