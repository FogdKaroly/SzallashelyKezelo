namespace SzallashelyKezelo
{
    partial class SzallodaUctrl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wellnessChbx = new System.Windows.Forms.CheckBox();
            this.szobaAraNud = new System.Windows.Forms.NumericUpDown();
            this.csillagokSzamaNud = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.szobaAraNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csillagokSzamaNud)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szoba ára:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Csillagok száma";
            // 
            // wellnessChbx
            // 
            this.wellnessChbx.AutoSize = true;
            this.wellnessChbx.Location = new System.Drawing.Point(24, 146);
            this.wellnessChbx.Name = "wellnessChbx";
            this.wellnessChbx.Size = new System.Drawing.Size(99, 19);
            this.wellnessChbx.TabIndex = 2;
            this.wellnessChbx.Text = "Wellness van?";
            this.wellnessChbx.UseVisualStyleBackColor = true;
            // 
            // szobaAraNud
            // 
            this.szobaAraNud.Location = new System.Drawing.Point(134, 23);
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
            this.szobaAraNud.TabIndex = 3;
            this.szobaAraNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // csillagokSzamaNud
            // 
            this.csillagokSzamaNud.Location = new System.Drawing.Point(134, 84);
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
            this.csillagokSzamaNud.TabIndex = 4;
            this.csillagokSzamaNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SzallodaUctrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.csillagokSzamaNud);
            this.Controls.Add(this.szobaAraNud);
            this.Controls.Add(this.wellnessChbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SzallodaUctrl";
            this.Size = new System.Drawing.Size(349, 194);
            ((System.ComponentModel.ISupportInitialize)(this.szobaAraNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csillagokSzamaNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox wellnessChbx;
        private NumericUpDown szobaAraNud;
        private NumericUpDown csillagokSzamaNud;
    }
}
