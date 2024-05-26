

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
            this.OptionsBox.SuspendLayout();
            this.SelectionColorsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SampleColorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OptionsBox
            // 
            this.OptionsBox.Controls.Add(this.SelectionColorsBox);
            this.OptionsBox.Controls.Add(this.SaveFileButton);
            this.OptionsBox.Location = new System.Drawing.Point(12, 12);
            this.OptionsBox.Name = "OptionsBox";
            this.OptionsBox.Size = new System.Drawing.Size(750, 207);
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
            this.SelectionColorsBox.Location = new System.Drawing.Point(15, 30);
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
            this.SaveFileButton.Location = new System.Drawing.Point(664, 80);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(80, 70);
            this.SaveFileButton.TabIndex = 1;
            this.SaveFileButton.Text = "SAVE FILE";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // OptionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OptionsBox);
            this.Name = "OptionsView";
            this.Text = "Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OptionsView_FormClosed);
            this.Load += new System.EventHandler(this.OptionsView_Load);
            this.OptionsBox.ResumeLayout(false);
            this.SelectionColorsBox.ResumeLayout(false);
            this.SelectionColorsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SampleColorBox)).EndInit();
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
    }
}