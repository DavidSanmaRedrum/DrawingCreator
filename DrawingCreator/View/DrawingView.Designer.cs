
namespace DrawingCreator
{
    partial class DrawingView
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CanvasBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CanvasBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CanvasBox
            // 
            this.CanvasBox.Location = new System.Drawing.Point(12, 12);
            this.CanvasBox.Name = "CanvasBox";
            this.CanvasBox.Size = new System.Drawing.Size(100, 50);
            this.CanvasBox.TabIndex = 0;
            this.CanvasBox.TabStop = false;
            this.CanvasBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasBox_MouseDown);
            this.CanvasBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CanvasBox_MouseMove);
            // 
            // DrawingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 306);
            this.Controls.Add(this.CanvasBox);
            this.Name = "DrawingView";
            this.Text = "Drawing Creator";
            this.Load += new System.EventHandler(this.DrawCreator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CanvasBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CanvasBox;
    }
}
