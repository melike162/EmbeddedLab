namespace UART_cubeide_analog
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_name = new System.Windows.Forms.TextBox();
            this.txtb_password = new System.Windows.Forms.TextBox();
            this.txtb_server = new System.Windows.Forms.TextBox();
            this.txtb_database = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name: ";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(78, 333);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(283, 35);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Sign In";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(78, 397);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(283, 35);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Database: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Server: ";
            // 
            // txtb_name
            // 
            this.txtb_name.Location = new System.Drawing.Point(208, 122);
            this.txtb_name.Name = "txtb_name";
            this.txtb_name.Size = new System.Drawing.Size(153, 26);
            this.txtb_name.TabIndex = 6;
            // 
            // txtb_password
            // 
            this.txtb_password.Location = new System.Drawing.Point(208, 166);
            this.txtb_password.Name = "txtb_password";
            this.txtb_password.PasswordChar = '*';
            this.txtb_password.Size = new System.Drawing.Size(153, 26);
            this.txtb_password.TabIndex = 7;
            // 
            // txtb_server
            // 
            this.txtb_server.Location = new System.Drawing.Point(208, 211);
            this.txtb_server.Name = "txtb_server";
            this.txtb_server.Size = new System.Drawing.Size(153, 26);
            this.txtb_server.TabIndex = 8;
            // 
            // txtb_database
            // 
            this.txtb_database.Location = new System.Drawing.Point(208, 259);
            this.txtb_database.Name = "txtb_database";
            this.txtb_database.Size = new System.Drawing.Size(153, 26);
            this.txtb_database.TabIndex = 9;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(78, 456);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(283, 35);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 612);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txtb_database);
            this.Controls.Add(this.txtb_server);
            this.Controls.Add(this.txtb_password);
            this.Controls.Add(this.txtb_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySQL Sing In";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtb_name;
        private System.Windows.Forms.TextBox txtb_password;
        private System.Windows.Forms.TextBox txtb_server;
        private System.Windows.Forms.TextBox txtb_database;
        private System.Windows.Forms.Button btn_exit;
    }
}

