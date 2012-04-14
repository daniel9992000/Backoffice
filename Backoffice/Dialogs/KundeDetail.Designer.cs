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
            this.gb4 = new System.Windows.Forms.GroupBox();
            this.lv_angebote = new System.Windows.Forms.ListView();
            this.angebotid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb5 = new System.Windows.Forms.GroupBox();
            this.lv_rechnungen = new System.Windows.Forms.ListView();
            this.rechnungid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bezeichnung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datum1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorControl9 = new Backoffice.DataBinding.ErrorControl();
            this.errorControl8 = new Backoffice.DataBinding.ErrorControl();
            this.errorControl7 = new Backoffice.DataBinding.ErrorControl();
            this.errorControl6 = new Backoffice.DataBinding.ErrorControl();
            this.errorControl5 = new Backoffice.DataBinding.ErrorControl();
            this.errorControl4 = new Backoffice.DataBinding.ErrorControl();
            this.errorControl3 = new Backoffice.DataBinding.ErrorControl();
            this.errorControl2 = new Backoffice.DataBinding.ErrorControl();
            this.errorControl1 = new Backoffice.DataBinding.ErrorControl();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.gb3.SuspendLayout();
            this.gb4.SuspendLayout();
            this.gb5.SuspendLayout();
            this.SuspendLayout();
            // 
            // bn_save
            // 
            this.bn_save.Location = new System.Drawing.Point(12, 599);
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
            this.bn_cancel.Location = new System.Drawing.Point(93, 599);
            this.bn_cancel.Name = "bn_cancel";
            this.bn_cancel.Size = new System.Drawing.Size(75, 23);
            this.bn_cancel.TabIndex = 1;
            this.bn_cancel.Text = "Abbrechen";
            this.bn_cancel.UseVisualStyleBackColor = true;
            this.bn_cancel.Click += new System.EventHandler(this.bn_cancel_Click);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.errorControl2);
            this.gb1.Controls.Add(this.errorControl1);
            this.gb1.Controls.Add(this.tb_id);
            this.gb1.Controls.Add(this.tb_nachname);
            this.gb1.Controls.Add(this.tb_vorname);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Location = new System.Drawing.Point(12, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(443, 122);
            this.gb1.TabIndex = 5;
            this.gb1.TabStop = false;
            this.gb1.Text = "Allgemein";
            // 
            // tb_id
            // 
            this.tb_id.AccessibleName = "";
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
            this.gb2.Controls.Add(this.errorControl8);
            this.gb2.Controls.Add(this.errorControl7);
            this.gb2.Controls.Add(this.errorControl6);
            this.gb2.Controls.Add(this.errorControl5);
            this.gb2.Controls.Add(this.errorControl4);
            this.gb2.Controls.Add(this.errorControl3);
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
            this.gb2.Size = new System.Drawing.Size(443, 206);
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
            this.gb3.Controls.Add(this.errorControl9);
            this.gb3.Controls.Add(this.rtb_bemerkungen);
            this.gb3.Location = new System.Drawing.Point(12, 352);
            this.gb3.Name = "gb3";
            this.gb3.Size = new System.Drawing.Size(443, 236);
            this.gb3.TabIndex = 7;
            this.gb3.TabStop = false;
            this.gb3.Text = "Bemerkungen";
            // 
            // rtb_bemerkungen
            // 
            this.rtb_bemerkungen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_bemerkungen.Location = new System.Drawing.Point(3, 16);
            this.rtb_bemerkungen.Name = "rtb_bemerkungen";
            this.rtb_bemerkungen.Size = new System.Drawing.Size(437, 217);
            this.rtb_bemerkungen.TabIndex = 0;
            this.rtb_bemerkungen.Text = "";
            // 
            // gb4
            // 
            this.gb4.Controls.Add(this.lv_angebote);
            this.gb4.Location = new System.Drawing.Point(461, 12);
            this.gb4.Name = "gb4";
            this.gb4.Padding = new System.Windows.Forms.Padding(5);
            this.gb4.Size = new System.Drawing.Size(400, 314);
            this.gb4.TabIndex = 8;
            this.gb4.TabStop = false;
            this.gb4.Text = "Angebote";
            // 
            // lv_angebote
            // 
            this.lv_angebote.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.angebotid,
            this.titel,
            this.datum});
            this.lv_angebote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_angebote.FullRowSelect = true;
            this.lv_angebote.GridLines = true;
            this.lv_angebote.Location = new System.Drawing.Point(5, 18);
            this.lv_angebote.Name = "lv_angebote";
            this.lv_angebote.Size = new System.Drawing.Size(390, 291);
            this.lv_angebote.TabIndex = 0;
            this.lv_angebote.UseCompatibleStateImageBehavior = false;
            this.lv_angebote.View = System.Windows.Forms.View.Details;
            this.lv_angebote.DoubleClick += new System.EventHandler(this.lv_angebote_DoubleClick);
            // 
            // angebotid
            // 
            this.angebotid.Text = "ID";
            this.angebotid.Width = 30;
            // 
            // titel
            // 
            this.titel.Text = "Titel";
            this.titel.Width = 120;
            // 
            // datum
            // 
            this.datum.Text = "Datum";
            this.datum.Width = 80;
            // 
            // gb5
            // 
            this.gb5.Controls.Add(this.lv_rechnungen);
            this.gb5.Location = new System.Drawing.Point(466, 332);
            this.gb5.Name = "gb5";
            this.gb5.Padding = new System.Windows.Forms.Padding(5);
            this.gb5.Size = new System.Drawing.Size(395, 253);
            this.gb5.TabIndex = 9;
            this.gb5.TabStop = false;
            this.gb5.Text = "Rechnungen";
            // 
            // lv_rechnungen
            // 
            this.lv_rechnungen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rechnungid,
            this.bezeichnung,
            this.datum1});
            this.lv_rechnungen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_rechnungen.FullRowSelect = true;
            this.lv_rechnungen.GridLines = true;
            this.lv_rechnungen.Location = new System.Drawing.Point(5, 18);
            this.lv_rechnungen.Name = "lv_rechnungen";
            this.lv_rechnungen.Size = new System.Drawing.Size(385, 230);
            this.lv_rechnungen.TabIndex = 0;
            this.lv_rechnungen.UseCompatibleStateImageBehavior = false;
            this.lv_rechnungen.View = System.Windows.Forms.View.Details;
            // 
            // rechnungid
            // 
            this.rechnungid.Text = "ID";
            this.rechnungid.Width = 30;
            // 
            // bezeichnung
            // 
            this.bezeichnung.Text = "Bezeichnung";
            this.bezeichnung.Width = 120;
            // 
            // datum1
            // 
            this.datum1.Text = "Datum";
            this.datum1.Width = 80;
            // 
            // errorControl9
            // 
            this.errorControl9.AutoSize = true;
            this.errorControl9.Location = new System.Drawing.Point(138, 0);
            this.errorControl9.Name = "errorControl9";
            this.errorControl9.Size = new System.Drawing.Size(67, 13);
            this.errorControl9.TabIndex = 24;
            this.errorControl9.Text = "errorControl9";
            // 
            // errorControl8
            // 
            this.errorControl8.AutoSize = true;
            this.errorControl8.Location = new System.Drawing.Point(280, 152);
            this.errorControl8.Name = "errorControl8";
            this.errorControl8.Size = new System.Drawing.Size(0, 13);
            this.errorControl8.TabIndex = 23;
            // 
            // errorControl7
            // 
            this.errorControl7.AutoSize = true;
            this.errorControl7.Location = new System.Drawing.Point(280, 126);
            this.errorControl7.Name = "errorControl7";
            this.errorControl7.Size = new System.Drawing.Size(0, 13);
            this.errorControl7.TabIndex = 22;
            // 
            // errorControl6
            // 
            this.errorControl6.AutoSize = true;
            this.errorControl6.Location = new System.Drawing.Point(186, 100);
            this.errorControl6.Name = "errorControl6";
            this.errorControl6.Size = new System.Drawing.Size(0, 13);
            this.errorControl6.TabIndex = 21;
            // 
            // errorControl5
            // 
            this.errorControl5.AutoSize = true;
            this.errorControl5.Location = new System.Drawing.Point(186, 74);
            this.errorControl5.Name = "errorControl5";
            this.errorControl5.Size = new System.Drawing.Size(0, 13);
            this.errorControl5.TabIndex = 20;
            // 
            // errorControl4
            // 
            this.errorControl4.AutoSize = true;
            this.errorControl4.Location = new System.Drawing.Point(280, 48);
            this.errorControl4.Name = "errorControl4";
            this.errorControl4.Size = new System.Drawing.Size(0, 13);
            this.errorControl4.TabIndex = 19;
            // 
            // errorControl3
            // 
            this.errorControl3.AutoSize = true;
            this.errorControl3.Location = new System.Drawing.Point(280, 22);
            this.errorControl3.Name = "errorControl3";
            this.errorControl3.Size = new System.Drawing.Size(0, 13);
            this.errorControl3.TabIndex = 18;
            // 
            // errorControl2
            // 
            this.errorControl2.AutoSize = true;
            this.errorControl2.Location = new System.Drawing.Point(211, 89);
            this.errorControl2.Name = "errorControl2";
            this.errorControl2.Size = new System.Drawing.Size(0, 13);
            this.errorControl2.TabIndex = 7;
            // 
            // errorControl1
            // 
            this.errorControl1.AutoSize = true;
            this.errorControl1.Location = new System.Drawing.Point(211, 63);
            this.errorControl1.Name = "errorControl1";
            this.errorControl1.Size = new System.Drawing.Size(0, 13);
            this.errorControl1.TabIndex = 6;
            // 
            // KundeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 634);
            this.Controls.Add(this.gb5);
            this.Controls.Add(this.gb4);
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
            this.gb3.PerformLayout();
            this.gb4.ResumeLayout(false);
            this.gb5.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gb4;
        private System.Windows.Forms.ListView lv_angebote;
        private System.Windows.Forms.ColumnHeader angebotid;
        private System.Windows.Forms.ColumnHeader titel;
        private System.Windows.Forms.ColumnHeader datum;
        private System.Windows.Forms.GroupBox gb5;
        private System.Windows.Forms.ListView lv_rechnungen;
        private System.Windows.Forms.ColumnHeader rechnungid;
        private System.Windows.Forms.ColumnHeader bezeichnung;
        private System.Windows.Forms.ColumnHeader datum1;
        private DataBinding.ErrorControl errorControl2;
        private DataBinding.ErrorControl errorControl1;
        private DataBinding.ErrorControl errorControl8;
        private DataBinding.ErrorControl errorControl7;
        private DataBinding.ErrorControl errorControl6;
        private DataBinding.ErrorControl errorControl5;
        private DataBinding.ErrorControl errorControl4;
        private DataBinding.ErrorControl errorControl3;
        private DataBinding.ErrorControl errorControl9;
    }
}