namespace SzallashelyKezelo
{
    partial class CampingUctrl
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
            this.vizpartiChbx = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // vizpartiChbx
            // 
            this.vizpartiChbx.AutoSize = true;
            this.vizpartiChbx.Location = new System.Drawing.Point(59, 73);
            this.vizpartiChbx.Name = "vizpartiChbx";
            this.vizpartiChbx.Size = new System.Drawing.Size(81, 19);
            this.vizpartiChbx.TabIndex = 0;
            this.vizpartiChbx.Text = "Vízparti-e?";
            this.vizpartiChbx.UseVisualStyleBackColor = true;
            // 
            // CampingUctrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vizpartiChbx);
            this.Name = "CampingUctrl";
            this.Size = new System.Drawing.Size(349, 194);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox vizpartiChbx;
    }
}
