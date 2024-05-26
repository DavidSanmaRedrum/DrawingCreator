using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingCreator
{
    public partial class DrawingView : Form
    {
        public DrawingView()
        {
            InitializeComponent();
        }

        private int WIDTH = 250;
        private int HEIGHT = 250;
        private Bitmap bitmap;

        private void DrawCreator_Load(object sender, EventArgs e)
        {
            // Propiedades
            //ControlBox = false;

            // Inicialización mapa de bits.
            Controller.setDrawingSize(WIDTH, HEIGHT);
            bitmap = Controller.getDrawingBitmap();
            //bitmap = new Bitmap(WIDTH, HEIGHT);
            CanvasBox.Size = new Size(bitmap.Width, bitmap.Height);
            CanvasBox.BorderStyle = BorderStyle.Fixed3D;

            // Abrir vista de opciones.
            Controller.openOptionsView();
        }

        private void CanvasBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Left)
                && e.X < bitmap.Width
                && e.X > -1
                && e.Y < bitmap.Height
                && e.Y > -1)
            {
                bitmap.SetPixel(e.X, e.Y, Controller.getCurrentColor());
                CanvasBox.Image = bitmap;
            }
        }

        private void CanvasBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Left)
                && e.X < bitmap.Width
                && e.X > -1
                && e.Y < bitmap.Height
                && e.Y > -1)
            {
                bitmap.SetPixel(e.X, e.Y, Controller.getCurrentColor());
                CanvasBox.Image = bitmap;
            }

        }
    }
}