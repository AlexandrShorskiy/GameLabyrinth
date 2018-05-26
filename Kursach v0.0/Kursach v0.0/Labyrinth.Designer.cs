namespace Kursach_v0._0
{
    partial class Labyrinth
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Labyrinth));
            this.Start = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.b_settings = new System.Windows.Forms.Button();
            this.b_progress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.DarkGray;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Start.Location = new System.Drawing.Point(86, 49);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(213, 74);
            this.Start.TabIndex = 0;
            this.Start.Text = "Начать игру";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.DarkGray;
            this.Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Info.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Info.Location = new System.Drawing.Point(86, 289);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(213, 74);
            this.Info.TabIndex = 1;
            this.Info.Text = "О программе";
            this.Info.UseVisualStyleBackColor = false;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.DarkGray;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Exit.Location = new System.Drawing.Point(86, 369);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(213, 74);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // b_settings
            // 
            this.b_settings.BackColor = System.Drawing.Color.DarkGray;
            this.b_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_settings.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_settings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_settings.Location = new System.Drawing.Point(86, 209);
            this.b_settings.Name = "b_settings";
            this.b_settings.Size = new System.Drawing.Size(213, 74);
            this.b_settings.TabIndex = 4;
            this.b_settings.Text = "Настройки";
            this.b_settings.UseVisualStyleBackColor = false;
            this.b_settings.Click += new System.EventHandler(this.b_settings_Click);
            // 
            // b_progress
            // 
            this.b_progress.BackColor = System.Drawing.Color.DarkGray;
            this.b_progress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_progress.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_progress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_progress.Location = new System.Drawing.Point(86, 129);
            this.b_progress.Name = "b_progress";
            this.b_progress.Size = new System.Drawing.Size(213, 74);
            this.b_progress.TabIndex = 5;
            this.b_progress.Text = "Достижения";
            this.b_progress.UseVisualStyleBackColor = false;
            this.b_progress.Click += new System.EventHandler(this.b_progress_Click);
            // 
            // Labyrinth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 689);
            this.Controls.Add(this.b_progress);
            this.Controls.Add(this.b_settings);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 525);
            this.Name = "Labyrinth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабиринт";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Labyrinth_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button b_settings;
        private System.Windows.Forms.Button b_progress;
    }
}

