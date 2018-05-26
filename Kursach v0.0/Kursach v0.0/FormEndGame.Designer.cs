namespace Kursach_v0._0
{
    partial class FormEndGame
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
            this.b_inMenu = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b_inMenu
            // 
            this.b_inMenu.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.b_inMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_inMenu.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_inMenu.Location = new System.Drawing.Point(266, 230);
            this.b_inMenu.Name = "b_inMenu";
            this.b_inMenu.Size = new System.Drawing.Size(220, 49);
            this.b_inMenu.TabIndex = 0;
            this.b_inMenu.Text = "Выйти";
            this.b_inMenu.UseVisualStyleBackColor = false;
            this.b_inMenu.Click += new System.EventHandler(this.b_inMenu_Click);
            // 
            // b_save
            // 
            this.b_save.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.b_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_save.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_save.Location = new System.Drawing.Point(25, 230);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(220, 49);
            this.b_save.TabIndex = 1;
            this.b_save.Text = "Сохранить и продолжить";
            this.b_save.UseVisualStyleBackColor = false;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ваш результат";
            // 
            // tb_result
            // 
            this.tb_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_result.Location = new System.Drawing.Point(25, 60);
            this.tb_result.Multiline = true;
            this.tb_result.Name = "tb_result";
            this.tb_result.ReadOnly = true;
            this.tb_result.Size = new System.Drawing.Size(461, 46);
            this.tb_result.TabIndex = 3;
            this.tb_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите имя для сохранения";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_name.Location = new System.Drawing.Point(25, 153);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(461, 40);
            this.tb_name.TabIndex = 5;
            this.tb_name.Text = "Player";
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormEndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(521, 291);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_inMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEndGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FormEndGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_inMenu;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name;
    }
}