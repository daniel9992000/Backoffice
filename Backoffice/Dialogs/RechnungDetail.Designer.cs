namespace Backoffice.Dialogs
{
    partial class RechnungDetail
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
            this.errorControl6 = new Backoffice.DataBinding.ErrorControl();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_kunden = new System.Windows.Forms.ComboBox();
            this.errorControl3 = new Backoffice.DataBinding.ErrorControl();
            this.errorControl2 = new Backoffice.DataBinding.ErrorControl();
            this.errorControl1 = new Backoffice.DataBinding.ErrorControl();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_projekt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_datum = new System.Windows.Forms.DateTimePicker();
            this.tb_bezeichnung = new System.Windows.Forms.TextBox();
            this.tb_rechnungid = new System.Windows.Forms.TextBox();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.tb_rechnungssumme = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errorControl5 = new Backoffice.DataBinding.ErrorControl();
            this.errorControl4 = new Backoffice.DataBinding.ErrorControl();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bn_add = new System.Windows.Forms.Button();
            this.tb_rz_wert = new System.Windows.Forms.TextBox();
            this.tb_rz_bezeichnung = new System.Windows.Forms.TextBox();
            this.lv_zeilen = new System.Windows.Forms.ListView();
            this.reid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bezeichnung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.betrag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bn_save = new System.Windows.Forms.Button();
            this.bn_cancel = new System.Windows.Forms.Button();
            this.gb3 = new System.Windows.Forms.GroupBox();
            this.bn_new_buchung = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_offen = new System.Windows.Forms.TextBox();
            this.lv_buchungen = new System.Windows.Forms.ListView();
            this.bn_print = new System.Windows.Forms.Button();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.gb3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.errorControl6);
            this.gb1.Controls.Add(this.label4);
            this.gb1.Controls.Add(this.cb_kunden);
            this.gb1.Controls.Add(this.errorControl3);
            this.gb1.Controls.Add(this.errorControl2);
            this.gb1.Controls.Add(this.errorControl1);
            this.gb1.Controls.Add(this.label5);
            this.gb1.Controls.Add(this.cb_projekt);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Controls.Add(this.dtp_datum);
            this.gb1.Controls.Add(this.tb_bezeichnung);
            this.gb1.Controls.Add(this.tb_rechnungid);
            this.gb1.Location = new System.Drawing.Point(12, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(542, 167);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "Allgemein";
            // 
            // errorControl6
            // 
            this.errorControl6.AutoSize = true;
            this.errorControl6.Location = new System.Drawing.Point(321, 100);
            this.errorControl6.Name = "errorControl6";
            this.errorControl6.Size = new System.Drawing.Size(0, 13);
            this.errorControl6.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Kunde";
            // 
            // cb_kunden
            // 
            this.cb_kunden.FormattingEnabled = true;
            this.cb_kunden.Location = new System.Drawing.Point(116, 97);
            this.cb_kunden.Name = "cb_kunden";
            this.cb_kunden.Size = new System.Drawing.Size(200, 21);
            this.cb_kunden.TabIndex = 14;
            this.cb_kunden.SelectedIndexChanged += new System.EventHandler(this.cb_kunden_SelectedIndexChanged);
            // 
            // errorControl3
            // 
            this.errorControl3.AutoSize = true;
            this.errorControl3.Location = new System.Drawing.Point(321, 129);
            this.errorControl3.Name = "errorControl3";
            this.errorControl3.Size = new System.Drawing.Size(0, 13);
            this.errorControl3.TabIndex = 13;
            // 
            // errorControl2
            // 
            this.errorControl2.AutoSize = true;
            this.errorControl2.Location = new System.Drawing.Point(322, 77);
            this.errorControl2.Name = "errorControl2";
            this.errorControl2.Size = new System.Drawing.Size(0, 13);
            this.errorControl2.TabIndex = 12;
            // 
            // errorControl1
            // 
            this.errorControl1.AutoSize = true;
            this.errorControl1.Location = new System.Drawing.Point(222, 48);
            this.errorControl1.Name = "errorControl1";
            this.errorControl1.Size = new System.Drawing.Size(0, 13);
            this.errorControl1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Projekt";
            // 
            // cb_projekt
            // 
            this.cb_projekt.FormattingEnabled = true;
            this.cb_projekt.Location = new System.Drawing.Point(116, 124);
            this.cb_projekt.Name = "cb_projekt";
            this.cb_projekt.Size = new System.Drawing.Size(200, 21);
            this.cb_projekt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bezeichnung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rechnung ID";
            // 
            // dtp_datum
            // 
            this.dtp_datum.Location = new System.Drawing.Point(116, 71);
            this.dtp_datum.Name = "dtp_datum";
            this.dtp_datum.Size = new System.Drawing.Size(200, 20);
            this.dtp_datum.TabIndex = 2;
            // 
            // tb_bezeichnung
            // 
            this.tb_bezeichnung.Location = new System.Drawing.Point(116, 45);
            this.tb_bezeichnung.Name = "tb_bezeichnung";
            this.tb_bezeichnung.Size = new System.Drawing.Size(100, 20);
            this.tb_bezeichnung.TabIndex = 1;
            // 
            // tb_rechnungid
            // 
            this.tb_rechnungid.Enabled = false;
            this.tb_rechnungid.Location = new System.Drawing.Point(116, 19);
            this.tb_rechnungid.Name = "tb_rechnungid";
            this.tb_rechnungid.Size = new System.Drawing.Size(51, 20);
            this.tb_rechnungid.TabIndex = 0;
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.tb_rechnungssumme);
            this.gb2.Controls.Add(this.label8);
            this.gb2.Controls.Add(this.errorControl5);
            this.gb2.Controls.Add(this.errorControl4);
            this.gb2.Controls.Add(this.label7);
            this.gb2.Controls.Add(this.label6);
            this.gb2.Controls.Add(this.bn_add);
            this.gb2.Controls.Add(this.tb_rz_wert);
            this.gb2.Controls.Add(this.tb_rz_bezeichnung);
            this.gb2.Controls.Add(this.lv_zeilen);
            this.gb2.Location = new System.Drawing.Point(12, 226);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(542, 298);
            this.gb2.TabIndex = 1;
            this.gb2.TabStop = false;
            this.gb2.Text = "Rechnungszeilen";
            // 
            // tb_rechnungssumme
            // 
            this.tb_rechnungssumme.Enabled = false;
            this.tb_rechnungssumme.Location = new System.Drawing.Point(408, 262);
            this.tb_rechnungssumme.Name = "tb_rechnungssumme";
            this.tb_rechnungssumme.Size = new System.Drawing.Size(128, 20);
            this.tb_rechnungssumme.TabIndex = 16;
            this.tb_rechnungssumme.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Rechnungssumme";
            // 
            // errorControl5
            // 
            this.errorControl5.AutoSize = true;
            this.errorControl5.Location = new System.Drawing.Point(281, 75);
            this.errorControl5.Name = "errorControl5";
            this.errorControl5.Size = new System.Drawing.Size(0, 13);
            this.errorControl5.TabIndex = 14;
            // 
            // errorControl4
            // 
            this.errorControl4.AutoSize = true;
            this.errorControl4.Location = new System.Drawing.Point(6, 75);
            this.errorControl4.Name = "errorControl4";
            this.errorControl4.Size = new System.Drawing.Size(0, 13);
            this.errorControl4.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Betrag";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bezeichnung";
            // 
            // bn_add
            // 
            this.bn_add.Location = new System.Drawing.Point(461, 50);
            this.bn_add.Name = "bn_add";
            this.bn_add.Size = new System.Drawing.Size(75, 23);
            this.bn_add.TabIndex = 4;
            this.bn_add.Text = "Hinzufügen";
            this.bn_add.UseVisualStyleBackColor = true;
            this.bn_add.Click += new System.EventHandler(this.bn_add_Click);
            // 
            // tb_rz_wert
            // 
            this.tb_rz_wert.Location = new System.Drawing.Point(284, 52);
            this.tb_rz_wert.Name = "tb_rz_wert";
            this.tb_rz_wert.Size = new System.Drawing.Size(171, 20);
            this.tb_rz_wert.TabIndex = 2;
            // 
            // tb_rz_bezeichnung
            // 
            this.tb_rz_bezeichnung.Location = new System.Drawing.Point(6, 52);
            this.tb_rz_bezeichnung.Name = "tb_rz_bezeichnung";
            this.tb_rz_bezeichnung.Size = new System.Drawing.Size(272, 20);
            this.tb_rz_bezeichnung.TabIndex = 1;
            // 
            // lv_zeilen
            // 
            this.lv_zeilen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.reid,
            this.bezeichnung,
            this.betrag});
            this.lv_zeilen.FullRowSelect = true;
            this.lv_zeilen.GridLines = true;
            this.lv_zeilen.Location = new System.Drawing.Point(6, 102);
            this.lv_zeilen.Name = "lv_zeilen";
            this.lv_zeilen.Size = new System.Drawing.Size(530, 155);
            this.lv_zeilen.TabIndex = 0;
            this.lv_zeilen.UseCompatibleStateImageBehavior = false;
            this.lv_zeilen.View = System.Windows.Forms.View.Details;
            this.lv_zeilen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_zeilen_KeyDown);
            // 
            // reid
            // 
            this.reid.Text = "ID";
            this.reid.Width = 30;
            // 
            // bezeichnung
            // 
            this.bezeichnung.Text = "Bezeichnung";
            this.bezeichnung.Width = 120;
            // 
            // betrag
            // 
            this.betrag.Text = "Betrag";
            this.betrag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.betrag.Width = 80;
            // 
            // bn_save
            // 
            this.bn_save.Location = new System.Drawing.Point(12, 185);
            this.bn_save.Name = "bn_save";
            this.bn_save.Size = new System.Drawing.Size(75, 23);
            this.bn_save.TabIndex = 2;
            this.bn_save.Text = "Speichern";
            this.bn_save.UseVisualStyleBackColor = true;
            this.bn_save.Click += new System.EventHandler(this.bn_save_Click);
            // 
            // bn_cancel
            // 
            this.bn_cancel.Location = new System.Drawing.Point(93, 185);
            this.bn_cancel.Name = "bn_cancel";
            this.bn_cancel.Size = new System.Drawing.Size(75, 23);
            this.bn_cancel.TabIndex = 3;
            this.bn_cancel.Text = "Abbrechen";
            this.bn_cancel.UseVisualStyleBackColor = true;
            this.bn_cancel.Click += new System.EventHandler(this.bn_cancel_Click);
            // 
            // gb3
            // 
            this.gb3.Controls.Add(this.bn_new_buchung);
            this.gb3.Controls.Add(this.label9);
            this.gb3.Controls.Add(this.tb_offen);
            this.gb3.Controls.Add(this.lv_buchungen);
            this.gb3.Location = new System.Drawing.Point(560, 12);
            this.gb3.Name = "gb3";
            this.gb3.Size = new System.Drawing.Size(542, 512);
            this.gb3.TabIndex = 15;
            this.gb3.TabStop = false;
            this.gb3.Text = "Buchungen";
            // 
            // bn_new_buchung
            // 
            this.bn_new_buchung.Location = new System.Drawing.Point(6, 16);
            this.bn_new_buchung.Name = "bn_new_buchung";
            this.bn_new_buchung.Size = new System.Drawing.Size(92, 23);
            this.bn_new_buchung.TabIndex = 18;
            this.bn_new_buchung.Text = "Neue Buchung";
            this.bn_new_buchung.UseVisualStyleBackColor = true;
            this.bn_new_buchung.Click += new System.EventHandler(this.bn_new_buchung_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(278, 479);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Offene Rechungssumme";
            // 
            // tb_offen
            // 
            this.tb_offen.Enabled = false;
            this.tb_offen.Location = new System.Drawing.Point(408, 476);
            this.tb_offen.Name = "tb_offen";
            this.tb_offen.Size = new System.Drawing.Size(128, 20);
            this.tb_offen.TabIndex = 17;
            this.tb_offen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lv_buchungen
            // 
            this.lv_buchungen.Location = new System.Drawing.Point(3, 45);
            this.lv_buchungen.Name = "lv_buchungen";
            this.lv_buchungen.Size = new System.Drawing.Size(536, 426);
            this.lv_buchungen.TabIndex = 0;
            this.lv_buchungen.UseCompatibleStateImageBehavior = false;
            this.lv_buchungen.DoubleClick += new System.EventHandler(this.lv_buchungen_DoubleClick);
            // 
            // bn_print
            // 
            this.bn_print.Location = new System.Drawing.Point(479, 185);
            this.bn_print.Name = "bn_print";
            this.bn_print.Size = new System.Drawing.Size(75, 23);
            this.bn_print.TabIndex = 16;
            this.bn_print.Text = "PDF";
            this.bn_print.UseVisualStyleBackColor = true;
            this.bn_print.Click += new System.EventHandler(this.bn_print_Click);
            // 
            // sfd
            // 
            this.sfd.Filter = "PDF|*.pdf";
            // 
            // RechnungDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 536);
            this.Controls.Add(this.bn_print);
            this.Controls.Add(this.gb3);
            this.Controls.Add(this.bn_cancel);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.bn_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RechnungDetail";
            this.Text = "RechnungDetail";
            this.Load += new System.EventHandler(this.RechnungDetail_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.gb3.ResumeLayout(false);
            this.gb3.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_datum;
        private System.Windows.Forms.TextBox tb_bezeichnung;
        private System.Windows.Forms.TextBox tb_rechnungid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_projekt;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.ListView lv_zeilen;
        private System.Windows.Forms.ColumnHeader reid;
        private System.Windows.Forms.ColumnHeader bezeichnung;
        private System.Windows.Forms.ColumnHeader betrag;
        private System.Windows.Forms.Button bn_save;
        private System.Windows.Forms.Button bn_cancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bn_add;
        private System.Windows.Forms.TextBox tb_rz_wert;
        private System.Windows.Forms.TextBox tb_rz_bezeichnung;
        private DataBinding.ErrorControl errorControl3;
        private DataBinding.ErrorControl errorControl2;
        private DataBinding.ErrorControl errorControl1;
        private DataBinding.ErrorControl errorControl5;
        private DataBinding.ErrorControl errorControl4;
        private System.Windows.Forms.GroupBox gb3;
        private System.Windows.Forms.ListView lv_buchungen;
        private System.Windows.Forms.TextBox tb_rechnungssumme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_offen;
        private System.Windows.Forms.Button bn_new_buchung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_kunden;
        private DataBinding.ErrorControl errorControl6;
        private System.Windows.Forms.Button bn_print;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}