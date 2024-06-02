using System;
using System.Drawing;

namespace DrawingCreator.Model
{
    class Drawing
    {
        private Bitmap bitmap;

        public Drawing(int width, int height)
        {
            this.bitmap = new Bitmap(width, height);
        }

        public Bitmap getDrawingBitmap()
        {
            return this.bitmap;
        }

        public void setPreviousInfoInBitmap(Bitmap previousBitmap)
        {
            int widthRest = this.bitmap.Width - previousBitmap.Width;
            int heightRest = this.bitmap.Height - previousBitmap.Height;
            if (widthRest < 0) {
                widthRest = Math.Abs(widthRest);
            } else { widthRest = 0; }
            if (heightRest < 0) {
                heightRest = Math.Abs(heightRest);
            } else { heightRest = 0; }
            for (int x = 0; x < previousBitmap.Width - widthRest; x++)
            {
                for (int y = 0; y < previousBitmap.Height - heightRest; y++)
                {
                    this.bitmap.SetPixel(x, y, previousBitmap.GetPixel(x, y));
                }
            }
        }

        public void paintBucket(Color mainColor, Color mouseDownColor)
        {
            // mainColor es el color con el que vamos a pintar.
            // mouseDownColor es el color que vamos a convertir en mainColor.
            for (int x = 0; x < this.bitmap.Width; x++)
            {
                for (int y = 0; y < this.bitmap.Height; y++)
                {
                    if (this.bitmap.GetPixel(x, y).Equals(mouseDownColor)) this.bitmap.SetPixel(x, y, mainColor);
                }
            }
        }

        public void zoom(int percent)
        {
            Bitmap copy = this.bitmap;
            this.bitmap = new Bitmap(copy, copy.Width + (percent * copy.Width / 100), copy.Height + (percent * copy.Height / 100));
            Graphics graphics = Graphics.FromImage(this.bitmap);
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
        }

    }
}
