namespace Anti_VirusTut
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnPick = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListBox();
            this.metroProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.metroLabel1 = new System.Windows.Forms.Label();
            this.metroLabel2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select Folder";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.btnPick.BackColor = System.Drawing.SystemColors.Control;
            this.btnPick.Location = new System.Drawing.Point(12, 86);
            this.btnPick.Name = "button2";
            this.btnPick.Size = new System.Drawing.Size(141, 45);
            this.btnPick.TabIndex = 1;
            this.btnPick.Text = "Scan";
            this.btnPick.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.MenuText;
            this.listView1.FormattingEnabled = true;
            this.listView1.Items.AddRange(new object[] {
            "................................................................................." +
                "................................................................................" +
                "............"});
            this.listView1.Location = new System.Drawing.Point(175, 44);
            this.listView1.Name = "listBox1";
            this.listView1.Size = new System.Drawing.Size(527, 394);
            this.listView1.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(12, 440);
            this.metroProgressBar1.Name = "progressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(674, 23);
            this.metroProgressBar1.TabIndex = 5;
            // 
            // label1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 223);
            this.metroLabel1.Name = "label1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 13);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Viruses";
            // 
            // label2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 472);
            this.metroLabel2.Name = "label2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 13);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Folder";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(365, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(124, 26);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "Hound AV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(783, 494);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "HoundAV";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.ListBox listView1;
        private System.Windows.Forms.ProgressBar metroProgressBar1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label metroLabel1;
        private System.Windows.Forms.Label metroLabel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

