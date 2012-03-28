namespace Backoffice.Dialogs
{
    partial class KontaktDetail
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
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.tb_nachname = new System.Windows.Forms.TextBox();
            this.tb_vorname = new System.Windows.Forms.TextBox();
            this.tb_firmenname = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bnsave = new System.Windows.Forms.Button();
            this.bncancel = new System.Windows.Forms.Button();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_plz = new System.Windows.Forms.TextBox();
            this.tb_ort = new System.Windows.Forms.TextBox();
            this.tb_telefon = new System.Windows.Forms.TextBox();
            this.tb_hausnummer = new System.Windows.Forms.TextBox();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.gb3 = new System.Windows.Forms.GroupBox();
            this.rtb_bemerkungen = new System.Windows.Forms.RichTextBox();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.gb3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.tb_nachname);
            this.gb1.Controls.Add(this.tb_vorname);
            this.gb1.Controls.Add(this.tb_firmenname);
            this.gb1.Controls.Add(this.tb_id);
            this.gb1.Controls.Add(this.label4);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Location = new System.Drawing.Point(12, 25);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(327, 144);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "Allgmein";
            // 
            // tb_nachname
            // 
            this.tb_nachname.Location = new System.Drawing.Point(165, 101);
            this.tb_nachname.Name = "tb_nachname";
            this.tb_nachname.Size = new System.Drawing.Size(100, 20);
            this.tb_nachname.TabIndex = 7;
            // 
            // tb_vorname
            // 
            this.tb_vorname.Location = new System.Drawing.Point(165, 75);
            this.tb_vorname.Name = "tb_vorname";
            this.tb_vorname.Size = new System.Drawing.Size(100, 20);
            this.tb_vorname.TabIndex = 6;
            // 
            // tb_firmenname
            // 
            this.tb_firmenname.Location = new System.Drawing.Point(165, 49);
            this.tb_firmenname.Name = "tb_firmenname";
            this.tb_firmenname.Size = new System.Drawing.Size(100, 20);
            this.tb_firmenname.TabIndex = 5;
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(165, 20);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(39, 20);
            this.tb_id.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nachname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vorname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firmenname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bnsave
            // 
            this.bnsave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bnsave.Location = new System.Drawing.Point(508, 364);
            this.bnsave.Name = "bnsave";
            this.bnsave.Size = new System.Drawing.Size(88, 31);
            this.bnsave.TabIndex = 20;
            this.bnsave.Text = "Speichern";
            this.bnsave.UseVisualStyleBackColor = true;
            this.bnsave.Click += new System.EventHandler(this.bnsave_Click);
            // 
            // bncancel
            // 
            this.bncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bncancel.Location = new System.Drawing.Point(620, 364);
            this.bncancel.Name = "bncancel";
            this.bncancel.Size = new System.Drawing.Size(88, 31);
            this.bncancel.TabIndex = 21;
            this.bncancel.Text = "Abbrechen";
            this.bncancel.UseVisualStyleBackColor = true;
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.tb_email);
            this.gb2.Controls.Add(this.tb_adresse);
            this.gb2.Controls.Add(this.tb_hausnummer);
            this.gb2.Controls.Add(this.tb_telefon);
            this.gb2.Controls.Add(this.tb_ort);
            this.gb2.Controls.Add(this.tb_plz);
            this.gb2.Controls.Add(this.label10);
            this.gb2.Controls.Add(this.label9);
            this.gb2.Controls.Add(this.label8);
            this.gb2.Controls.Add(this.label7);
            this.gb2.Controls.Add(this.label6);
            this.gb2.Controls.Add(this.label5);
            this.gb2.Location = new System.Drawing.Point(12, 188);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(327, 235);
            this.gb2.TabIndex = 3;
            this.gb2.TabStop = false;
            this.gb2.Text = "Kontakt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ort";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "PLZ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Hausnummer";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Adresse";
            // 
            // tb_plz
            // 
            this.tb_plz.Location = new System.Drawing.Point(165, 109);
            this.tb_plz.Name = "tb_plz";
            this.tb_plz.Size = new System.Drawing.Size(100, 20);
            this.tb_plz.TabIndex = 11;
            // 
            // tb_ort
            // 
            this.tb_ort.Location = new System.Drawing.Point(165, 138);
            this.tb_ort.Name = "tb_ort";
            this.tb_ort.Size = new System.Drawing.Size(100, 20);
            this.tb_ort.TabIndex = 12;
            // 
            // tb_telefon
            // 
            this.tb_telefon.Location = new System.Drawing.Point(165, 169);
            this.tb_telefon.Name = "tb_telefon";
            this.tb_telefon.Size = new System.Drawing.Size(100, 20);
            this.tb_telefon.TabIndex = 13;
            // 
            // tb_hausnummer
            // 
            this.tb_hausnummer.Location = new System.Drawing.Point(165, 83);
            this.tb_hausnummer.Name = "tb_hausnummer";
            this.tb_hausnummer.Size = new System.Drawing.Size(100, 20);
            this.tb_hausnummer.TabIndex = 10;
            // 
            // tb_adresse
            // 
            this.tb_adresse.Location = new System.Drawing.Point(165, 54);
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.Size = new System.Drawing.Size(100, 20);
            this.tb_adresse.TabIndex = 9;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(165, 25);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(100, 20);
            this.tb_email.TabIndex = 8;
            // 
            // gb3
            // 
            this.gb3.Controls.Add(this.rtb_bemerkungen);
            this.gb3.Location = new System.Drawing.Point(378, 25);
            this.gb3.Name = "gb3";
            this.gb3.Size = new System.Drawing.Size(385, 257);
            this.gb3.TabIndex = 4;
            this.gb3.TabStop = false;
            this.gb3.Text = "Bemerkungen";
            this.gb3.Enter += new System.EventHandler(this.gb3_Enter);
            // 
            // rtb_bemerkungen
            // 
            this.rtb_bemerkungen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_bemerkungen.Location = new System.Drawing.Point(3, 16);
            this.rtb_bemerkungen.Name = "rtb_bemerkungen";
            this.rtb_bemerkungen.Size = new System.Drawing.Size(379, 238);
            this.rtb_bemerkungen.TabIndex = 14;
            this.rtb_bemerkungen.Text = "";
            // 
            // KontaktDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 435);
            this.Controls.Add(this.gb3);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.bncancel);
            this.Controls.Add(this.bnsave);
            this.Controls.Add(this.gb1);
            this.Name = "KontaktDetail";
            this.Text = "KontaktDetail";
            this.Load += new System.EventHandler(this.KontaktDetail_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.gb3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnsave;
        private System.Windows.Forms.Button bncancel;
        private System.Windows.Forms.TextBox tb_nachname;
        private System.Windows.Forms.TextBox tb_vorname;
        private System.Windows.Forms.TextBox tb_firmenname;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.TextBox tb_hausnummer;
        private System.Windows.Forms.TextBox tb_telefon;
        private System.Windows.Forms.TextBox tb_ort;
        private System.Windows.Forms.TextBox tb_plz;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb3;
        private System.Windows.Forms.RichTextBox rtb_bemerkungen;
    }
}