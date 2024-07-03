namespace lab_5
{
    partial class Form1
    {
        public bool block;

        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        //public bool block;
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
            this.label_AX = new System.Windows.Forms.Label();
            this.label_BX = new System.Windows.Forms.Label();
            this.label_CX = new System.Windows.Forms.Label();
            this.label_DX = new System.Windows.Forms.Label();
            this.code_textbox = new System.Windows.Forms.RichTextBox();
            this.execute_button = new System.Windows.Forms.Button();
            this.step_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.step_number_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.b_opis = new System.Windows.Forms.Button();
            this.terminal = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label_AX
            // 
            this.label_AX.AutoSize = true;
            this.label_AX.Location = new System.Drawing.Point(1276, 60);
            this.label_AX.Name = "label_AX";
            this.label_AX.Size = new System.Drawing.Size(51, 20);
            this.label_AX.TabIndex = 0;
            this.label_AX.Text = "label1";
            // 
            // label_BX
            // 
            this.label_BX.AutoSize = true;
            this.label_BX.Location = new System.Drawing.Point(1276, 120);
            this.label_BX.Name = "label_BX";
            this.label_BX.Size = new System.Drawing.Size(51, 20);
            this.label_BX.TabIndex = 1;
            this.label_BX.Text = "label1";
            // 
            // label_CX
            // 
            this.label_CX.AutoSize = true;
            this.label_CX.Location = new System.Drawing.Point(1276, 180);
            this.label_CX.Name = "label_CX";
            this.label_CX.Size = new System.Drawing.Size(51, 20);
            this.label_CX.TabIndex = 2;
            this.label_CX.Text = "label1";
            // 
            // label_DX
            // 
            this.label_DX.AutoSize = true;
            this.label_DX.Location = new System.Drawing.Point(1276, 240);
            this.label_DX.Name = "label_DX";
            this.label_DX.Size = new System.Drawing.Size(51, 20);
            this.label_DX.TabIndex = 3;
            this.label_DX.Text = "label1";
            // 
            // code_textbox
            // 
            this.code_textbox.Location = new System.Drawing.Point(87, 60);
            this.code_textbox.Name = "code_textbox";
            this.code_textbox.Size = new System.Drawing.Size(584, 610);
            this.code_textbox.TabIndex = 4;
            this.code_textbox.Text = "";
            this.code_textbox.TextChanged += new System.EventHandler(this.code_textbox_TextChanged);
            // 
            // execute_button
            // 
            this.execute_button.Location = new System.Drawing.Point(849, 60);
            this.execute_button.Name = "execute_button";
            this.execute_button.Size = new System.Drawing.Size(86, 40);
            this.execute_button.TabIndex = 5;
            this.execute_button.Text = "execute";
            this.execute_button.UseVisualStyleBackColor = true;
            this.execute_button.Click += new System.EventHandler(this.execute_button_Click);
            // 
            // step_button
            // 
            this.step_button.Location = new System.Drawing.Point(849, 148);
            this.step_button.Name = "step_button";
            this.step_button.Size = new System.Drawing.Size(86, 40);
            this.step_button.TabIndex = 6;
            this.step_button.Text = "step";
            this.step_button.UseVisualStyleBackColor = true;
            this.step_button.Click += new System.EventHandler(this.step_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(849, 308);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(86, 40);
            this.save_button.TabIndex = 7;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(849, 385);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(86, 40);
            this.load_button.TabIndex = 8;
            this.load_button.Text = "Load";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1200, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "AX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1200, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "BX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1200, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "CX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1200, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "DX";
            // 
            // step_number_label
            // 
            this.step_number_label.AutoSize = true;
            this.step_number_label.Location = new System.Drawing.Point(986, 157);
            this.step_number_label.Name = "step_number_label";
            this.step_number_label.Size = new System.Drawing.Size(0, 20);
            this.step_number_label.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 63);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(27, 600);
            this.label5.TabIndex = 15;
            this.label5.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n9\r\n10\r\n11\r\n12\r\n13\r\n14\r\n15\r\n16\r\n17\r\n18\r\n19\r\n20\r\n21\r\n22\r\n23" +
    "\r\n24\r\n25\r\n26\r\n27\r\n28\r\n29\r\n30";
            // 
            // b_opis
            // 
            this.b_opis.Location = new System.Drawing.Point(1204, 389);
            this.b_opis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_opis.Name = "b_opis";
            this.b_opis.Size = new System.Drawing.Size(112, 35);
            this.b_opis.TabIndex = 16;
            this.b_opis.Text = "Help";
            this.b_opis.UseVisualStyleBackColor = true;
            this.b_opis.Click += new System.EventHandler(this.b_opis_Click);
            // 
            // terminal
            // 
            this.terminal.Location = new System.Drawing.Point(849, 512);
            this.terminal.Name = "terminal";
            this.terminal.Size = new System.Drawing.Size(478, 172);
            this.terminal.TabIndex = 17;
            this.terminal.Text = "";
            this.terminal.TextChanged += new System.EventHandler(this.terminal_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 772);
            this.Controls.Add(this.terminal);
            this.Controls.Add(this.b_opis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.step_number_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.step_button);
            this.Controls.Add(this.execute_button);
            this.Controls.Add(this.code_textbox);
            this.Controls.Add(this.label_DX);
            this.Controls.Add(this.label_CX);
            this.Controls.Add(this.label_BX);
            this.Controls.Add(this.label_AX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_AX;
        private System.Windows.Forms.Label label_BX;
        private System.Windows.Forms.Label label_CX;
        private System.Windows.Forms.Label label_DX;
        private System.Windows.Forms.RichTextBox code_textbox;
        private System.Windows.Forms.Button execute_button;
        private System.Windows.Forms.Button step_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label step_number_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button b_opis;
        private System.Windows.Forms.RichTextBox terminal;
    }
}

