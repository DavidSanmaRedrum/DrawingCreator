

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
            this.OptionsBox = new System.Windows.Forms.GroupBox();
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
            this.SelectionCanvasSizeBox = new System.Windows.Forms.GroupBox();
            this.WidthScroll = new System.Windows.Forms.HScrollBar();
            this.HeightScroll = new System.Windows.Forms.HScrollBar();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthValueBox = new System.Windows.Forms.TextBox();
            this.HeightValueBox = new System.Windows.Forms.TextBox();
            this.PXLabel1 = new System.Windows.Forms.Label();
            this.PXLabel2 = new System.Windows.Forms.Label();
            this.OptionsBox.SuspendLayout();
            this.SelectionColorsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SampleColorBox)).BeginInit();
            this.SelectionCanvasSizeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptionsBox
            // 
            this.OptionsBox.Controls.Add(this.SelectionCanvasSizeBox);
            this.OptionsBox.Controls.Add(this.SelectionColorsBox);
            this.OptionsBox.Controls.Add(this.SaveFileButton);
            this.OptionsBox.Location = new System.Drawing.Point(12, 12);
            this.OptionsBox.Name = "OptionsBox";
            this.OptionsBox.Size = new System.Drawing.Size(693, 321);
            this.OptionsBox.TabIndex = 3;
            this.OptionsBox.TabStop = false;
            this.OptionsBox.Text = "Options";
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
            this.SaveFileButton.Location = new System.Drawing.Point(600, 49);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(80, 70);
            this.SaveFileButton.TabIndex = 1;
            this.SaveFileButton.Text = "SAVE FILE";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // SelectionCanvasSizeBox
            // 
            this.SelectionCanvasSizeBox.Controls.Add(this.PXLabel2);
            this.SelectionCanvasSizeBox.Controls.Add(this.PXLabel1);
            this.SelectionCanvasSizeBox.Controls.Add(this.HeightValueBox);
            this.SelectionCanvasSizeBox.Controls.Add(this.WidthValueBox);
            this.SelectionCanvasSizeBox.Controls.Add(this.HeightLabel);
            this.SelectionCanvasSizeBox.Controls.Add(this.WidthLabel);
            this.SelectionCanvasSizeBox.Controls.Add(this.HeightScroll);
            this.SelectionCanvasSizeBox.Controls.Add(this.WidthScroll);
            this.SelectionCanvasSizeBox.Location = new System.Drawing.Point(15, 30);
            this.SelectionCanvasSizeBox.Name = "SelectionCanvasSizeBox";
            this.SelectionCanvasSizeBox.Size = new System.Drawing.Size(579, 109);
            this.SelectionCanvasSizeBox.TabIndex = 4;
            this.SelectionCanvasSizeBox.TabStop = false;
            this.SelectionCanvasSizeBox.Text = "Choose your drawing size";
            // 
            // WidthScroll
            // 
            this.WidthScroll.Location = new System.Drawing.Point(104, 28);
            this.WidthScroll.Name = "WidthScroll";
            this.WidthScroll.Size = new System.Drawing.Size(364, 23);
            this.WidthScroll.TabIndex = 0;
            // 
            // HeightScroll
            // 
            this.HeightScroll.Location = new System.Drawing.Point(104, 65);
            this.HeightScroll.Name = "HeightScroll";
            this.HeightScroll.Size = new System.Drawing.Size(364, 23);
            this.HeightScroll.TabIndex = 1;
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
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(24, 65);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(64, 17);
            this.HeightLabel.TabIndex = 3;
            this.HeightLabel.Text = "HEIGHT:";
            // 
            // WidthValueBox
            // 
            this.WidthValueBox.Location = new System.Drawing.Point(485, 30);
            this.WidthValueBox.Name = "WidthValueBox";
            this.WidthValueBox.Size = new System.Drawing.Size(52, 22);
            this.WidthValueBox.TabIndex = 4;
            // 
            // HeightValueBox
            // 
            this.HeightValueBox.Location = new System.Drawing.Point(485, 67);
            this.HeightValueBox.Name = "HeightValueBox";
            this.HeightValueBox.Size = new System.Drawing.Size(52, 22);
            this.HeightValueBox.TabIndex = 5;
            // 
            // PXLabel1
            // 
            this.PXLabel1.AutoSize = true;
            this.PXLabel1.Location = new System.Drawing.Point(543, 33);
            this.PXLabel1.Name = "PXLabel1";
            this.PXLabel1.Size = new System.Drawing.Size(26, 17);
            this.PXLabel1.TabIndex = 6;
            this.PXLabel1.Text = "PX";
            // 
            // PXLabel2
            // 
            this.PXLabel2.AutoSize = true;
            this.PXLabel2.Location = new System.Drawing.Point(543, 70);
            this.PXLabel2.Name = "PXLabel2";
            this.PXLabel2.Size = new System.Drawing.Size(26, 17);
            this.PXLabel2.TabIndex = 7;
            this.PXLabel2.Text = "PX";
            // 
            // OptionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 349);
            this.Controls.Add(this.OptionsBox);
            this.Name = "OptionsView";
            this.Text = "Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OptionsView_FormClosed);
            this.Load += new System.EventHandler(this.OptionsView_Load);
            this.OptionsBox.ResumeLayout(false);
            this.SelectionColorsBox.ResumeLayout(false);
            this.SelectionColorsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SampleColorBox)).EndInit();
            this.SelectionCanvasSizeBox.ResumeLayout(false);
            this.SelectionCanvasSizeBox.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.HScrollBar WidthScroll;
        private System.Windows.Forms.HScrollBar HeightScroll;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox HeightValueBox;
        private System.Windows.Forms.TextBox WidthValueBox;
        private System.Windows.Forms.Label PXLabel2;
        private System.Windows.Forms.Label PXLabel1;
    }
}