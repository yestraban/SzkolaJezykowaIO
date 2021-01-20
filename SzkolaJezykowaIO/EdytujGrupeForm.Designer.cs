namespace SzkolaJezykowaIO
{
    partial class EdytujGrupeForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(82, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Wybierz grupę";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Zmień nazwę";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Zmień poziom";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(418, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Zmień język";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(594, 152);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 34);
            this.button4.TabIndex = 4;
            this.button4.Text = "Zmień prowadzącego";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(418, 84);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(243, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.Text = "Wybierz nowego prowadzącego (opcjonalne)";
            // 
            // EdytujGrupeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "EdytujGrupeForm";
            this.Text = "EdytujGrupeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}