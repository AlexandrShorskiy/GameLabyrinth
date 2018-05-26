namespace Kursach_v0._0
{
    partial class FormLevel1
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
            this.b_menu = new System.Windows.Forms.Button();
            this.pB_POLE = new System.Windows.Forms.PictureBox();
            this.pB_Person = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.l_time = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l_level = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pB_POLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Person)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_menu
            // 
            this.b_menu.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_menu.Location = new System.Drawing.Point(1152, 127);
            this.b_menu.Name = "b_menu";
            this.b_menu.Size = new System.Drawing.Size(125, 34);
            this.b_menu.TabIndex = 0;
            this.b_menu.Text = "Меню";
            this.b_menu.UseVisualStyleBackColor = true;
            this.b_menu.Click += new System.EventHandler(this.b_menu_Click);
            this.b_menu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.b_menu_KeyDown);
            // 
            // pB_POLE
            // 
            this.pB_POLE.Location = new System.Drawing.Point(2, 3);
            this.pB_POLE.Name = "pB_POLE";
            this.pB_POLE.Size = new System.Drawing.Size(1123, 716);
            this.pB_POLE.TabIndex = 2;
            this.pB_POLE.TabStop = false;
            // 
            // pB_Person
            // 
            this.pB_Person.BackColor = System.Drawing.Color.Black;
            this.pB_Person.Location = new System.Drawing.Point(15, 15);
            this.pB_Person.Name = "pB_Person";
            this.pB_Person.Size = new System.Drawing.Size(24, 26);
            this.pB_Person.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Person.TabIndex = 3;
            this.pB_Person.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // l_time
            // 
            this.l_time.AutoSize = true;
            this.l_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_time.Location = new System.Drawing.Point(1150, 189);
            this.l_time.Name = "l_time";
            this.l_time.Size = new System.Drawing.Size(0, 24);
            this.l_time.TabIndex = 4;
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_level);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(1142, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 88);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Уровень";
            // 
            // l_level
            // 
            this.l_level.AutoSize = true;
            this.l_level.Location = new System.Drawing.Point(6, 43);
            this.l_level.Name = "l_level";
            this.l_level.Size = new System.Drawing.Size(0, 24);
            this.l_level.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1151, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // FormLevel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 720);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.l_time);
            this.Controls.Add(this.pB_Person);
            this.Controls.Add(this.pB_POLE);
            this.Controls.Add(this.b_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLevel1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.FormLevel1_Activated);
            this.Load += new System.EventHandler(this.FormLevel1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormLevel1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pB_POLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Person)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_menu;
        private System.Windows.Forms.PictureBox pB_Person;
        private System.Windows.Forms.PictureBox pB_POLE;
        private System.Windows.Forms.Label l_time;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label l_level;
        private System.Windows.Forms.Label label1;

    }
}