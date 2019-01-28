namespace CourseWork
{
    partial class Testing
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Test = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BoxForCategory = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.level = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Test
            // 
            this.Test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Test.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Test.FlatAppearance.BorderSize = 0;
            this.Test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Test.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Test.ForeColor = System.Drawing.Color.White;
            this.Test.Location = new System.Drawing.Point(288, 518);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(325, 51);
            this.Test.TabIndex = 8;
            this.Test.Text = "Пройти тест";
            this.Test.UseVisualStyleBackColor = false;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BoxForCategory);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(167, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 224);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Категории";
            // 
            // BoxForCategory
            // 
            this.BoxForCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BoxForCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxForCategory.Font = new System.Drawing.Font("Cambria", 10F);
            this.BoxForCategory.ForeColor = System.Drawing.Color.White;
            this.BoxForCategory.FormattingEnabled = true;
            this.BoxForCategory.ItemHeight = 20;
            this.BoxForCategory.Location = new System.Drawing.Point(11, 18);
            this.BoxForCategory.Name = "BoxForCategory";
            this.BoxForCategory.Size = new System.Drawing.Size(285, 200);
            this.BoxForCategory.TabIndex = 2;
            this.BoxForCategory.SelectedIndexChanged += new System.EventHandler(this.BoxForCategory_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.level);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 10F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(513, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 139);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Уровень сложности";
            // 
            // level
            // 
            this.level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.level.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.level.Font = new System.Drawing.Font("Cambria", 16F);
            this.level.ForeColor = System.Drawing.Color.White;
            this.level.FormattingEnabled = true;
            this.level.ItemHeight = 32;
            this.level.Location = new System.Drawing.Point(26, 26);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(164, 96);
            this.level.TabIndex = 2;
            this.level.SelectedIndexChanged += new System.EventHandler(this.Level_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 44F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label3.Location = new System.Drawing.Point(265, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 101);
            this.label3.TabIndex = 11;
            this.label3.Text = "TestHub";
            // 
            // Testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Test);
            this.Name = "Testing";
            this.Size = new System.Drawing.Size(900, 722);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox BoxForCategory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox level;
        private System.Windows.Forms.Label label3;
    }
}
