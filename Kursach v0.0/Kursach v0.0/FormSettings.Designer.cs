namespace Kursach_v0._0
{
    partial class FormSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rB_professional = new System.Windows.Forms.RadioButton();
            this.rB_complicated = new System.Windows.Forms.RadioButton();
            this.rB_average = new System.Windows.Forms.RadioButton();
            this.rB_easy = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cB_sound = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tB_sound = new System.Windows.Forms.TrackBar();
            this.b_Close = new System.Windows.Forms.Button();
            this.b_standart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tB_sound)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.rB_professional);
            this.groupBox1.Controls.Add(this.rB_complicated);
            this.groupBox1.Controls.Add(this.rB_average);
            this.groupBox1.Controls.Add(this.rB_easy);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Уровень";
            // 
            // rB_professional
            // 
            this.rB_professional.AutoSize = true;
            this.rB_professional.Location = new System.Drawing.Point(213, 71);
            this.rB_professional.Name = "rB_professional";
            this.rB_professional.Size = new System.Drawing.Size(220, 32);
            this.rB_professional.TabIndex = 3;
            this.rB_professional.TabStop = true;
            this.rB_professional.Text = "Профессиональный";
            this.rB_professional.UseVisualStyleBackColor = true;
            // 
            // rB_complicated
            // 
            this.rB_complicated.AutoSize = true;
            this.rB_complicated.Location = new System.Drawing.Point(213, 33);
            this.rB_complicated.Name = "rB_complicated";
            this.rB_complicated.Size = new System.Drawing.Size(122, 32);
            this.rB_complicated.TabIndex = 2;
            this.rB_complicated.TabStop = true;
            this.rB_complicated.Text = "Сложный";
            this.rB_complicated.UseVisualStyleBackColor = true;
            // 
            // rB_average
            // 
            this.rB_average.AutoSize = true;
            this.rB_average.Location = new System.Drawing.Point(6, 71);
            this.rB_average.Name = "rB_average";
            this.rB_average.Size = new System.Drawing.Size(111, 32);
            this.rB_average.TabIndex = 1;
            this.rB_average.TabStop = true;
            this.rB_average.Text = "Средний";
            this.rB_average.UseVisualStyleBackColor = true;
            // 
            // rB_easy
            // 
            this.rB_easy.AutoSize = true;
            this.rB_easy.Location = new System.Drawing.Point(6, 33);
            this.rB_easy.Name = "rB_easy";
            this.rB_easy.Size = new System.Drawing.Size(100, 32);
            this.rB_easy.TabIndex = 0;
            this.rB_easy.TabStop = true;
            this.rB_easy.Text = "Лёгкий";
            this.rB_easy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Настройки";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.cB_sound);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 139);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Музыка";
            // 
            // cB_sound
            // 
            this.cB_sound.AutoSize = true;
            this.cB_sound.Checked = true;
            this.cB_sound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cB_sound.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cB_sound.Location = new System.Drawing.Point(7, 66);
            this.cB_sound.Name = "cB_sound";
            this.cB_sound.Size = new System.Drawing.Size(83, 33);
            this.cB_sound.TabIndex = 2;
            this.cB_sound.Text = "Звук";
            this.cB_sound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cB_sound.UseVisualStyleBackColor = true;
            this.cB_sound.CheckedChanged += new System.EventHandler(this.cB_sound_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tB_sound);
            this.groupBox3.Location = new System.Drawing.Point(132, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 76);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Громкость";
            // 
            // tB_sound
            // 
            this.tB_sound.AutoSize = false;
            this.tB_sound.BackColor = System.Drawing.Color.Gray;
            this.tB_sound.LargeChange = 10;
            this.tB_sound.Location = new System.Drawing.Point(6, 31);
            this.tB_sound.Maximum = 100;
            this.tB_sound.Name = "tB_sound";
            this.tB_sound.Size = new System.Drawing.Size(266, 39);
            this.tB_sound.TabIndex = 0;
            this.tB_sound.TickFrequency = 10;
            this.tB_sound.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tB_sound.Value = 100;
            this.tB_sound.Scroll += new System.EventHandler(this.tB_sound_Scroll);
            // 
            // b_Close
            // 
            this.b_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Close.Font = new System.Drawing.Font("Segoe Print", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Close.Location = new System.Drawing.Point(61, 355);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(141, 40);
            this.b_Close.TabIndex = 3;
            this.b_Close.Text = "ОК";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // b_standart
            // 
            this.b_standart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_standart.Font = new System.Drawing.Font("Segoe Print", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_standart.Location = new System.Drawing.Point(225, 355);
            this.b_standart.Name = "b_standart";
            this.b_standart.Size = new System.Drawing.Size(141, 40);
            this.b_standart.TabIndex = 4;
            this.b_standart.Text = "По умолчанию";
            this.b_standart.UseVisualStyleBackColor = true;
            this.b_standart.Click += new System.EventHandler(this.b_standart_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(455, 407);
            this.Controls.Add(this.b_standart);
            this.Controls.Add(this.b_Close);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tB_sound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rB_professional;
        private System.Windows.Forms.RadioButton rB_complicated;
        private System.Windows.Forms.RadioButton rB_average;
        private System.Windows.Forms.RadioButton rB_easy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar tB_sound;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.Button b_standart;
        private System.Windows.Forms.CheckBox cB_sound;
    }
}