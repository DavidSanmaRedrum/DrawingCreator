using DrawingCreator.Model;
using DrawingCreator.View;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DrawingCreator
{
    class Controller
    {
        private static string[] FILE_FORMATS = { "PNG (*.png)|*.png", "JPG (*.jpg)|*.jpg", "ICO (*.ico)|*.ico" };
        private static Color currentColor;
        private static Drawing drawing;
        private static int[] widthAndHeightPreviousValue = { 250, 250 }; // Inicializados a tamaño por defecto.
        private static int[] PX_X_Y_VIEWS_POSITION = { 200, 220 };
        private static int nTool = 0; // Inicializamos con el "lápiz".

        public static void saveFile(string path)
        {
            const int SUB_STRING_LEN = 4; // Longitud de la extensión con el punto.
                                          //const char SEPARATOR = '|';
            Bitmap image = drawing.getDrawingBitmap();
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
                    //MessageBox.Show(currentBitmap.GetPixel(x, y).ToString());
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
            currentColor = Color.FromArgb(255, redCode, greenCode, blueCode);
            return currentColor;
        }

        public static Color getCurrentColor()
        {
            return currentColor;
        }

        public static void openOptionsView()
        {
            OptionsView optionsView = new OptionsView();
            optionsView.Show();
        }

        public static void closeDrawingView()
        {
            DrawingView drawingView = (DrawingView) getViewContext("DrawingView");
            drawingView.Close();
        }

        public static int[] getDrawingSize()
        {
            int[] values = new int[2];
            values[0] = drawing.getDrawingBitmap().Width;
            values[1] = drawing.getDrawingBitmap().Height;
            return values;
        }

        public static void setDrawing(int width, int height)
        {
            drawing = new Drawing(width, height);
        }

        public static Bitmap getDrawingBitmap()
        {
            return drawing.getDrawingBitmap();
        }

        public static void setDrawingSizeInGeneralDrawingView(int width, int height)
        {
            DrawingView drawingView = (DrawingView) getViewContext("DrawingView");
            drawingView.FindForm().Size = new Size(width + 33, height + 58); // Vista
            drawingView.Controls[0].Size = new Size(width, height); // Canvas
            Drawing newDrawing = new Drawing(width, height); // Se crea un nuevo dibujo.
            newDrawing.setPreviousInfoInBitmap(drawingView.bitmap);

            drawingView.bitmap = newDrawing.getDrawingBitmap();
            // El refrescado se debe hacer en la vista, con la instancia de la vista desde aquí no funciona.
            drawingView.refresh();
            drawing = newDrawing; // Se establece para que pueda ser obtenido y guardado. (MVC)
        }

        public static void setWidthAndHeightPreviousValue(int width, int height)
        {
            widthAndHeightPreviousValue[0] = width;
            widthAndHeightPreviousValue[1] = height;
        }

        public static int[] getWidthAndHeightPreviousValue()
        {
            return widthAndHeightPreviousValue;
        }

        public static int[] getPxXYViewsPosition()
        {
            return PX_X_Y_VIEWS_POSITION;
        }

        public static Form getViewContext(string viewName)
        {
            return Application.OpenForms[viewName];
        }

        public static void setNumberOfTool(int numberOfTool)
        {
            nTool = numberOfTool;
        }

        public static int getNumberOfTool()
        {
            return nTool;
        }

        public static void paintBucket(Color mouseDownColor)
        {
            DrawingView drawingView = (DrawingView) getViewContext("DrawingView");
            Drawing paintBucketDrawing = new Drawing();
            paintBucketDrawing.setDrawingBitmap(drawingView.bitmap);
            paintBucketDrawing.paintBucket(currentColor, mouseDownColor);
            drawingView.bitmap = paintBucketDrawing.getDrawingBitmap();
            drawingView.refresh();
            drawing = paintBucketDrawing;
        }

        public static void generalDraft()
        {
            DrawingView drawingView = (DrawingView) getViewContext("DrawingView");
            Bitmap voidBitmap = new Bitmap(drawing.getDrawingBitmap().Width, drawing.getDrawingBitmap().Height);
            drawingView.bitmap = voidBitmap;
            drawingView.refresh();
            Drawing voidDrawing = new Drawing();
            voidDrawing.setDrawingBitmap(voidBitmap);
            drawing = voidDrawing;
        }
    }
}
