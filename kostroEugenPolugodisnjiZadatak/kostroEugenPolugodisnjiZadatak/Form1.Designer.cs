namespace kostroEugenPolugodisnjiZadatak
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
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblPodatak3 = new System.Windows.Forms.Label();
            this.lblPodatak4 = new System.Windows.Forms.Label();
            this.cmbxRazred = new System.Windows.Forms.ComboBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnObradi = new System.Windows.Forms.Button();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtbxIme = new System.Windows.Forms.TextBox();
            this.txtbxPrezime = new System.Windows.Forms.TextBox();
            this.txtbxGodina = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(12, 53);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(31, 17);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "IME";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(9, 111);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(68, 17);
            this.lblPrezime.TabIndex = 1;
            this.lblPrezime.Text = "PREZIME";
            // 
            // lblPodatak3
            // 
            this.lblPodatak3.AutoSize = true;
            this.lblPodatak3.Location = new System.Drawing.Point(12, 176);
            this.lblPodatak3.Name = "lblPodatak3";
            this.lblPodatak3.Size = new System.Drawing.Size(132, 17);
            this.lblPodatak3.TabIndex = 2;
            this.lblPodatak3.Text = "GODINA ROĐENJA";
            // 
            // lblPodatak4
            // 
            this.lblPodatak4.AutoSize = true;
            this.lblPodatak4.Location = new System.Drawing.Point(12, 240);
            this.lblPodatak4.Name = "lblPodatak4";
            this.lblPodatak4.Size = new System.Drawing.Size(65, 17);
            this.lblPodatak4.TabIndex = 3;
            this.lblPodatak4.Text = "RAZRED";
            // 
            // cmbxRazred
            // 
            this.cmbxRazred.BackColor = System.Drawing.Color.Yellow;
            this.cmbxRazred.FormattingEnabled = true;
            this.cmbxRazred.Items.AddRange(new object[] {
            "1.a",
            "1.b",
            "1.c",
            "1.d",
            "2.a",
            "2.b",
            "2.c",
            "2.d",
            "3.a",
            "3.b",
            "3.c",
            "3.d",
            "4.a",
            "4.b",
            "4.c",
            "4.d"});
            this.cmbxRazred.Location = new System.Drawing.Point(12, 260);
            this.cmbxRazred.Name = "cmbxRazred";
            this.cmbxRazred.Size = new System.Drawing.Size(155, 24);
            this.cmbxRazred.TabIndex = 7;
            // 
            // btnUnesi
            // 
            this.btnUnesi.BackColor = System.Drawing.Color.Black;
            this.btnUnesi.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.btnUnesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnesi.ForeColor = System.Drawing.Color.Yellow;
            this.btnUnesi.Location = new System.Drawing.Point(189, 53);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(190, 236);
            this.btnUnesi.TabIndex = 8;
            this.btnUnesi.Text = "UNESI";
            this.btnUnesi.UseVisualStyleBackColor = false;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnObradi
            // 
            this.btnObradi.BackColor = System.Drawing.Color.Black;
            this.btnObradi.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.btnObradi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObradi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObradi.ForeColor = System.Drawing.Color.Yellow;
            this.btnObradi.Location = new System.Drawing.Point(408, 53);
            this.btnObradi.Name = "btnObradi";
            this.btnObradi.Size = new System.Drawing.Size(190, 236);
            this.btnObradi.TabIndex = 9;
            this.btnObradi.Text = "OBRADI";
            this.btnObradi.UseVisualStyleBackColor = false;
            this.btnObradi.Click += new System.EventHandler(this.btnObradi_Click);
            // 
            // btnIspisi
            // 
            this.btnIspisi.BackColor = System.Drawing.Color.Black;
            this.btnIspisi.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.btnIspisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIspisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIspisi.ForeColor = System.Drawing.Color.Yellow;
            this.btnIspisi.Location = new System.Drawing.Point(629, 53);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(190, 236);
            this.btnIspisi.TabIndex = 10;
            this.btnIspisi.Text = "ISPIŠI";
            this.btnIspisi.UseVisualStyleBackColor = false;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Yellow;
            this.richTextBox1.Location = new System.Drawing.Point(15, 303);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(804, 270);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // txtbxIme
            // 
            this.txtbxIme.BackColor = System.Drawing.Color.Yellow;
            this.txtbxIme.Location = new System.Drawing.Point(12, 73);
            this.txtbxIme.Name = "txtbxIme";
            this.txtbxIme.Size = new System.Drawing.Size(155, 22);
            this.txtbxIme.TabIndex = 12;
            // 
            // txtbxPrezime
            // 
            this.txtbxPrezime.BackColor = System.Drawing.Color.Yellow;
            this.txtbxPrezime.Location = new System.Drawing.Point(12, 131);
            this.txtbxPrezime.Name = "txtbxPrezime";
            this.txtbxPrezime.Size = new System.Drawing.Size(155, 22);
            this.txtbxPrezime.TabIndex = 13;
            // 
            // txtbxGodina
            // 
            this.txtbxGodina.BackColor = System.Drawing.Color.Yellow;
            this.txtbxGodina.Location = new System.Drawing.Point(12, 196);
            this.txtbxGodina.Name = "txtbxGodina";
            this.txtbxGodina.Size = new System.Drawing.Size(155, 22);
            this.txtbxGodina.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(862, 585);
            this.Controls.Add(this.txtbxGodina);
            this.Controls.Add(this.txtbxPrezime);
            this.Controls.Add(this.txtbxIme);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.btnObradi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.cmbxRazred);
            this.Controls.Add(this.lblPodatak4);
            this.Controls.Add(this.lblPodatak3);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblPodatak3;
        private System.Windows.Forms.Label lblPodatak4;
        private System.Windows.Forms.ComboBox cmbxRazred;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnObradi;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtbxIme;
        private System.Windows.Forms.TextBox txtbxPrezime;
        private System.Windows.Forms.TextBox txtbxGodina;
    }
}

