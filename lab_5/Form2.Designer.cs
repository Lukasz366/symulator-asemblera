namespace lab_5
{
    partial class Form2
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.f_desc = new System.Windows.Forms.Label();
            this.f_opis = new System.Windows.Forms.TextBox();
            this.f_name = new System.Windows.Forms.Label();
            this.b_f1 = new System.Windows.Forms.Button();
            this.b_f2 = new System.Windows.Forms.Button();
            this.b_f3 = new System.Windows.Forms.Button();
            this.b_f4 = new System.Windows.Forms.Button();
            this.b_f5 = new System.Windows.Forms.Button();
            this.b_f6 = new System.Windows.Forms.Button();
            this.b_f7 = new System.Windows.Forms.Button();
            this.b_f8 = new System.Windows.Forms.Button();
            this.b_f9 = new System.Windows.Forms.Button();
            this.b_f10 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.f_desc);
            this.panel1.Controls.Add(this.f_opis);
            this.panel1.Controls.Add(this.f_name);
            this.panel1.Location = new System.Drawing.Point(132, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 478);
            this.panel1.TabIndex = 0;
            // 
            // f_desc
            // 
            this.f_desc.AutoSize = true;
            this.f_desc.Location = new System.Drawing.Point(4, 34);
            this.f_desc.Name = "f_desc";
            this.f_desc.Size = new System.Drawing.Size(41, 13);
            this.f_desc.TabIndex = 2;
            this.f_desc.Text = "F Desc";
            this.f_desc.Click += new System.EventHandler(this.f_desc_Click);
            // 
            // f_opis
            // 
            this.f_opis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f_opis.Location = new System.Drawing.Point(7, 95);
            this.f_opis.Multiline = true;
            this.f_opis.Name = "f_opis";
            this.f_opis.ReadOnly = true;
            this.f_opis.Size = new System.Drawing.Size(236, 380);
            this.f_opis.TabIndex = 1;
            this.f_opis.TextChanged += new System.EventHandler(this.f_opis_TextChanged);
            // 
            // f_name
            // 
            this.f_name.AutoSize = true;
            this.f_name.Location = new System.Drawing.Point(4, 4);
            this.f_name.Name = "f_name";
            this.f_name.Size = new System.Drawing.Size(44, 13);
            this.f_name.TabIndex = 0;
            this.f_name.Text = "F Name";
            this.f_name.Click += new System.EventHandler(this.f_name_Click);
            // 
            // b_f1
            // 
            this.b_f1.Location = new System.Drawing.Point(3, 4);
            this.b_f1.Name = "b_f1";
            this.b_f1.Size = new System.Drawing.Size(75, 23);
            this.b_f1.TabIndex = 1;
            this.b_f1.Text = "INT 17, 0";
            this.b_f1.UseVisualStyleBackColor = true;
            this.b_f1.Click += new System.EventHandler(this.b_f1_Click);
            // 
            // b_f2
            // 
            this.b_f2.Location = new System.Drawing.Point(3, 34);
            this.b_f2.Name = "b_f2";
            this.b_f2.Size = new System.Drawing.Size(75, 23);
            this.b_f2.TabIndex = 2;
            this.b_f2.Text = "INT 33,3";
            this.b_f2.UseVisualStyleBackColor = true;
            this.b_f2.Click += new System.EventHandler(this.b_f2_Click);
            // 
            // b_f3
            // 
            this.b_f3.Location = new System.Drawing.Point(3, 63);
            this.b_f3.Name = "b_f3";
            this.b_f3.Size = new System.Drawing.Size(75, 23);
            this.b_f3.TabIndex = 3;
            this.b_f3.Text = "INT 21, 9";
            this.b_f3.UseVisualStyleBackColor = true;
            this.b_f3.Click += new System.EventHandler(this.b_f3_Click);
            // 
            // b_f4
            // 
            this.b_f4.Location = new System.Drawing.Point(3, 92);
            this.b_f4.Name = "b_f4";
            this.b_f4.Size = new System.Drawing.Size(75, 23);
            this.b_f4.TabIndex = 4;
            this.b_f4.Text = "INT 21, 2A";
            this.b_f4.UseVisualStyleBackColor = true;
            this.b_f4.Click += new System.EventHandler(this.b_f4_Click);
            // 
            // b_f5
            // 
            this.b_f5.Location = new System.Drawing.Point(3, 121);
            this.b_f5.Name = "b_f5";
            this.b_f5.Size = new System.Drawing.Size(75, 23);
            this.b_f5.TabIndex = 5;
            this.b_f5.Text = "INT 13,10";
            this.b_f5.UseVisualStyleBackColor = true;
            this.b_f5.Click += new System.EventHandler(this.b_f5_Click);
            // 
            // b_f6
            // 
            this.b_f6.Location = new System.Drawing.Point(3, 150);
            this.b_f6.Name = "b_f6";
            this.b_f6.Size = new System.Drawing.Size(75, 23);
            this.b_f6.TabIndex = 6;
            this.b_f6.Text = "INT 16,0";
            this.b_f6.UseVisualStyleBackColor = true;
            this.b_f6.Click += new System.EventHandler(this.b_f6_Click);
            // 
            // b_f7
            // 
            this.b_f7.Location = new System.Drawing.Point(3, 179);
            this.b_f7.Name = "b_f7";
            this.b_f7.Size = new System.Drawing.Size(75, 23);
            this.b_f7.TabIndex = 7;
            this.b_f7.Text = "INT 10,11";
            this.b_f7.UseVisualStyleBackColor = true;
            this.b_f7.Click += new System.EventHandler(this.b_f7_Click);
            // 
            // b_f8
            // 
            this.b_f8.Location = new System.Drawing.Point(3, 208);
            this.b_f8.Name = "b_f8";
            this.b_f8.Size = new System.Drawing.Size(75, 23);
            this.b_f8.TabIndex = 8;
            this.b_f8.Text = "INT 1A, 1";
            this.b_f8.UseVisualStyleBackColor = true;
            this.b_f8.Click += new System.EventHandler(this.b_f8_Click);
            // 
            // b_f9
            // 
            this.b_f9.Location = new System.Drawing.Point(3, 237);
            this.b_f9.Name = "b_f9";
            this.b_f9.Size = new System.Drawing.Size(75, 23);
            this.b_f9.TabIndex = 9;
            this.b_f9.Text = "INT 1A, 2";
            this.b_f9.UseVisualStyleBackColor = true;
            this.b_f9.Click += new System.EventHandler(this.b_f9_Click);
            // 
            // b_f10
            // 
            this.b_f10.Location = new System.Drawing.Point(3, 266);
            this.b_f10.Name = "b_f10";
            this.b_f10.Size = new System.Drawing.Size(75, 23);
            this.b_f10.TabIndex = 10;
            this.b_f10.Text = "F10";
            this.b_f10.UseVisualStyleBackColor = true;
            this.b_f10.Click += new System.EventHandler(this.b_f10_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.b_f1);
            this.panel2.Controls.Add(this.b_f10);
            this.panel2.Controls.Add(this.b_f2);
            this.panel2.Controls.Add(this.b_f9);
            this.panel2.Controls.Add(this.b_f3);
            this.panel2.Controls.Add(this.b_f8);
            this.panel2.Controls.Add(this.b_f4);
            this.panel2.Controls.Add(this.b_f7);
            this.panel2.Controls.Add(this.b_f5);
            this.panel2.Controls.Add(this.b_f6);
            this.panel2.Location = new System.Drawing.Point(12, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 296);
            this.panel2.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 502);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Opisy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox f_opis;
        private System.Windows.Forms.Label f_name;
        private System.Windows.Forms.Button b_f1;
        private System.Windows.Forms.Button b_f2;
        private System.Windows.Forms.Button b_f3;
        private System.Windows.Forms.Button b_f4;
        private System.Windows.Forms.Button b_f5;
        private System.Windows.Forms.Button b_f6;
        private System.Windows.Forms.Button b_f7;
        private System.Windows.Forms.Button b_f8;
        private System.Windows.Forms.Button b_f9;
        private System.Windows.Forms.Button b_f10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label f_desc;
    }
}

