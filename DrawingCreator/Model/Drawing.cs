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

    }
}
