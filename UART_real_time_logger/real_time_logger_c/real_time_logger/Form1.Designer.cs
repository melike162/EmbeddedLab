namespace real_time_logger
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
            this.btn_writeDatabase = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.cmb_baundrate = new System.Windows.Forms.ComboBox();
            this.cmb_comport = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.cmb_table = new System.Windows.Forms.ComboBox();
            this.txt_creat = new System.Windows.Forms.TextBox();
            this.btn_creat = new System.Windows.Forms.Button();
            this.cmb_write = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_writeDatabase
            // 
            this.btn_writeDatabase.Enabled = false;
            this.btn_writeDatabase.Location = new System.Drawing.Point(269, 246);
            this.btn_writeDatabase.Name = "btn_writeDatabase";
            this.btn_writeDatabase.Size = new System.Drawing.Size(117, 36);
            this.btn_writeDatabase.TabIndex = 15;
            this.btn_writeDatabase.Text = "Write";
            this.btn_writeDatabase.UseVisualStyleBackColor = true;
            this.btn_writeDatabase.Click += new System.EventHandler(this.btn_writeDatabase_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(269, 92);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(117, 36);
            this.btn_refresh.TabIndex = 14;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(269, 47);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(117, 36);
            this.btn_connect.TabIndex = 13;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // cmb_baundrate
            // 
            this.cmb_baundrate.FormattingEnabled = true;
            this.cmb_baundrate.Location = new System.Drawing.Point(69, 97);
            this.cmb_baundrate.Name = "cmb_baundrate";
            this.cmb_baundrate.Size = new System.Drawing.Size(148, 28);
            this.cmb_baundrate.TabIndex = 12;
            // 
            // cmb_comport
            // 
            this.cmb_comport.FormattingEnabled = true;
            this.cmb_comport.Location = new System.Drawing.Point(69, 52);
            this.cmb_comport.Name = "cmb_comport";
            this.cmb_comport.Size = new System.Drawing.Size(148, 28);
            this.cmb_comport.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(33, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 125);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(1017, 658);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(117, 31);
            this.btn_exit.TabIndex = 18;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dgv_table
            // 
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_table.Location = new System.Drawing.Point(69, 436);
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.RowHeadersWidth = 62;
            this.dgv_table.RowTemplate.Height = 28;
            this.dgv_table.Size = new System.Drawing.Size(317, 184);
            this.dgv_table.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_show);
            this.groupBox2.Controls.Add(this.cmb_table);
            this.groupBox2.Location = new System.Drawing.Point(33, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 310);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Table";
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(236, 20);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(117, 36);
            this.btn_show.TabIndex = 5;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // cmb_table
            // 
            this.cmb_table.FormattingEnabled = true;
            this.cmb_table.Location = new System.Drawing.Point(36, 25);
            this.cmb_table.Name = "cmb_table";
            this.cmb_table.Size = new System.Drawing.Size(148, 28);
            this.cmb_table.TabIndex = 2;
            // 
            // txt_creat
            // 
            this.txt_creat.Location = new System.Drawing.Point(69, 196);
            this.txt_creat.Name = "txt_creat";
            this.txt_creat.Size = new System.Drawing.Size(148, 26);
            this.txt_creat.TabIndex = 20;
            // 
            // btn_creat
            // 
            this.btn_creat.Location = new System.Drawing.Point(269, 191);
            this.btn_creat.Name = "btn_creat";
            this.btn_creat.Size = new System.Drawing.Size(117, 36);
            this.btn_creat.TabIndex = 21;
            this.btn_creat.Text = "Creat Table";
            this.btn_creat.UseVisualStyleBackColor = true;
            this.btn_creat.Click += new System.EventHandler(this.btn_creat_Click);
            // 
            // cmb_write
            // 
            this.cmb_write.Enabled = false;
            this.cmb_write.FormattingEnabled = true;
            this.cmb_write.Location = new System.Drawing.Point(69, 254);
            this.cmb_write.Name = "cmb_write";
            this.cmb_write.Size = new System.Drawing.Size(148, 28);
            this.cmb_write.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(33, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 134);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // formsPlot1
            // 
            this.formsPlot1.DisplayScale = 0F;
            this.formsPlot1.Location = new System.Drawing.Point(463, 35);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(694, 606);
            this.formsPlot1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 710);
            this.Controls.Add(this.formsPlot1);
            this.Controls.Add(this.cmb_write);
            this.Controls.Add(this.btn_writeDatabase);
            this.Controls.Add(this.btn_creat);
            this.Controls.Add(this.txt_creat);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.dgv_table);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.cmb_baundrate);
            this.Controls.Add(this.cmb_comport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_writeDatabase;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.ComboBox cmb_baundrate;
        private System.Windows.Forms.ComboBox cmb_comport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridView dgv_table;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_table;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.TextBox txt_creat;
        private System.Windows.Forms.Button btn_creat;
        private System.Windows.Forms.ComboBox cmb_write;
        private System.Windows.Forms.GroupBox groupBox3;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
    }
}

