namespace SzallashelyKezelo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.szallasFelvitelBtn = new System.Windows.Forms.Button();
            this.szallasTorlesBtn = new System.Windows.Forms.Button();
            this.adatokKimenteseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(572, 424);
            this.listBox1.TabIndex = 0;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // szallasFelvitelBtn
            // 
            this.szallasFelvitelBtn.Location = new System.Drawing.Point(603, 12);
            this.szallasFelvitelBtn.Name = "szallasFelvitelBtn";
            this.szallasFelvitelBtn.Size = new System.Drawing.Size(185, 23);
            this.szallasFelvitelBtn.TabIndex = 1;
            this.szallasFelvitelBtn.Text = "Szálláshely felvitele";
            this.szallasFelvitelBtn.UseVisualStyleBackColor = true;
            this.szallasFelvitelBtn.Click += new System.EventHandler(this.szallasFelvitelBtn_Click);
            // 
            // szallasTorlesBtn
            // 
            this.szallasTorlesBtn.Location = new System.Drawing.Point(603, 61);
            this.szallasTorlesBtn.Name = "szallasTorlesBtn";
            this.szallasTorlesBtn.Size = new System.Drawing.Size(185, 23);
            this.szallasTorlesBtn.TabIndex = 2;
            this.szallasTorlesBtn.Text = "Szálláshely törlése";
            this.szallasTorlesBtn.UseVisualStyleBackColor = true;
            this.szallasTorlesBtn.Click += new System.EventHandler(this.szallasTorlesBtn_Click);
            // 
            // adatokKimenteseBtn
            // 
            this.adatokKimenteseBtn.Location = new System.Drawing.Point(603, 413);
            this.adatokKimenteseBtn.Name = "adatokKimenteseBtn";
            this.adatokKimenteseBtn.Size = new System.Drawing.Size(185, 23);
            this.adatokKimenteseBtn.TabIndex = 3;
            this.adatokKimenteseBtn.Text = "Adatok kimentése";
            this.adatokKimenteseBtn.UseVisualStyleBackColor = true;
            this.adatokKimenteseBtn.Click += new System.EventHandler(this.adatokKimenteseBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adatokKimenteseBtn);
            this.Controls.Add(this.szallasTorlesBtn);
            this.Controls.Add(this.szallasFelvitelBtn);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBox1;
        private Button szallasFelvitelBtn;
        private Button szallasTorlesBtn;
        private Button adatokKimenteseBtn;
    }
}