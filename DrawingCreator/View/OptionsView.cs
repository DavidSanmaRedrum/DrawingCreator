using System;
using System.Windows.Forms;

namespace DrawingCreator.View
{
    public partial class OptionsView : Form
    {
        public OptionsView()
        {
            InitializeComponent();
        }

        private static int MINIMUM_SCROLL_VALUE = 0;
        private static int MAXIMUM_SCROLL_VALUE = 264;

        private void OptionsView_Load(object sender, EventArgs e)
        {
            // Inicialización "scrolls"
            RedScroll.Minimum = MINIMUM_SCROLL_VALUE;
            RedScroll.Maximum = MAXIMUM_SCROLL_VALUE;
            GreenScroll.Minimum = MINIMUM_SCROLL_VALUE;
            GreenScroll.Maximum = MAXIMUM_SCROLL_VALUE;
            BlueScroll.Minimum = MINIMUM_SCROLL_VALUE;
            BlueScroll.Maximum = MAXIMUM_SCROLL_VALUE;


            // Inicialización cajas de texto de los colores.
            RedValueBox.ReadOnly = true;
            RedValueBox.Text = RedScroll.Value.ToString();
            GreenValueBox.ReadOnly = true;
            GreenValueBox.Text = GreenScroll.Value.ToString();
            BlueValueBox.ReadOnly = true;
            BlueValueBox.Text = BlueScroll.Value.ToString();

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
                if (!saveDialog.FileName.Equals("")) Controller.saveFile(saveDialog.FileName, Controller.getDrawingBitmap());
            }
            else
            {
                MessageBox.Show("ERROR: Void drawing");
            }
        }
    }
}

