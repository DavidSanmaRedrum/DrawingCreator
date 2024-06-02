

namespace DrawingCreator.View
{
    partial class OptionsView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsView));
            this.OptionsBox = new System.Windows.Forms.GroupBox();
            this.SelectionCanvasSizeBox = new System.Windows.Forms.GroupBox();
            this.AcceptSizeButton = new System.Windows.Forms.Button();
            this.PXLabel2 = new System.Windows.Forms.Label();
            this.PXLabel1 = new System.Windows.Forms.Label();
            this.HeightValueBox = new System.Windows.Forms.TextBox();
            this.WidthValueBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.SelectionColorsBox = new System.Windows.Forms.GroupBox();
            this.SampleColorBox = new System.Windows.Forms.PictureBox();
            this.BlueValueBox = new System.Windows.Forms.TextBox();
            this.GreenValueBox = new System.Windows.Forms.TextBox();
            this.RedValueBox = new System.Windows.Forms.TextBox();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.RedLabel = new System.Windows.Forms.Label();
            this.BlueScroll = new System.Windows.Forms.HScrollBar();
            this.RedScroll = new System.Windows.Forms.HScrollBar();
            this.GreenScroll = new System.Windows.Forms.HScrollBar();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.PencilButton = new System.Windows.Forms.ToolStripButton();
            this.PaintBucketButton = new System.Windows.Forms.ToolStripButton();
            this.ImagesList = new System.Windows.Forms.ImageList(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OptionsBox.SuspendLayout();
            this.SelectionCanvasSizeBox.SuspendLayout();
            this.SelectionColorsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SampleColorBox)).BeginInit();
            this.ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptionsBox
            // 
            this.OptionsBox.Controls.Add(this.SelectionCanvasSizeBox);
            this.OptionsBox.Controls.Add(this.SelectionColorsBox);
            this.OptionsBox.Controls.Add(this.SaveFileButton);
            this.OptionsBox.Location = new System.Drawing.Point(12, 38);
            this.OptionsBox.Name = "OptionsBox";
            this.OptionsBox.Size = new System.Drawing.Size(671, 321);
            this.OptionsBox.TabIndex = 3;
            this.OptionsBox.TabStop = false;
            this.OptionsBox.Text = "Options";
            // 
            // SelectionCanvasSizeBox
            // 
            this.SelectionCanvasSizeBox.Controls.Add(this.AcceptSizeButton);
            this.SelectionCanvasSizeBox.Controls.Add(this.PXLabel2);
            this.SelectionCanvasSizeBox.Controls.Add(this.PXLabel1);
            this.SelectionCanvasSizeBox.Controls.Add(this.HeightValueBox);
            this.SelectionCanvasSizeBox.Controls.Add(this.WidthValueBox);
            this.SelectionCanvasSizeBox.Controls.Add(this.HeightLabel);
            this.SelectionCanvasSizeBox.Controls.Add(this.WidthLabel);
            this.SelectionCanvasSizeBox.Location = new System.Drawing.Point(15, 30);
            this.SelectionCanvasSizeBox.Name = "SelectionCanvasSizeBox";
            this.SelectionCanvasSizeBox.Size = new System.Drawing.Size(339, 109);
            this.SelectionCanvasSizeBox.TabIndex = 4;
            this.SelectionCanvasSizeBox.TabStop = false;
            // 
            // AcceptSizeButton
            // 
            this.AcceptSizeButton.Location = new System.Drawing.Point(231, 34);
            this.AcceptSizeButton.Name = "AcceptSizeButton";
            this.AcceptSizeButton.Size = new System.Drawing.Size(94, 51);
            this.AcceptSizeButton.TabIndex = 8;
            this.AcceptSizeButton.Text = "ACCEPT SIZE";
            this.AcceptSizeButton.UseVisualStyleBackColor = true;
            this.AcceptSizeButton.Click += new System.EventHandler(this.AcceptSizeButton_Click);
            // 
            // PXLabel2
            // 
            this.PXLabel2.AutoSize = true;
            this.PXLabel2.Location = new System.Drawing.Point(175, 66);
            this.PXLabel2.Name = "PXLabel2";
            this.PXLabel2.Size = new System.Drawing.Size(26, 17);
            this.PXLabel2.TabIndex = 7;
            this.PXLabel2.Text = "PX";
            // 
            // PXLabel1
            // 
            this.PXLabel1.AutoSize = true;
            this.PXLabel1.Location = new System.Drawing.Point(175, 36);
            this.PXLabel1.Name = "PXLabel1";
            this.PXLabel1.Size = new System.Drawing.Size(26, 17);
            this.PXLabel1.TabIndex = 6;
            this.PXLabel1.Text = "PX";
            // 
            // HeightValueBox
            // 
            this.HeightValueBox.Location = new System.Drawing.Point(90, 63);
            this.HeightValueBox.Name = "HeightValueBox";
            this.HeightValueBox.Size = new System.Drawing.Size(82, 22);
            this.HeightValueBox.TabIndex = 5;
            this.HeightValueBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightValueBox_KeyPress);
            this.HeightValueBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeightValueBox_MouseDown);
            // 
            // WidthValueBox
            // 
            this.WidthValueBox.Location = new System.Drawing.Point(90, 33);
            this.WidthValueBox.Name = "WidthValueBox";
            this.WidthValueBox.Size = new System.Drawing.Size(82, 22);
            this.WidthValueBox.TabIndex = 4;
            this.WidthValueBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WidthValueBox_KeyPress);
            this.WidthValueBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WidthValueBox_MouseDown);
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(24, 65);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(64, 17);
            this.HeightLabel.TabIndex = 3;
            this.HeightLabel.Text = "HEIGHT:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(24, 34);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(57, 17);
            this.WidthLabel.TabIndex = 2;
            this.WidthLabel.Text = "WIDTH:";
            // 
            // SelectionColorsBox
            // 
            this.SelectionColorsBox.Controls.Add(this.SampleColorBox);
            this.SelectionColorsBox.Controls.Add(this.BlueValueBox);
            this.SelectionColorsBox.Controls.Add(this.GreenValueBox);
            this.SelectionColorsBox.Controls.Add(this.RedValueBox);
            this.SelectionColorsBox.Controls.Add(this.BlueLabel);
            this.SelectionColorsBox.Controls.Add(this.GreenLabel);
            this.SelectionColorsBox.Controls.Add(this.RedLabel);
            this.SelectionColorsBox.Controls.Add(this.BlueScroll);
            this.SelectionColorsBox.Controls.Add(this.RedScroll);
            this.SelectionColorsBox.Controls.Add(this.GreenScroll);
            this.SelectionColorsBox.Location = new System.Drawing.Point(15, 145);
            this.SelectionColorsBox.Name = "SelectionColorsBox";
            this.SelectionColorsBox.Size = new System.Drawing.Size(643, 158);
            this.SelectionColorsBox.TabIndex = 3;
            this.SelectionColorsBox.TabStop = false;
            this.SelectionColorsBox.Text = "Make your color";
            // 
            // SampleColorBox
            // 
            this.SampleColorBox.Location = new System.Drawing.Point(550, 47);
            this.SampleColorBox.Name = "SampleColorBox";
            this.SampleColorBox.Size = new System.Drawing.Size(80, 80);
            this.SampleColorBox.TabIndex = 10;
            this.SampleColorBox.TabStop = false;
            // 
            // BlueValueBox
            // 
            this.BlueValueBox.Location = new System.Drawing.Point(485, 110);
            this.BlueValueBox.Name = "BlueValueBox";
            this.BlueValueBox.Size = new System.Drawing.Size(52, 22);
            this.BlueValueBox.TabIndex = 9;
            // 
            // GreenValueBox
            // 
            this.GreenValueBox.Location = new System.Drawing.Point(485, 77);
            this.GreenValueBox.Name = "GreenValueBox";
            this.GreenValueBox.Size = new System.Drawing.Size(52, 22);
            this.GreenValueBox.TabIndex = 8;
            // 
            // RedValueBox
            // 
            this.RedValueBox.Location = new System.Drawing.Point(485, 41);
            this.RedValueBox.Name = "RedValueBox";
            this.RedValueBox.Size = new System.Drawing.Size(52, 22);
            this.RedValueBox.TabIndex = 7;
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.Location = new System.Drawing.Point(24, 110);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(48, 17);
            this.BlueLabel.TabIndex = 6;
            this.BlueLabel.Text = "BLUE:";
            // 
            // GreenLabel
            // 
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.Location = new System.Drawing.Point(24, 77);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(61, 17);
            this.GreenLabel.TabIndex = 5;
            this.GreenLabel.Text = "GREEN:";
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.Location = new System.Drawing.Point(24, 44);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(41, 17);
            this.RedLabel.TabIndex = 3;
            this.RedLabel.Text = "RED:";
            // 
            // BlueScroll
            // 
            this.BlueScroll.Location = new System.Drawing.Point(91, 105);
            this.BlueScroll.Name = "BlueScroll";
            this.BlueScroll.Size = new System.Drawing.Size(377, 23);
            this.BlueScroll.TabIndex = 4;
            this.BlueScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.BlueScroll_Scroll);
            // 
            // RedScroll
            // 
            this.RedScroll.Location = new System.Drawing.Point(91, 40);
            this.RedScroll.Name = "RedScroll";
            this.RedScroll.Size = new System.Drawing.Size(377, 23);
            this.RedScroll.TabIndex = 2;
            this.RedScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RedScroll_Scroll);
            // 
            // GreenScroll
            // 
            this.GreenScroll.Location = new System.Drawing.Point(91, 73);
            this.GreenScroll.Name = "GreenScroll";
            this.GreenScroll.Size = new System.Drawing.Size(377, 23);
            this.GreenScroll.TabIndex = 3;
            this.GreenScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GreenScroll_Scroll);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Location = new System.Drawing.Point(578, 54);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(80, 70);
            this.SaveFileButton.TabIndex = 1;
            this.SaveFileButton.Text = "SAVE FILE";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // ToolBar
            // 
            this.ToolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PencilButton,
            this.toolStripSeparator1,
            this.PaintBucketButton});
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(697, 25);
            this.ToolBar.TabIndex = 4;
            this.ToolBar.Text = "ToolBar";
            // 
            // PencilButton
            // 
            this.PencilButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PencilButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PencilButton.Name = "PencilButton";
            this.PencilButton.Size = new System.Drawing.Size(29, 28);
            this.PencilButton.Text = "Pencil";
            this.PencilButton.Click += new System.EventHandler(this.PencilButton_Click);
            // 
            // PaintBucketButton
            // 
            this.PaintBucketButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaintBucketButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaintBucketButton.Name = "PaintBucketButton";
            this.PaintBucketButton.Size = new System.Drawing.Size(29, 28);
            this.PaintBucketButton.Text = "Paint bucket";
            this.PaintBucketButton.Click += new System.EventHandler(this.PaintBucketButton_Click);
            // 
            // ImagesList
            // 
            this.ImagesList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImagesList.ImageStream")));
            this.ImagesList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImagesList.Images.SetKeyName(0, "Pencil.png");
            this.ImagesList.Images.SetKeyName(1, "PaintBucket.png");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // OptionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 372);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.OptionsBox);
            this.Name = "OptionsView";
            this.Text = "Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OptionsView_FormClosed);
            this.Load += new System.EventHandler(this.OptionsView_Load);
            this.OptionsBox.ResumeLayout(false);
            this.SelectionCanvasSizeBox.ResumeLayout(false);
            this.SelectionCanvasSizeBox.PerformLayout();
            this.SelectionColorsBox.ResumeLayout(false);
            this.SelectionColorsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SampleColorBox)).EndInit();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox OptionsBox;
        private System.Windows.Forms.GroupBox SelectionColorsBox;
        private System.Windows.Forms.PictureBox SampleColorBox;
        private System.Windows.Forms.TextBox BlueValueBox;
        private System.Windows.Forms.TextBox GreenValueBox;
        private System.Windows.Forms.TextBox RedValueBox;
        private System.Windows.Forms.Label BlueLabel;
        private System.Windows.Forms.Label GreenLabel;
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.HScrollBar BlueScroll;
        private System.Windows.Forms.HScrollBar RedScroll;
        private System.Windows.Forms.HScrollBar GreenScroll;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.GroupBox SelectionCanvasSizeBox;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox HeightValueBox;
        private System.Windows.Forms.TextBox WidthValueBox;
        private System.Windows.Forms.Label PXLabel2;
        private System.Windows.Forms.Label PXLabel1;
        private System.Windows.Forms.Button AcceptSizeButton;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripButton PaintBucketButton;
        private System.Windows.Forms.ToolStripButton PencilButton;
        private System.Windows.Forms.ImageList ImagesList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}