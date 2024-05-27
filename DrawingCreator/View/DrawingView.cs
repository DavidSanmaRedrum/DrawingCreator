﻿using System;
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

        public Bitmap bitmap;
        private static int DEF_DRAWING_WIDTH = 250;
        private static int DEF_DRAWING_HEIGHT = 250;

        private void DrawCreator_Load(object sender, EventArgs e)
        {
            // Propiedades:
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            // Inicialización tamaño vista "DrawingView"
            Size = new Size(DEF_DRAWING_WIDTH + 33, DEF_DRAWING_HEIGHT + 58);

            // Inicialización mapa de bits.
            Controller.setDrawing(DEF_DRAWING_WIDTH, DEF_DRAWING_HEIGHT);
            bitmap = Controller.getDrawingBitmap();

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