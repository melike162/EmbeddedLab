namespace UART_cubeide
{
    partial class MainForm
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
            this.cmb_comport = new System.Windows.Forms.ComboBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.cmb_baudrate = new System.Windows.Forms.ComboBox();
            this.btn_reflesh = new System.Windows.Forms.Button();
            this.btn_led1 = new System.Windows.Forms.Button();
            this.btn_led2 = new System.Windows.Forms.Button();
            this.btn_led3 = new System.Windows.Forms.Button();
            this.btn_led4 = new System.Windows.Forms.Button();
            this.txtb_receive = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmb_comport
            // 
            this.cmb_comport.FormattingEnabled = true;
            this.cmb_comport.Location = new System.Drawing.Point(43, 17);
            this.cmb_comport.Name = "cmb_comport";
            this.cmb_comport.Size = new System.Drawing.Size(143, 28);
            this.cmb_comport.TabIndex = 0;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(231, 17);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(111, 36);
            this.btn_connect.TabIndex = 1;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // cmb_baudrate
            // 
            this.cmb_baudrate.FormattingEnabled = true;
            this.cmb_baudrate.Location = new System.Drawing.Point(43, 67);
            this.cmb_baudrate.Name = "cmb_baudrate";
            this.cmb_baudrate.Size = new System.Drawing.Size(143, 28);
            this.cmb_baudrate.TabIndex = 2;
            // 
            // btn_reflesh
            // 
            this.btn_reflesh.Location = new System.Drawing.Point(231, 59);
            this.btn_reflesh.Name = "btn_reflesh";
            this.btn_reflesh.Size = new System.Drawing.Size(111, 36);
            this.btn_reflesh.TabIndex = 3;
            this.btn_reflesh.Text = "Refresh";
            this.btn_reflesh.UseVisualStyleBackColor = true;
            this.btn_reflesh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_led1
            // 
            this.btn_led1.Enabled = false;
            this.btn_led1.Location = new System.Drawing.Point(43, 141);
            this.btn_led1.Name = "btn_led1";
            this.btn_led1.Size = new System.Drawing.Size(118, 50);
            this.btn_led1.TabIndex = 7;
            this.btn_led1.Text = "LED 1";
            this.btn_led1.UseVisualStyleBackColor = true;
            this.btn_led1.Click += new System.EventHandler(this.btn_led1_Click);
            // 
            // btn_led2
            // 
            this.btn_led2.Enabled = false;
            this.btn_led2.Location = new System.Drawing.Point(231, 141);
            this.btn_led2.Name = "btn_led2";
            this.btn_led2.Size = new System.Drawing.Size(111, 50);
            this.btn_led2.TabIndex = 8;
            this.btn_led2.Text = "LED 2";
            this.btn_led2.UseVisualStyleBackColor = true;
            this.btn_led2.Click += new System.EventHandler(this.btn_led2_Click);
            // 
            // btn_led3
            // 
            this.btn_led3.Enabled = false;
            this.btn_led3.Location = new System.Drawing.Point(43, 227);
            this.btn_led3.Name = "btn_led3";
            this.btn_led3.Size = new System.Drawing.Size(120, 50);
            this.btn_led3.TabIndex = 9;
            this.btn_led3.Text = "LED 3";
            this.btn_led3.UseVisualStyleBackColor = true;
            this.btn_led3.Click += new System.EventHandler(this.btn_led3_Click);
            // 
            // btn_led4
            // 
            this.btn_led4.Enabled = false;
            this.btn_led4.Location = new System.Drawing.Point(231, 227);
            this.btn_led4.Name = "btn_led4";
            this.btn_led4.Size = new System.Drawing.Size(111, 50);
            this.btn_led4.TabIndex = 10;
            this.btn_led4.Text = "LED 4";
            this.btn_led4.UseVisualStyleBackColor = true;
            this.btn_led4.Click += new System.EventHandler(this.btn_led4_Click);
            // 
            // txtb_receive
            // 
            this.txtb_receive.Enabled = false;
            this.txtb_receive.Location = new System.Drawing.Point(43, 314);
            this.txtb_receive.Multiline = true;
            this.txtb_receive.Name = "txtb_receive";
            this.txtb_receive.Size = new System.Drawing.Size(299, 94);
            this.txtb_receive.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 450);
            this.Controls.Add(this.btn_led4);
            this.Controls.Add(this.btn_led3);
            this.Controls.Add(this.btn_led2);
            this.Controls.Add(this.btn_led1);
            this.Controls.Add(this.txtb_receive);
            this.Controls.Add(this.btn_reflesh);
            this.Controls.Add(this.cmb_baudrate);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.cmb_comport);
            this.Name = "MainForm";
            this.Text = "Serial_v1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_comport;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.ComboBox cmb_baudrate;
        private System.Windows.Forms.Button btn_reflesh;
        private System.Windows.Forms.Button btn_led1;
        private System.Windows.Forms.Button btn_led2;
        private System.Windows.Forms.Button btn_led3;
        private System.Windows.Forms.Button btn_led4;
        private System.Windows.Forms.TextBox txtb_receive;
    }
}

