namespace Backoffice.Dialogs
{
    partial class KundeDetail
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
            this.bn_save = new System.Windows.Forms.Button();
            this.bn_cancel = new System.Windows.Forms.Button();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_nachname = new System.Windows.Forms.TextBox();
            this.tb_vorname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_telefon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ort = new System.Windows.Forms.TextBox();
            this.tb_plz = new System.Windows.Forms.TextBox();
            this.tb_hausnr = new System.Windows.Forms.TextBox();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.gb3 = new System.Windows.Forms.GroupBox();
            this.rtb_bemerkungen = new System.Windows.Forms.RichTextBox();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.gb3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bn_save
            // 
            this.bn_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bn_save.Location = new System.Drawing.Point(542, 329);
            this.bn_save.Name = "bn_save";
            this.bn_save.Size = new System.Drawing.Size(75, 23);
            this.bn_save.TabIndex = 0;
            this.bn_save.Text = "Speichern";
            this.bn_save.UseVisualStyleBackColor = true;
            this.bn_save.Click += new System.EventHandler(this.bn_save_Click);
            // 
            // bn_cancel
            // 
            this.bn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bn_cancel.Location = new System.Drawing.Point(623, 329);
            this.bn_cancel.Name = "bn_cancel";
            this.bn_cancel.Size = new System.Drawing.Size(75, 23);
            this.bn_cancel.TabIndex = 1;
            this.bn_cancel.Text = "Abbrechen";
            this.bn_cancel.UseVisualStyleBackColor = true;
            this.bn_cancel.Click += new System.EventHandler(this.bn_cancel_Click);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.tb_id);
            this.gb1.Controls.Add(this.tb_nachname);
            this.gb1.Controls.Add(this.tb_vorname);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Location = new System.Drawing.Point(12, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(348, 122);
            this.gb1.TabIndex = 5;
            this.gb1.TabStop = false;
            this.gb1.Text = "Allgemein";
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(105, 34);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(32, 20);
            this.tb_id.TabIndex = 5;
            // 
            // tb_nachname
            // 
            this.tb_nachname.Location = new System.Drawing.Point(105, 86);
            this.tb_nachname.Name = "tb_nachname";
            this.tb_nachname.Size = new System.Drawing.Size(100, 20);
            this.tb_nachname.TabIndex = 4;
            // 
            // tb_vorname
            // 
            this.tb_vorname.Location = new System.Drawing.Point(105, 60);
            this.tb_vorname.Name = "tb_vorname";
            this.tb_vorname.Size = new System.Drawing.Size(100, 20);
            this.tb_vorname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nachname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vorname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(105, 19);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(169, 20);
            this.tb_email.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.label9);
            this.gb2.Controls.Add(this.tb_telefon);
            this.gb2.Controls.Add(this.label8);
            this.gb2.Controls.Add(this.label7);
            this.gb2.Controls.Add(this.label6);
            this.gb2.Controls.Add(this.label5);
            this.gb2.Controls.Add(this.tb_ort);
            this.gb2.Controls.Add(this.tb_plz);
            this.gb2.Controls.Add(this.tb_hausnr);
            this.gb2.Controls.Add(this.tb_adresse);
            this.gb2.Controls.Add(this.label4);
            this.gb2.Controls.Add(this.tb_email);
            this.gb2.Location = new System.Drawing.Point(12, 140);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(348, 183);
            this.gb2.TabIndex = 6;
            this.gb2.TabStop = false;
            this.gb2.Text = "Kontakt";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Telefon";
            // 
            // tb_telefon
            // 
            this.tb_telefon.Location = new System.Drawing.Point(105, 149);
            this.tb_telefon.Name = "tb_telefon";
            this.tb_telefon.Size = new System.Drawing.Size(169, 20);
            this.tb_telefon.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Adresse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "PLZ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ort";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hausnummer";
            // 
            // tb_ort
            // 
            this.tb_ort.Location = new System.Drawing.Point(105, 123);
            this.tb_ort.Name = "tb_ort";
            this.tb_ort.Size = new System.Drawing.Size(169, 20);
            this.tb_ort.TabIndex = 11;
            // 
            // tb_plz
            // 
            this.tb_plz.Location = new System.Drawing.Point(105, 97);
            this.tb_plz.Name = "tb_plz";
            this.tb_plz.Size = new System.Drawing.Size(75, 20);
            this.tb_plz.TabIndex = 10;
            // 
            // tb_hausnr
            // 
            this.tb_hausnr.Location = new System.Drawing.Point(105, 71);
            this.tb_hausnr.Name = "tb_hausnr";
            this.tb_hausnr.Size = new System.Drawing.Size(75, 20);
            this.tb_hausnr.TabIndex = 9;
            // 
            // tb_adresse
            // 
            this.tb_adresse.Location = new System.Drawing.Point(105, 45);
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.Size = new System.Drawing.Size(169, 20);
            this.tb_adresse.TabIndex = 8;
            // 
            // gb3
            // 
            this.gb3.Controls.Add(this.rtb_bemerkungen);
            this.gb3.Location = new System.Drawing.Point(366, 12);
            this.gb3.Name = "gb3";
            this.gb3.Size = new System.Drawing.Size(332, 311);
            this.gb3.TabIndex = 7;
            this.gb3.TabStop = false;
            this.gb3.Text = "Bemerkungen";
            // 
            // rtb_bemerkungen
            // 
            this.rtb_bemerkungen.Location = new System.Drawing.Point(6, 19);
            this.rtb_bemerkungen.Name = "rtb_bemerkungen";
            this.rtb_bemerkungen.Size = new System.Drawing.Size(320, 286);
            this.rtb_bemerkungen.TabIndex = 0;
            this.rtb_bemerkungen.Text = "";
            // 
            // KundeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 361);
            this.Controls.Add(this.gb3);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.bn_cancel);
            this.Controls.Add(this.bn_save);
            this.Name = "KundeDetail";
            this.Text = "Kundendaten";
            this.Load += new System.EventHandler(this.KundeDetail_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.gb3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bn_save;
        private System.Windows.Forms.Button bn_cancel;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_nachname;
        private System.Windows.Forms.TextBox tb_vorname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_telefon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_ort;
        private System.Windows.Forms.TextBox tb_plz;
        private System.Windows.Forms.TextBox tb_hausnr;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.GroupBox gb3;
        private System.Windows.Forms.RichTextBox rtb_bemerkungen;
    }
}