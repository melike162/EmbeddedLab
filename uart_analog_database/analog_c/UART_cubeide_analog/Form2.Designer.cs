namespace UART_cubeide_analog
{
    partial class Form2
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
            this.cmb_baundrate = new System.Windows.Forms.ComboBox();
            this.cmb_table = new System.Windows.Forms.ComboBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_reflesh = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_writeDatabase = new System.Windows.Forms.Button();
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_comport
            // 
            this.cmb_comport.FormattingEnabled = true;
            this.cmb_comport.Location = new System.Drawing.Point(58, 58);
            this.cmb_comport.Name = "cmb_comport";
            this.cmb_comport.Size = new System.Drawing.Size(148, 28);
            this.cmb_comport.TabIndex = 0;
            // 
            // cmb_baundrate
            // 
            this.cmb_baundrate.FormattingEnabled = true;
            this.cmb_baundrate.Location = new System.Drawing.Point(58, 103);
            this.cmb_baundrate.Name = "cmb_baundrate";
            this.cmb_baundrate.Size = new System.Drawing.Size(148, 28);
            this.cmb_baundrate.TabIndex = 1;
            // 
            // cmb_table
            // 
            this.cmb_table.FormattingEnabled = true;
            this.cmb_table.Location = new System.Drawing.Point(36, 36);
            this.cmb_table.Name = "cmb_table";
            this.cmb_table.Size = new System.Drawing.Size(148, 28);
            this.cmb_table.TabIndex = 2;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(258, 53);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(117, 36);
            this.btn_connect.TabIndex = 3;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_reflesh
            // 
            this.btn_reflesh.Location = new System.Drawing.Point(258, 98);
            this.btn_reflesh.Name = "btn_reflesh";
            this.btn_reflesh.Size = new System.Drawing.Size(117, 36);
            this.btn_reflesh.TabIndex = 4;
            this.btn_reflesh.Text = "Reflesh";
            this.btn_reflesh.UseVisualStyleBackColor = true;
            this.btn_reflesh.Click += new System.EventHandler(this.btn_reflesh_Click);
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(236, 31);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(117, 36);
            this.btn_show.TabIndex = 5;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click_1);
            // 
            // btn_writeDatabase
            // 
            this.btn_writeDatabase.Enabled = false;
            this.btn_writeDatabase.Location = new System.Drawing.Point(58, 156);
            this.btn_writeDatabase.Name = "btn_writeDatabase";
            this.btn_writeDatabase.Size = new System.Drawing.Size(317, 36);
            this.btn_writeDatabase.TabIndex = 6;
            this.btn_writeDatabase.Text = "Write The Database";
            this.btn_writeDatabase.UseVisualStyleBackColor = true;
            this.btn_writeDatabase.Click += new System.EventHandler(this.btn_writeDatabase_Click);
            // 
            // dgv_table
            // 
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_table.Location = new System.Drawing.Point(58, 334);
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.RowHeadersWidth = 62;
            this.dgv_table.RowTemplate.Height = 28;
            this.dgv_table.Size = new System.Drawing.Size(317, 184);
            this.dgv_table.TabIndex = 7;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(258, 561);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(117, 31);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(22, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 174);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_table);
            this.groupBox2.Controls.Add(this.btn_show);
            this.groupBox2.Location = new System.Drawing.Point(22, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 317);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Table";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 612);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.dgv_table);
            this.Controls.Add(this.btn_writeDatabase);
            this.Controls.Add(this.btn_reflesh);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.cmb_baundrate);
            this.Controls.Add(this.cmb_comport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_comport;
        private System.Windows.Forms.ComboBox cmb_baundrate;
        private System.Windows.Forms.ComboBox cmb_table;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_reflesh;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_writeDatabase;
        private System.Windows.Forms.DataGridView dgv_table;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}