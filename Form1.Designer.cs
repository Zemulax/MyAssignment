﻿namespace MyAssignment
{
    partial class Form1
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
            this.InputField = new System.Windows.Forms.TextBox();
            this.MainDisplay = new System.Windows.Forms.PictureBox();
            this.CommandLine = new System.Windows.Forms.RichTextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.Fill = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FillOn = new System.Windows.Forms.RadioButton();
            this.FillOff = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.MainDisplay)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputField
            // 
            this.InputField.Location = new System.Drawing.Point(12, 547);
            this.InputField.Name = "InputField";
            this.InputField.Size = new System.Drawing.Size(316, 27);
            this.InputField.TabIndex = 2;
            this.InputField.Text = "triangle 90";
            this.InputField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputField_KeyDown);
            // 
            // MainDisplay
            // 
            this.MainDisplay.BackColor = System.Drawing.Color.MidnightBlue;
            this.MainDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainDisplay.Location = new System.Drawing.Point(428, 125);
            this.MainDisplay.Name = "MainDisplay";
            this.MainDisplay.Size = new System.Drawing.Size(843, 401);
            this.MainDisplay.TabIndex = 3;
            this.MainDisplay.TabStop = false;
            this.MainDisplay.WaitOnLoad = true;
            this.MainDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.MainDisplay_Paint);
            // 
            // CommandLine
            // 
            this.CommandLine.Location = new System.Drawing.Point(12, 125);
            this.CommandLine.Name = "CommandLine";
            this.CommandLine.Size = new System.Drawing.Size(316, 401);
            this.CommandLine.TabIndex = 4;
            this.CommandLine.Text = "";
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Enter.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Enter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Enter.Location = new System.Drawing.Point(428, 547);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(94, 65);
            this.Enter.TabIndex = 5;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Red;
            this.Clear.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Clear.ForeColor = System.Drawing.SystemColors.Window;
            this.Clear.Location = new System.Drawing.Point(1177, 546);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(94, 63);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Save.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Save.Location = new System.Drawing.Point(543, 545);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(94, 65);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Load
            // 
            this.Load.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Load.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Load.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Load.Location = new System.Drawing.Point(1054, 544);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(103, 65);
            this.Load.TabIndex = 7;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = false;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Fill
            // 
            this.Fill.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Fill.Font = new System.Drawing.Font("Unispace", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Fill.ForeColor = System.Drawing.Color.MintCream;
            this.Fill.Location = new System.Drawing.Point(660, 546);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(265, 65);
            this.Fill.TabIndex = 8;
            this.Fill.Text = "Fill";
            this.Fill.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 107);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(449, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "SHAPE CREATOR";
            // 
            // FillOn
            // 
            this.FillOn.AutoSize = true;
            this.FillOn.Location = new System.Drawing.Point(931, 550);
            this.FillOn.Name = "FillOn";
            this.FillOn.Size = new System.Drawing.Size(72, 24);
            this.FillOn.TabIndex = 10;
            this.FillOn.TabStop = true;
            this.FillOn.Text = "Fill On";
            this.FillOn.UseVisualStyleBackColor = true;
            this.FillOn.CheckedChanged += new System.EventHandler(this.FillOn_CheckedChanged);
            // 
            // FillOff
            // 
            this.FillOff.AutoSize = true;
            this.FillOff.Location = new System.Drawing.Point(931, 585);
            this.FillOff.Name = "FillOff";
            this.FillOff.Size = new System.Drawing.Size(74, 24);
            this.FillOff.TabIndex = 11;
            this.FillOff.TabStop = true;
            this.FillOff.Text = "Fill Off";
            this.FillOff.UseVisualStyleBackColor = true;
            this.FillOff.CheckedChanged += new System.EventHandler(this.FillOff_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 720);
            this.Controls.Add(this.FillOff);
            this.Controls.Add(this.FillOn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Fill);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.CommandLine);
            this.Controls.Add(this.MainDisplay);
            this.Controls.Add(this.InputField);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MainDisplay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox InputField;
        private PictureBox MainDisplay;
        private RichTextBox CommandLine;
        private Button Enter;
        private Button Clear;
        private Button Save;
        private Button Load;
        private Button Fill;
        private Panel panel1;
        private Label label1;
        private RadioButton FillOn;
        private RadioButton FillOff;
    }
}