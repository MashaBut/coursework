﻿namespace CourseWork
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Exit = new System.Windows.Forms.Button();
            this.NameClient = new System.Windows.Forms.TextBox();
            this.PasswordClient = new System.Windows.Forms.TextBox();
            this.CloseForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckIn = new System.Windows.Forms.Button();
            this.InfoClient = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.AutoEllipsis = true;
            this.Exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.CausesValidation = false;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Palatino Linotype", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.Transparent;
            this.Exit.Location = new System.Drawing.Point(181, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(28, 28);
            this.Exit.TabIndex = 5;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // NameClient
            // 
            this.NameClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.NameClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameClient.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameClient.ForeColor = System.Drawing.Color.Black;
            this.NameClient.Location = new System.Drawing.Point(27, 133);
            this.NameClient.Multiline = true;
            this.NameClient.Name = "NameClient";
            this.NameClient.Size = new System.Drawing.Size(164, 24);
            this.NameClient.TabIndex = 0;
            // 
            // PasswordClient
            // 
            this.PasswordClient.AcceptsReturn = true;
            this.PasswordClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.PasswordClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordClient.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.PasswordClient.Font = new System.Drawing.Font("Cambria", 12F);
            this.PasswordClient.ForeColor = System.Drawing.Color.Black;
            this.PasswordClient.Location = new System.Drawing.Point(26, 184);
            this.PasswordClient.Multiline = true;
            this.PasswordClient.Name = "PasswordClient";
            this.PasswordClient.Size = new System.Drawing.Size(164, 24);
            this.PasswordClient.TabIndex = 1;
            // 
            // CloseForm
            // 
            this.CloseForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CloseForm.FlatAppearance.BorderSize = 0;
            this.CloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseForm.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold);
            this.CloseForm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CloseForm.Location = new System.Drawing.Point(50, 233);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(112, 37);
            this.CloseForm.TabIndex = 2;
            this.CloseForm.Text = "Вход";
            this.CloseForm.UseVisualStyleBackColor = false;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(22, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль:";
            // 
            // CheckIn
            // 
            this.CheckIn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CheckIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CheckIn.FlatAppearance.BorderSize = 0;
            this.CheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckIn.Font = new System.Drawing.Font("Century Schoolbook", 8F);
            this.CheckIn.ForeColor = System.Drawing.Color.White;
            this.CheckIn.Location = new System.Drawing.Point(50, 272);
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.Size = new System.Drawing.Size(112, 24);
            this.CheckIn.TabIndex = 3;
            this.CheckIn.Text = "Регистрация";
            this.CheckIn.UseVisualStyleBackColor = false;
            this.CheckIn.Click += new System.EventHandler(this.CheckIn_Click);
            // 
            // InfoClient
            // 
            this.InfoClient.AutoSize = true;
            this.InfoClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.InfoClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoClient.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoClient.ForeColor = System.Drawing.Color.White;
            this.InfoClient.Location = new System.Drawing.Point(5, 215);
            this.InfoClient.Name = "InfoClient";
            this.InfoClient.Size = new System.Drawing.Size(0, 17);
            this.InfoClient.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 66);
            this.label3.TabIndex = 6;
            this.label3.Text = "TestHub";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(212, 297);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InfoClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckIn);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.PasswordClient);
            this.Controls.Add(this.NameClient);
            this.Controls.Add(this.Exit);
            this.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestHub";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox PasswordClient;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CheckIn;
        public System.Windows.Forms.Label InfoClient;
        public System.Windows.Forms.TextBox NameClient;
        private System.Windows.Forms.Label label3;
    }
}

