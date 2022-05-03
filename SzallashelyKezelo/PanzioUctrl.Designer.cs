namespace SzallashelyKezelo
{
    partial class PanzioUctrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.csillagokSzamaNud = new System.Windows.Forms.NumericUpDown();
            this.szobaAraNud = new System.Windows.Forms.NumericUpDown();
            this.reggeliChbx = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.csillagokSzamaNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szobaAraNud)).BeginInit();
            this.SuspendLayout();
            // 
            // csillagokSzamaNud
            // 
            this.csillagokSzamaNud.Location = new System.Drawing.Point(135, 87);
            this.csillagokSzamaNud.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.csillagokSzamaNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.csillagokSzamaNud.Name = "csillagokSzamaNud";
            this.csillagokSzamaNud.Size = new System.Drawing.Size(177, 23);
            this.csillagokSzamaNud.TabIndex = 9;
            this.csillagokSzamaNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // szobaAraNud
            // 
            this.szobaAraNud.Location = new System.Drawing.Point(135, 26);
            this.szobaAraNud.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.szobaAraNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.szobaAraNud.Name = "szobaAraNud";
            this.szobaAraNud.Size = new System.Drawing.Size(177, 23);
            this.szobaAraNud.TabIndex = 8;
            this.szobaAraNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // reggeliChbx
            // 
            this.reggeliChbx.AutoSize = true;
            this.reggeliChbx.Location = new System.Drawing.Point(25, 149);
            this.reggeliChbx.Name = "reggeliChbx";
            this.reggeliChbx.Size = new System.Drawing.Size(92, 19);
            this.reggeliChbx.TabIndex = 7;
            this.reggeliChbx.Text = "Reggeli van?";
            this.reggeliChbx.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Csillagok száma";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Szoba ára:";
            // 
            // PanzioUctrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.csillagokSzamaNud);
            this.Controls.Add(this.szobaAraNud);
            this.Controls.Add(this.reggeliChbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PanzioUctrl";
            this.Size = new System.Drawing.Size(349, 194);
            ((System.ComponentModel.ISupportInitialize)(this.csillagokSzamaNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szobaAraNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown csillagokSzamaNud;
        private NumericUpDown szobaAraNud;
        private CheckBox reggeliChbx;
        private Label label2;
        private Label label1;
    }
}
