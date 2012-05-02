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
            this.errorControl3 = new Backoffice.DataBinding.ErrorControl();
            this.errorControl2 = new Backoffice.DataBinding.ErrorControl();
            this.errorControl1 = new Backoffice.DataBinding.ErrorControl();
            this.tb_kunde = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_projekt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_datum = new System.Windows.Forms.DateTimePicker();
            this.tb_bezeichnung = new System.Windows.Forms.TextBox();
            this.tb_rechnungid = new System.Windows.Forms.TextBox();
            this.gb2 = new System.Windows.Forms.GroupBox();
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
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.errorControl3);
            this.gb1.Controls.Add(this.errorControl2);
            this.gb1.Controls.Add(this.errorControl1);
            this.gb1.Controls.Add(this.tb_kunde);
            this.gb1.Controls.Add(this.label5);
            this.gb1.Controls.Add(this.label4);
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
            // errorControl3
            // 
            this.errorControl3.AutoSize = true;
            this.errorControl3.Location = new System.Drawing.Point(322, 100);
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
            // tb_kunde
            // 
            this.tb_kunde.Enabled = false;
            this.tb_kunde.Location = new System.Drawing.Point(116, 124);
            this.tb_kunde.Name = "tb_kunde";
            this.tb_kunde.Size = new System.Drawing.Size(200, 20);
            this.tb_kunde.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Projekt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kunde";
            // 
            // cb_projekt
            // 
            this.cb_projekt.FormattingEnabled = true;
            this.cb_projekt.Location = new System.Drawing.Point(116, 97);
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
            this.gb2.Size = new System.Drawing.Size(542, 268);
            this.gb2.TabIndex = 1;
            this.gb2.TabStop = false;
            this.gb2.Text = "Rechnungszeilen";
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
            this.bn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bn_cancel.Location = new System.Drawing.Point(93, 185);
            this.bn_cancel.Name = "bn_cancel";
            this.bn_cancel.Size = new System.Drawing.Size(75, 23);
            this.bn_cancel.TabIndex = 3;
            this.bn_cancel.Text = "Abbrechen";
            this.bn_cancel.UseVisualStyleBackColor = true;
            // 
            // RechnungDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 507);
            this.Controls.Add(this.bn_cancel);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.bn_save);
            this.Name = "RechnungDetail";
            this.Text = "RechnungDetail";
            this.Load += new System.EventHandler(this.RechnungDetail_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_projekt;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.ListView lv_zeilen;
        private System.Windows.Forms.ColumnHeader reid;
        private System.Windows.Forms.ColumnHeader bezeichnung;
        private System.Windows.Forms.ColumnHeader betrag;
        private System.Windows.Forms.Button bn_save;
        private System.Windows.Forms.Button bn_cancel;
        private System.Windows.Forms.TextBox tb_kunde;
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
    }
}