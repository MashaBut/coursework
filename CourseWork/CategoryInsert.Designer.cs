namespace CourseWork
{
    partial class CategoryInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryInsert));
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UPDATE = new System.Windows.Forms.Button();
            this.Createcategory = new System.Windows.Forms.TextBox();
            this.InfoClient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.Color.Transparent;
            this.Exit.Location = new System.Drawing.Point(288, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(28, 28);
            this.Exit.TabIndex = 6;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "Создать категорию";
            // 
            // UPDATE
            // 
            this.UPDATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.UPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UPDATE.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.UPDATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(236)))));
            this.UPDATE.Location = new System.Drawing.Point(70, 137);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(185, 38);
            this.UPDATE.TabIndex = 11;
            this.UPDATE.Text = "Создать";
            this.UPDATE.UseMnemonic = false;
            this.UPDATE.UseVisualStyleBackColor = false;
            this.UPDATE.Click += new System.EventHandler(this.INSERT_Click);
            // 
            // Createcategory
            // 
            this.Createcategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.Createcategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Createcategory.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Createcategory.ForeColor = System.Drawing.Color.Black;
            this.Createcategory.Location = new System.Drawing.Point(83, 83);
            this.Createcategory.Name = "Createcategory";
            this.Createcategory.Size = new System.Drawing.Size(158, 28);
            this.Createcategory.TabIndex = 12;
            // 
            // InfoClient
            // 
            this.InfoClient.AutoSize = true;
            this.InfoClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.InfoClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoClient.Font = new System.Drawing.Font("Century", 10.2F);
            this.InfoClient.ForeColor = System.Drawing.Color.White;
            this.InfoClient.Location = new System.Drawing.Point(246, 85);
            this.InfoClient.Name = "InfoClient";
            this.InfoClient.Size = new System.Drawing.Size(0, 21);
            this.InfoClient.TabIndex = 13;
            // 
            // CategoryInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(324, 193);
            this.Controls.Add(this.InfoClient);
            this.Controls.Add(this.Createcategory);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CaterogoryInsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UPDATE;
        public System.Windows.Forms.Label InfoClient;
        public System.Windows.Forms.TextBox Createcategory;
    }
}