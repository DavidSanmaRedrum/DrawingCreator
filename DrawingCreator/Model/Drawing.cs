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
            for(int x = 0; x < previousBitmap.Width - widthRest; x ++)
            {
                for(int y = 0; y < previousBitmap.Height - heightRest; y ++)
                {
                    this.bitmap.SetPixel(x, y, previousBitmap.GetPixel(x, y));  
                }
            }
        }

    }
}
