using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingCreator.View
{
    public partial class OptionsView : Form
    {
        public OptionsView()
        {
            InitializeComponent();
        }

        private const int MINIMUM_SCROLL_VALUE = 0;
        private const int MAXIMUM_SCROLL_VALUE = 264;
        private const int MIN_PX_RANK = 32;
        private const int MAX_PX_RANK = 1000;
        private const int PX_EXTRA_SEP = 30;

        private void OptionsView_Load(object sender, EventArgs e)
        {
            // Propiedades:
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            int[] viewPositionsInDesktop = Controller.getPxXYViewsPosition();
            Location = new Point(viewPositionsInDesktop[0] + Controller.getViewContext("DrawingView").Width + PX_EXTRA_SEP, viewPositionsInDesktop[1]);

            // Inicialización "scrolls"
            RedScroll.Minimum = MINIMUM_SCROLL_VALUE;
            RedScroll.Maximum = MAXIMUM_SCROLL_VALUE;
            GreenScroll.Minimum = MINIMUM_SCROLL_VALUE;
            GreenScroll.Maximum = MAXIMUM_SCROLL_VALUE;
            BlueScroll.Minimum = MINIMUM_SCROLL_VALUE;
            BlueScroll.Maximum = MAXIMUM_SCROLL_VALUE;

            // Inicialización cajas de ancho y alto:
            int[] drawingSize = Controller.getDrawingSize();
            WidthValueBox.Text = drawingSize[0].ToString();
            HeightValueBox.Text = drawingSize[1].ToString();
            WidthValueBox.MaxLength = 6;
            HeightValueBox.MaxLength = 6;

            // Inicialización cajas de texto de los colores.
            RedValueBox.ReadOnly = true;
            RedValueBox.Text = RedScroll.Value.ToString();
            GreenValueBox.ReadOnly = true;
            GreenValueBox.Text = GreenScroll.Value.ToString();
            BlueValueBox.ReadOnly = true;
            BlueValueBox.Text = BlueScroll.Value.ToString();

            // Inicialización "GroupBox" selección de tamaño.
            SelectionCanvasSizeBox.Text = "Choose your drawing size: (" + MIN_PX_RANK + " PX  To " + MAX_PX_RANK + " PX)";

            // Inicialización "PictureBox" color de muestra.
            SampleColorBox.BorderStyle = BorderStyle.Fixed3D;
            SampleColorBox.BackColor = Controller.getRGBColorWithMix(Convert.ToInt16(RedValueBox.Text),
                Convert.ToInt16(GreenValueBox.Text),
                Convert.ToInt16(BlueValueBox.Text));
        }

        private void RedScroll_Scroll(object sender, ScrollEventArgs e)
        {
            RedValueBox.Text = RedScroll.Value.ToString();
            SampleColorBox.BackColor = Controller.getRGBColorWithMix(Convert.ToInt16(RedValueBox.Text),
                Convert.ToInt16(GreenValueBox.Text),
                Convert.ToInt16(BlueValueBox.Text));
        }

        private void GreenScroll_Scroll(object sender, ScrollEventArgs e)
        {
            GreenValueBox.Text = GreenScroll.Value.ToString();
            SampleColorBox.BackColor = Controller.getRGBColorWithMix(Convert.ToInt16(RedValueBox.Text),
                Convert.ToInt16(GreenValueBox.Text),
                Convert.ToInt16(BlueValueBox.Text));
        }

        private void BlueScroll_Scroll(object sender, ScrollEventArgs e)
        {
            BlueValueBox.Text = BlueScroll.Value.ToString();
            SampleColorBox.BackColor = Controller.getRGBColorWithMix(Convert.ToInt16(RedValueBox.Text),
                Convert.ToInt16(GreenValueBox.Text),
                Convert.ToInt16(BlueValueBox.Text));
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            if (!Controller.isCanvasVoid())
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Title = "Save File";
                saveDialog.Filter = Controller.getFileFormats();
                saveDialog.ShowDialog();
                if (!saveDialog.FileName.Equals("")) Controller.saveFile(saveDialog.FileName);
            }
            else
            {
                MessageBox.Show("ERROR: Void drawing");
            }
        }

        private void OptionsView_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Si se cierra la vista de opciones se cerrará también la principal (DrawingView)
            Controller.closeDrawingView();
        }

        private void WidthValueBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Impedir que se puedan entrar valores no numéricos, excepto el retroceso.
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8) e.Handled = true;
            
        }

        private void HeightValueBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8) e.Handled = true;

        }

        private void WidthValueBox_MouseDown(object sender, MouseEventArgs e)
        {
            // Impedir que se pueda abrir la ventana de opciones al dar clic derecho.
            if (e.Button.Equals(MouseButtons.Right)) WidthValueBox.ShortcutsEnabled = false;
        }

        private void HeightValueBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Right)) HeightValueBox.ShortcutsEnabled = false;
        }

        private void AcceptSizeButton_Click(object sender, EventArgs e)
        {
            if (WidthValueBox.Text.Length > 0 && HeightValueBox.Text.Length > 0)
            {
                int width = Convert.ToInt32(WidthValueBox.Text);
                int height = Convert.ToInt32(HeightValueBox.Text);
                if (width > MIN_PX_RANK - 1 && height > MIN_PX_RANK - 1 && width < MAX_PX_RANK + 1 && height < MAX_PX_RANK + 1)
                {
                    int[] previousValues = Controller.getWidthAndHeightPreviousValue();
                    if (width != previousValues[0] || height != previousValues[1])
                    {
                        Controller.setDrawingSizeInGeneralDrawingView(width, height);
                        Controller.setWidthAndHeightPreviousValue(width, height);
                    } else MessageBox.Show("ERROR: Current values are the same as previous values.");
                } else MessageBox.Show("ERROR: Parameters out of range.");
            } else MessageBox.Show("ERROR: Empty fields.");
        }

        private void PaintBucketButton_Click(object sender, EventArgs e)
        {
            Controller.setNumberOfTool(1); // Cubo de pintura.
        }
    }
}

