namespace SzkolaJezykowaIO
{
    partial class UsunProwadzacego
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Wybierz prowadzącego";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Usuń";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UsunProwadzacego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "UsunProwadzacego";
            this.Text = "UsunProwadzacego";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}