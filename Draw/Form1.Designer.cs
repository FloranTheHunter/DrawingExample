namespace Draw
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new TPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.EraseButton = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.TrackBar();
            this.Green = new System.Windows.Forms.TrackBar();
            this.Red = new System.Windows.Forms.TrackBar();
            this.BrushBox = new System.Windows.Forms.PictureBox();
            this.FillButton = new System.Windows.Forms.Button();
            this.SetColor = new System.Windows.Forms.Button();
            this.SizeSlider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BackBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CurrentBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrushBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Location = new System.Drawing.Point(12, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 323);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 93);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EraseButton
            // 
            this.EraseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EraseButton.Location = new System.Drawing.Point(534, 48);
            this.EraseButton.Name = "EraseButton";
            this.EraseButton.Size = new System.Drawing.Size(65, 52);
            this.EraseButton.TabIndex = 2;
            this.EraseButton.Text = "Eraser";
            this.EraseButton.UseVisualStyleBackColor = true;
            this.EraseButton.Click += new System.EventHandler(this.EraseButton_Click);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Gray;
            this.Blue.Location = new System.Drawing.Point(479, 7);
            this.Blue.Maximum = 255;
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(164, 45);
            this.Blue.SmallChange = 10;
            this.Blue.TabIndex = 6;
            this.Blue.TabStop = false;
            this.Blue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Blue.Value = 255;
            this.Blue.Scroll += new System.EventHandler(this.Blue_Changed);
            this.Blue.MouseCaptureChanged += new System.EventHandler(this.Blue_Changed);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.Gray;
            this.Green.Location = new System.Drawing.Point(309, 7);
            this.Green.Maximum = 255;
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(164, 45);
            this.Green.SmallChange = 10;
            this.Green.TabIndex = 7;
            this.Green.TabStop = false;
            this.Green.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Green.Value = 255;
            this.Green.Scroll += new System.EventHandler(this.Green_Changed);
            this.Green.ValueChanged += new System.EventHandler(this.Green_Changed);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Gray;
            this.Red.Location = new System.Drawing.Point(139, 7);
            this.Red.Maximum = 255;
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(164, 45);
            this.Red.SmallChange = 10;
            this.Red.TabIndex = 8;
            this.Red.TabStop = false;
            this.Red.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Red.Value = 255;
            this.Red.Scroll += new System.EventHandler(this.Red_Changed);
            this.Red.ValueChanged += new System.EventHandler(this.Red_Changed);
            // 
            // BrushBox
            // 
            this.BrushBox.Location = new System.Drawing.Point(235, 48);
            this.BrushBox.Name = "BrushBox";
            this.BrushBox.Size = new System.Drawing.Size(53, 52);
            this.BrushBox.TabIndex = 9;
            this.BrushBox.TabStop = false;
            // 
            // FillButton
            // 
            this.FillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FillButton.Location = new System.Drawing.Point(164, 48);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(65, 52);
            this.FillButton.TabIndex = 10;
            this.FillButton.Text = "Fill";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // SetColor
            // 
            this.SetColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetColor.Location = new System.Drawing.Point(412, 48);
            this.SetColor.Name = "SetColor";
            this.SetColor.Size = new System.Drawing.Size(116, 52);
            this.SetColor.TabIndex = 11;
            this.SetColor.Text = "Set brush color";
            this.SetColor.UseVisualStyleBackColor = true;
            this.SetColor.Click += new System.EventHandler(this.SetColor_Click);
            // 
            // SizeSlider
            // 
            this.SizeSlider.BackColor = System.Drawing.Color.Gray;
            this.SizeSlider.Location = new System.Drawing.Point(649, 7);
            this.SizeSlider.Maximum = 100;
            this.SizeSlider.Name = "SizeSlider";
            this.SizeSlider.Size = new System.Drawing.Size(164, 45);
            this.SizeSlider.SmallChange = 10;
            this.SizeSlider.TabIndex = 12;
            this.SizeSlider.TabStop = false;
            this.SizeSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SizeSlider.Value = 5;
            this.SizeSlider.Scroll += new System.EventHandler(this.SizeChangedE);
            this.SizeSlider.ValueChanged += new System.EventHandler(this.SizeChangedE);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Blue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(649, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Size";
            // 
            // BackBox
            // 
            this.BackBox.Location = new System.Drawing.Point(353, 48);
            this.BackBox.Name = "BackBox";
            this.BackBox.Size = new System.Drawing.Size(53, 52);
            this.BackBox.TabIndex = 17;
            this.BackBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Brush";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Background";
            // 
            // CurrentBox
            // 
            this.CurrentBox.Location = new System.Drawing.Point(294, 48);
            this.CurrentBox.Name = "CurrentBox";
            this.CurrentBox.Size = new System.Drawing.Size(53, 52);
            this.CurrentBox.TabIndex = 20;
            this.CurrentBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Current";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CurrentBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BackBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EraseButton);
            this.Controls.Add(this.SetColor);
            this.Controls.Add(this.FillButton);
            this.Controls.Add(this.SizeSlider);
            this.Controls.Add(this.BrushBox);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Blue);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrushBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EraseButton;
        private System.Windows.Forms.TrackBar Blue;
        private System.Windows.Forms.TrackBar Green;
        private System.Windows.Forms.TrackBar Red;
        private System.Windows.Forms.PictureBox BrushBox;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.Button SetColor;
        private System.Windows.Forms.TrackBar SizeSlider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox BackBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox CurrentBox;
        private System.Windows.Forms.Label label7;
    }
}

