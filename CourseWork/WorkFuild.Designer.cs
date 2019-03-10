namespace CourseWork
{
    partial class WorkFuild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkFuild));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Set = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.Button();
            this.Library = new System.Windows.Forms.Button();
            this.WriteTest = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Button();
            this.honors1 = new CourseWork.Honors();
            this.settings1 = new CourseWork.Settings();
            this.library2 = new CourseWork.Library();
            this.testing2 = new CourseWork.Testing();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Set);
            this.panel1.Controls.Add(this.Table);
            this.panel1.Controls.Add(this.Library);
            this.panel1.Controls.Add(this.WriteTest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 750);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.panel3.Location = new System.Drawing.Point(0, 339);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 92);
            this.panel3.TabIndex = 2;
            // 
            // Set
            // 
            this.Set.FlatAppearance.BorderSize = 0;
            this.Set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Set.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Set.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(236)))));
            this.Set.Image = ((System.Drawing.Image)(resources.GetObject("Set.Image")));
            this.Set.Location = new System.Drawing.Point(0, 633);
            this.Set.Name = "Set";
            this.Set.Size = new System.Drawing.Size(270, 92);
            this.Set.TabIndex = 5;
            this.Set.Text = "Настройки";
            this.Set.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Set.UseVisualStyleBackColor = true;
            this.Set.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Table
            // 
            this.Table.FlatAppearance.BorderSize = 0;
            this.Table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Table.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Table.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(236)))));
            this.Table.Image = ((System.Drawing.Image)(resources.GetObject("Table.Image")));
            this.Table.Location = new System.Drawing.Point(0, 535);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(270, 92);
            this.Table.TabIndex = 6;
            this.Table.Text = " Таблица  дослижений";
            this.Table.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Table.UseVisualStyleBackColor = true;
            this.Table.Click += new System.EventHandler(this.Table_Click);
            // 
            // Library
            // 
            this.Library.FlatAppearance.BorderSize = 0;
            this.Library.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Library.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Library.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(236)))));
            this.Library.Image = ((System.Drawing.Image)(resources.GetObject("Library.Image")));
            this.Library.Location = new System.Drawing.Point(0, 437);
            this.Library.Name = "Library";
            this.Library.Size = new System.Drawing.Size(270, 92);
            this.Library.TabIndex = 7;
            this.Library.Text = "Библиотека";
            this.Library.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Library.UseVisualStyleBackColor = true;
            this.Library.Click += new System.EventHandler(this.Library_Click);
            // 
            // WriteTest
            // 
            this.WriteTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WriteTest.FlatAppearance.BorderSize = 0;
            this.WriteTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WriteTest.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WriteTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(236)))));
            this.WriteTest.Image = ((System.Drawing.Image)(resources.GetObject("WriteTest.Image")));
            this.WriteTest.Location = new System.Drawing.Point(0, 339);
            this.WriteTest.Name = "WriteTest";
            this.WriteTest.Size = new System.Drawing.Size(270, 92);
            this.WriteTest.TabIndex = 8;
            this.WriteTest.Text = "Пройти тест";
            this.WriteTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WriteTest.UseVisualStyleBackColor = true;
            this.WriteTest.Click += new System.EventHandler(this.WriteTest_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.Close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(270, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 30);
            this.panel2.TabIndex = 1;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Close.BackgroundImage")));
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Close.ForeColor = System.Drawing.Color.Transparent;
            this.Close.Location = new System.Drawing.Point(870, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(30, 30);
            this.Close.TabIndex = 0;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // honors1
            // 
            this.honors1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.honors1.Location = new System.Drawing.Point(270, 28);
            this.honors1.Name = "honors1";
            this.honors1.Size = new System.Drawing.Size(900, 722);
            this.honors1.TabIndex = 3;
            this.honors1.Load += new System.EventHandler(this.honors1_Load);
            // 
            // settings1
            // 
            this.settings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.settings1.Location = new System.Drawing.Point(273, 28);
            this.settings1.Name = "settings1";
            this.settings1.Size = new System.Drawing.Size(900, 722);
            this.settings1.TabIndex = 2;
            // 
            // library2
            // 
            this.library2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.library2.ForeColor = System.Drawing.Color.White;
            this.library2.Location = new System.Drawing.Point(270, 28);
            this.library2.Name = "library2";
            this.library2.Size = new System.Drawing.Size(900, 722);
            this.library2.TabIndex = 4;
            // 
            // testing2
            // 
            this.testing2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.testing2.Location = new System.Drawing.Point(269, 25);
            this.testing2.Name = "testing2";
            this.testing2.Size = new System.Drawing.Size(900, 722);
            this.testing2.TabIndex = 5;
            // 
            // WorkFuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1170, 750);
            this.Controls.Add(this.testing2);
            this.Controls.Add(this.library2);
            this.Controls.Add(this.honors1);
            this.Controls.Add(this.settings1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkFuild";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestHub";
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.WorkFuild_Layout);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Set;
        private System.Windows.Forms.Button Table;
        private System.Windows.Forms.Button Library;
        private System.Windows.Forms.Button WriteTest;
        private System.Windows.Forms.Panel panel3;
        private Settings settings1;
        private Honors honors1;
        private Library library2;
        private Testing testing2;
    }
}