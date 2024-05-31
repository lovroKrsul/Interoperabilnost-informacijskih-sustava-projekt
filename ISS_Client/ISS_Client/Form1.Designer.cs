namespace ISS_Client
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.xsd_tab = new System.Windows.Forms.TabPage();
            this.xsd_lbl = new System.Windows.Forms.Label();
            this.xsd_Result_Tb = new System.Windows.Forms.RichTextBox();
            this.xsd_File_Btn = new System.Windows.Forms.Button();
            this.rng_tab = new System.Windows.Forms.TabPage();
            this.rng_Result_Tb = new System.Windows.Forms.RichTextBox();
            this.rng_File_Btn = new System.Windows.Forms.Button();
            this.Soap_tab = new System.Windows.Forms.TabPage();
            this.Soap_Response_Tb = new System.Windows.Forms.RichTextBox();
            this.Soap_Search_Btn = new System.Windows.Forms.Button();
            this.dhmz_tab = new System.Windows.Forms.TabPage();
            this.RestIntegrate_tab = new System.Windows.Forms.TabPage();
            this.getGames_Btn = new System.Windows.Forms.Button();
            this.Games_Tb = new System.Windows.Forms.RichTextBox();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.xsd_tab.SuspendLayout();
            this.rng_tab.SuspendLayout();
            this.Soap_tab.SuspendLayout();
            this.RestIntegrate_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.xsd_tab);
            this.tabControl.Controls.Add(this.rng_tab);
            this.tabControl.Controls.Add(this.Soap_tab);
            this.tabControl.Controls.Add(this.dhmz_tab);
            this.tabControl.Controls.Add(this.RestIntegrate_tab);
            this.tabControl.Location = new System.Drawing.Point(2, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(787, 433);
            this.tabControl.TabIndex = 0;
            // 
            // xsd_tab
            // 
            this.xsd_tab.Controls.Add(this.xsd_lbl);
            this.xsd_tab.Controls.Add(this.xsd_Result_Tb);
            this.xsd_tab.Controls.Add(this.xsd_File_Btn);
            this.xsd_tab.Location = new System.Drawing.Point(4, 22);
            this.xsd_tab.Name = "xsd_tab";
            this.xsd_tab.Padding = new System.Windows.Forms.Padding(3);
            this.xsd_tab.Size = new System.Drawing.Size(779, 407);
            this.xsd_tab.TabIndex = 0;
            this.xsd_tab.Text = "Validate xsd";
            this.xsd_tab.UseVisualStyleBackColor = true;
            // 
            // xsd_lbl
            // 
            this.xsd_lbl.AutoSize = true;
            this.xsd_lbl.ForeColor = System.Drawing.Color.Red;
            this.xsd_lbl.Location = new System.Drawing.Point(121, 26);
            this.xsd_lbl.Name = "xsd_lbl";
            this.xsd_lbl.Size = new System.Drawing.Size(0, 13);
            this.xsd_lbl.TabIndex = 3;
            // 
            // xsd_Result_Tb
            // 
            this.xsd_Result_Tb.Location = new System.Drawing.Point(23, 80);
            this.xsd_Result_Tb.Name = "xsd_Result_Tb";
            this.xsd_Result_Tb.Size = new System.Drawing.Size(750, 307);
            this.xsd_Result_Tb.TabIndex = 2;
            this.xsd_Result_Tb.Text = "";
            // 
            // xsd_File_Btn
            // 
            this.xsd_File_Btn.Location = new System.Drawing.Point(23, 21);
            this.xsd_File_Btn.Name = "xsd_File_Btn";
            this.xsd_File_Btn.Size = new System.Drawing.Size(75, 23);
            this.xsd_File_Btn.TabIndex = 1;
            this.xsd_File_Btn.Text = "validate";
            this.xsd_File_Btn.UseVisualStyleBackColor = true;
            this.xsd_File_Btn.Click += new System.EventHandler(this.xsd_File_Btn_Click);
            // 
            // rng_tab
            // 
            this.rng_tab.Controls.Add(this.rng_Result_Tb);
            this.rng_tab.Controls.Add(this.rng_File_Btn);
            this.rng_tab.Location = new System.Drawing.Point(4, 22);
            this.rng_tab.Name = "rng_tab";
            this.rng_tab.Padding = new System.Windows.Forms.Padding(3);
            this.rng_tab.Size = new System.Drawing.Size(779, 407);
            this.rng_tab.TabIndex = 1;
            this.rng_tab.Text = "Validate rng";
            this.rng_tab.UseVisualStyleBackColor = true;
            // 
            // rng_Result_Tb
            // 
            this.rng_Result_Tb.Location = new System.Drawing.Point(23, 79);
            this.rng_Result_Tb.Name = "rng_Result_Tb";
            this.rng_Result_Tb.Size = new System.Drawing.Size(750, 307);
            this.rng_Result_Tb.TabIndex = 5;
            this.rng_Result_Tb.Text = "";
            // 
            // rng_File_Btn
            // 
            this.rng_File_Btn.Location = new System.Drawing.Point(23, 22);
            this.rng_File_Btn.Name = "rng_File_Btn";
            this.rng_File_Btn.Size = new System.Drawing.Size(75, 23);
            this.rng_File_Btn.TabIndex = 4;
            this.rng_File_Btn.Text = "validate";
            this.rng_File_Btn.UseVisualStyleBackColor = true;
            this.rng_File_Btn.Click += new System.EventHandler(this.rng_File_Btn_Click);
            // 
            // Soap_tab
            // 
            this.Soap_tab.Controls.Add(this.button1);
            this.Soap_tab.Controls.Add(this.search_tb);
            this.Soap_tab.Controls.Add(this.Soap_Response_Tb);
            this.Soap_tab.Controls.Add(this.Soap_Search_Btn);
            this.Soap_tab.Location = new System.Drawing.Point(4, 22);
            this.Soap_tab.Name = "Soap_tab";
            this.Soap_tab.Size = new System.Drawing.Size(779, 407);
            this.Soap_tab.TabIndex = 2;
            this.Soap_tab.Text = "Soap";
            this.Soap_tab.UseVisualStyleBackColor = true;
            // 
            // Soap_Response_Tb
            // 
            this.Soap_Response_Tb.Location = new System.Drawing.Point(23, 79);
            this.Soap_Response_Tb.Name = "Soap_Response_Tb";
            this.Soap_Response_Tb.Size = new System.Drawing.Size(750, 307);
            this.Soap_Response_Tb.TabIndex = 5;
            this.Soap_Response_Tb.Text = "";
            // 
            // Soap_Search_Btn
            // 
            this.Soap_Search_Btn.Location = new System.Drawing.Point(294, 20);
            this.Soap_Search_Btn.Name = "Soap_Search_Btn";
            this.Soap_Search_Btn.Size = new System.Drawing.Size(75, 23);
            this.Soap_Search_Btn.TabIndex = 4;
            this.Soap_Search_Btn.Text = "search";
            this.Soap_Search_Btn.UseVisualStyleBackColor = true;
            this.Soap_Search_Btn.Click += new System.EventHandler(this.Soap_Search_Btn_Click);
            // 
            // dhmz_tab
            // 
            this.dhmz_tab.Location = new System.Drawing.Point(4, 22);
            this.dhmz_tab.Name = "dhmz_tab";
            this.dhmz_tab.Size = new System.Drawing.Size(779, 407);
            this.dhmz_tab.TabIndex = 3;
            this.dhmz_tab.Text = "DHMZ";
            this.dhmz_tab.UseVisualStyleBackColor = true;
            // 
            // RestIntegrate_tab
            // 
            this.RestIntegrate_tab.Controls.Add(this.getGames_Btn);
            this.RestIntegrate_tab.Controls.Add(this.Games_Tb);
            this.RestIntegrate_tab.Location = new System.Drawing.Point(4, 22);
            this.RestIntegrate_tab.Name = "RestIntegrate_tab";
            this.RestIntegrate_tab.Size = new System.Drawing.Size(779, 407);
            this.RestIntegrate_tab.TabIndex = 4;
            this.RestIntegrate_tab.Text = "Integracija";
            this.RestIntegrate_tab.UseVisualStyleBackColor = true;
            // 
            // getGames_Btn
            // 
            this.getGames_Btn.Location = new System.Drawing.Point(18, 22);
            this.getGames_Btn.Name = "getGames_Btn";
            this.getGames_Btn.Size = new System.Drawing.Size(75, 23);
            this.getGames_Btn.TabIndex = 1;
            this.getGames_Btn.Text = "get games";
            this.getGames_Btn.UseVisualStyleBackColor = true;
            this.getGames_Btn.Click += new System.EventHandler(this.getGames_Btn_Click);
            // 
            // Games_Tb
            // 
            this.Games_Tb.Location = new System.Drawing.Point(18, 59);
            this.Games_Tb.Name = "Games_Tb";
            this.Games_Tb.Size = new System.Drawing.Size(758, 344);
            this.Games_Tb.TabIndex = 0;
            this.Games_Tb.Text = "";
            // 
            // search_tb
            // 
            this.search_tb.Location = new System.Drawing.Point(55, 20);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(233, 20);
            this.search_tb.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "generate xml";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.xsd_tab.ResumeLayout(false);
            this.xsd_tab.PerformLayout();
            this.rng_tab.ResumeLayout(false);
            this.Soap_tab.ResumeLayout(false);
            this.Soap_tab.PerformLayout();
            this.RestIntegrate_tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage xsd_tab;
        private System.Windows.Forms.TabPage rng_tab;
        private System.Windows.Forms.RichTextBox xsd_Result_Tb;
        private System.Windows.Forms.Button xsd_File_Btn;
        private System.Windows.Forms.RichTextBox rng_Result_Tb;
        private System.Windows.Forms.Button rng_File_Btn;
        private System.Windows.Forms.TabPage Soap_tab;
        private System.Windows.Forms.TabPage dhmz_tab;
        private System.Windows.Forms.TabPage RestIntegrate_tab;
        private System.Windows.Forms.RichTextBox Soap_Response_Tb;
        private System.Windows.Forms.Button Soap_Search_Btn;
        private System.Windows.Forms.Button getGames_Btn;
        private System.Windows.Forms.RichTextBox Games_Tb;
        private System.Windows.Forms.Label xsd_lbl;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.Button button1;
    }
}

