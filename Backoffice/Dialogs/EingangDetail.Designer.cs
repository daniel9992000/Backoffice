namespace Backoffice.Dialogs
{
    partial class EingangDetail
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
            this.oFD = new System.Windows.Forms.OpenFileDialog();
            this.bn_cancel = new System.Windows.Forms.Button();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.errorControl5 = new Backoffice.DataBinding.ErrorControl();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_betrag = new System.Windows.Forms.TextBox();
            this.errorControl3 = new Backoffice.DataBinding.ErrorControl();
            this.errorControl2 = new Backoffice.DataBinding.ErrorControl();
            this.errorControl1 = new Backoffice.DataBinding.ErrorControl();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_kontakt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_datum = new System.Windows.Forms.DateTimePicker();
            this.tb_bezeichnung = new System.Windows.Forms.TextBox();
            this.tb_rechnungid = new System.Windows.Forms.TextBox();
            this.bn_save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorControl4 = new Backoffice.DataBinding.ErrorControl();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_pfad = new System.Windows.Forms.TextBox();
            this.bnchooserech = new System.Windows.Forms.Button();
            this.gb1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // oFD
            // 
            this.oFD.FileName = "openFileDialog1";
            // 
            // bn_cancel
            // 
            this.bn_cancel.Location = new System.Drawing.Point(120, 218);
            this.bn_cancel.Name = "bn_cancel";
            this.bn_cancel.Size = new System.Drawing.Size(75, 23);
            this.bn_cancel.TabIndex = 6;
            this.bn_cancel.Text = "Abbrechen";
            this.bn_cancel.UseVisualStyleBackColor = true;
            this.bn_cancel.Click += new System.EventHandler(this.bn_cancel_Click);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.errorControl5);
            this.gb1.Controls.Add(this.label6);
            this.gb1.Controls.Add(this.tb_betrag);
            this.gb1.Controls.Add(this.errorControl3);
            this.gb1.Controls.Add(this.errorControl2);
            this.gb1.Controls.Add(this.errorControl1);
            this.gb1.Controls.Add(this.label5);
            this.gb1.Controls.Add(this.cb_kontakt);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Controls.Add(this.dtp_datum);
            this.gb1.Controls.Add(this.tb_bezeichnung);
            this.gb1.Controls.Add(this.tb_rechnungid);
            this.gb1.Location = new System.Drawing.Point(28, 35);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(541, 157);
            this.gb1.TabIndex = 4;
            this.gb1.TabStop = false;
            this.gb1.Text = "Allgemein";
            // 
            // errorControl5
            // 
            this.errorControl5.AutoSize = true;
            this.errorControl5.Location = new System.Drawing.Point(228, 52);
            this.errorControl5.Name = "errorControl5";
            this.errorControl5.Size = new System.Drawing.Size(0, 13);
            this.errorControl5.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Betrag";
            // 
            // tb_betrag
            // 
            this.tb_betrag.Location = new System.Drawing.Point(116, 46);
            this.tb_betrag.Name = "tb_betrag";
            this.tb_betrag.Size = new System.Drawing.Size(92, 20);
            this.tb_betrag.TabIndex = 17;
            // 
            // errorControl3
            // 
            this.errorControl3.AutoSize = true;
            this.errorControl3.Location = new System.Drawing.Point(344, 126);
            this.errorControl3.Name = "errorControl3";
            this.errorControl3.Size = new System.Drawing.Size(0, 13);
            this.errorControl3.TabIndex = 16;
            // 
            // errorControl2
            // 
            this.errorControl2.AutoSize = true;
            this.errorControl2.Location = new System.Drawing.Point(344, 104);
            this.errorControl2.Name = "errorControl2";
            this.errorControl2.Size = new System.Drawing.Size(0, 13);
            this.errorControl2.TabIndex = 15;
            // 
            // errorControl1
            // 
            this.errorControl1.AutoSize = true;
            this.errorControl1.Location = new System.Drawing.Point(294, 81);
            this.errorControl1.Name = "errorControl1";
            this.errorControl1.Size = new System.Drawing.Size(0, 13);
            this.errorControl1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kontakt";
            // 
            // cb_kontakt
            // 
            this.cb_kontakt.FormattingEnabled = true;
            this.cb_kontakt.Location = new System.Drawing.Point(116, 126);
            this.cb_kontakt.Name = "cb_kontakt";
            this.cb_kontakt.Size = new System.Drawing.Size(200, 21);
            this.cb_kontakt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 81);
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
            this.dtp_datum.Location = new System.Drawing.Point(116, 100);
            this.dtp_datum.Name = "dtp_datum";
            this.dtp_datum.Size = new System.Drawing.Size(200, 20);
            this.dtp_datum.TabIndex = 2;
            // 
            // tb_bezeichnung
            // 
            this.tb_bezeichnung.Location = new System.Drawing.Point(116, 74);
            this.tb_bezeichnung.Name = "tb_bezeichnung";
            this.tb_bezeichnung.Size = new System.Drawing.Size(154, 20);
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
            // bn_save
            // 
            this.bn_save.Location = new System.Drawing.Point(28, 218);
            this.bn_save.Name = "bn_save";
            this.bn_save.Size = new System.Drawing.Size(75, 23);
            this.bn_save.TabIndex = 5;
            this.bn_save.Text = "Speichern";
            this.bn_save.UseVisualStyleBackColor = true;
            this.bn_save.Click += new System.EventHandler(this.bn_save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.errorControl4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_pfad);
            this.groupBox1.Controls.Add(this.bnchooserech);
            this.groupBox1.Location = new System.Drawing.Point(28, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechnung";
            // 
            // errorControl4
            // 
            this.errorControl4.AutoSize = true;
            this.errorControl4.Location = new System.Drawing.Point(203, 69);
            this.errorControl4.Name = "errorControl4";
            this.errorControl4.Size = new System.Drawing.Size(0, 13);
            this.errorControl4.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pfad ";
            // 
            // tb_pfad
            // 
            this.tb_pfad.Location = new System.Drawing.Point(44, 46);
            this.tb_pfad.Name = "tb_pfad";
            this.tb_pfad.Size = new System.Drawing.Size(391, 20);
            this.tb_pfad.TabIndex = 1;
            // 
            // bnchooserech
            // 
            this.bnchooserech.Location = new System.Drawing.Point(441, 34);
            this.bnchooserech.Name = "bnchooserech";
            this.bnchooserech.Size = new System.Drawing.Size(94, 42);
            this.bnchooserech.TabIndex = 0;
            this.bnchooserech.Text = "Rechnung wählen";
            this.bnchooserech.UseVisualStyleBackColor = true;
            this.bnchooserech.Click += new System.EventHandler(this.bnchooserech_Click);
            // 
            // EingangDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 424);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bn_cancel);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.bn_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EingangDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EingangDetail";
            this.Load += new System.EventHandler(this.EingangDetail_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog oFD;
        private System.Windows.Forms.Button bn_cancel;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_kontakt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_datum;
        private System.Windows.Forms.TextBox tb_bezeichnung;
        private System.Windows.Forms.TextBox tb_rechnungid;
        private System.Windows.Forms.Button bn_save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_pfad;
        private System.Windows.Forms.Button bnchooserech;
        private DataBinding.ErrorControl errorControl3;
        private DataBinding.ErrorControl errorControl2;
        private DataBinding.ErrorControl errorControl1;
        private DataBinding.ErrorControl errorControl4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_betrag;
        private DataBinding.ErrorControl errorControl5;
    }
}