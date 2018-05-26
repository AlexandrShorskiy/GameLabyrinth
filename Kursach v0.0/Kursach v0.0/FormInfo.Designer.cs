namespace Kursach_v0._0
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            this.rtb_info = new System.Windows.Forms.RichTextBox();
            this.b_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_info
            // 
            this.rtb_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_info.Location = new System.Drawing.Point(0, 0);
            this.rtb_info.Name = "rtb_info";
            this.rtb_info.ReadOnly = true;
            this.rtb_info.Size = new System.Drawing.Size(348, 458);
            this.rtb_info.TabIndex = 1;
            this.rtb_info.Text = resources.GetString("rtb_info.Text");
            this.rtb_info.TextChanged += new System.EventHandler(this.rtb_info_TextChanged);
            // 
            // b_ok
            // 
            this.b_ok.BackColor = System.Drawing.Color.Transparent;
            this.b_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.b_ok.Location = new System.Drawing.Point(12, 399);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(324, 47);
            this.b_ok.TabIndex = 2;
            this.b_ok.Text = "OK";
            this.b_ok.UseVisualStyleBackColor = false;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 458);
            this.Controls.Add(this.b_ok);
            this.Controls.Add(this.rtb_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_info;
        private System.Windows.Forms.Button b_ok;

    }
}