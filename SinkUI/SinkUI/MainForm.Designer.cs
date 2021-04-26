
namespace SinkUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.HNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.BNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ANumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ENumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.D_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.buildButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ANumericUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ENumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CNumericUpDown)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.HNumericUpDown);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BNumericUpDown);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ANumericUpDown);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 62);
            this.panel1.TabIndex = 1;
            // 
            // HNumericUpDown
            // 
            this.HNumericUpDown.Location = new System.Drawing.Point(353, 25);
            this.HNumericUpDown.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.HNumericUpDown.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.HNumericUpDown.Name = "HNumericUpDown";
            this.HNumericUpDown.Size = new System.Drawing.Size(50, 23);
            this.HNumericUpDown.TabIndex = 6;
            this.HNumericUpDown.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Высота (H):";
            // 
            // BNumericUpDown
            // 
            this.BNumericUpDown.Location = new System.Drawing.Point(221, 25);
            this.BNumericUpDown.Maximum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.BNumericUpDown.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.BNumericUpDown.Name = "BNumericUpDown";
            this.BNumericUpDown.Size = new System.Drawing.Size(50, 23);
            this.BNumericUpDown.TabIndex = 4;
            this.BNumericUpDown.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.BNumericUpDown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BNumericUpDown_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ширина (B):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Длина (A):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Параметры мойки:";
            // 
            // ANumericUpDown
            // 
            this.ANumericUpDown.Location = new System.Drawing.Point(86, 25);
            this.ANumericUpDown.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.ANumericUpDown.Minimum = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.ANumericUpDown.Name = "ANumericUpDown";
            this.ANumericUpDown.Size = new System.Drawing.Size(50, 23);
            this.ANumericUpDown.TabIndex = 0;
            this.ANumericUpDown.Value = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.ANumericUpDown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ANumericUpDown_MouseClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.ENumericUpDown);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.CNumericUpDown);
            this.panel2.Location = new System.Drawing.Point(12, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 62);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // ENumericUpDown
            // 
            this.ENumericUpDown.Location = new System.Drawing.Point(221, 23);
            this.ENumericUpDown.Maximum = new decimal(new int[] {
            650,
            0,
            0,
            0});
            this.ENumericUpDown.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.ENumericUpDown.Name = "ENumericUpDown";
            this.ENumericUpDown.Size = new System.Drawing.Size(50, 23);
            this.ENumericUpDown.TabIndex = 4;
            this.ENumericUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.ENumericUpDown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ENumericUpDown_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ширина (E):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Длина (C):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Параметры чаши:";
            // 
            // CNumericUpDown
            // 
            this.CNumericUpDown.Location = new System.Drawing.Point(86, 23);
            this.CNumericUpDown.Maximum = new decimal(new int[] {
            1150,
            0,
            0,
            0});
            this.CNumericUpDown.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.CNumericUpDown.Name = "CNumericUpDown";
            this.CNumericUpDown.Size = new System.Drawing.Size(50, 23);
            this.CNumericUpDown.TabIndex = 0;
            this.CNumericUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.CNumericUpDown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CNumericUpDown_MouseClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.dNumericUpDown);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.D_NumericUpDown);
            this.panel3.Location = new System.Drawing.Point(13, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(411, 86);
            this.panel3.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Диаметр отверстия для крана (d):";
            // 
            // dNumericUpDown
            // 
            this.dNumericUpDown.Location = new System.Drawing.Point(211, 54);
            this.dNumericUpDown.Maximum = new decimal(new int[] {
            55,
            0,
            0,
            0});
            this.dNumericUpDown.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.dNumericUpDown.Name = "dNumericUpDown";
            this.dNumericUpDown.Size = new System.Drawing.Size(50, 23);
            this.dNumericUpDown.TabIndex = 3;
            this.dNumericUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.dNumericUpDown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dNumericUpDown_MouseClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Диаметр отверстия для слива (D):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Параметры отверстий:";
            // 
            // D_NumericUpDown
            // 
            this.D_NumericUpDown.Location = new System.Drawing.Point(212, 25);
            this.D_NumericUpDown.Maximum = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.D_NumericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.D_NumericUpDown.Name = "D_NumericUpDown";
            this.D_NumericUpDown.Size = new System.Drawing.Size(50, 23);
            this.D_NumericUpDown.TabIndex = 0;
            this.D_NumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.D_NumericUpDown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.D_NumericUpDown_MouseClick);
            // 
            // buildButton
            // 
            this.buildButton.Location = new System.Drawing.Point(343, 243);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(80, 25);
            this.buildButton.TabIndex = 9;
            this.buildButton.Text = "Построить";
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.buildButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 275);
            this.Controls.Add(this.buildButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Sink3DPlugin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ANumericUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ENumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CNumericUpDown)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D_NumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown ANumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown HNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown BNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown ENumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown CNumericUpDown;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown dNumericUpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown D_NumericUpDown;
        private System.Windows.Forms.Button buildButton;
    }
}

