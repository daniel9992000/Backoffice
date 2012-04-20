namespace Backoffice.UserControls
{
    partial class UCOffeneRechnungenAnzeigen
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnakt = new System.Windows.Forms.Button();
            this.btngenpdf = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lv_eingangr = new System.Windows.Forms.ListView();
            this.rechnungid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.betragges = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.offbetrag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_ausgangr = new System.Windows.Forms.ListView();
            this.aid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.abetrag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.abetragoff = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sFD1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnakt);
            this.splitContainer1.Panel1.Controls.Add(this.btngenpdf);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(877, 451);
            this.splitContainer1.SplitterDistance = 91;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnakt
            // 
            this.btnakt.Location = new System.Drawing.Point(325, 34);
            this.btnakt.Name = "btnakt";
            this.btnakt.Size = new System.Drawing.Size(127, 41);
            this.btnakt.TabIndex = 3;
            this.btnakt.Text = "Bericht aktualisieren";
            this.btnakt.UseVisualStyleBackColor = true;
            this.btnakt.Click += new System.EventHandler(this.btnakt_Click);
            // 
            // btngenpdf
            // 
            this.btngenpdf.Location = new System.Drawing.Point(456, 34);
            this.btngenpdf.Name = "btngenpdf";
            this.btngenpdf.Size = new System.Drawing.Size(125, 41);
            this.btngenpdf.TabIndex = 2;
            this.btngenpdf.Text = "Pdf generieren";
            this.btngenpdf.UseVisualStyleBackColor = true;
            this.btngenpdf.Click += new System.EventHandler(this.btngenpdf_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(619, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Offene Ausgangsrechnungen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Offene Eingangsrechnungen";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lv_eingangr);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lv_ausgangr);
            this.splitContainer2.Size = new System.Drawing.Size(877, 356);
            this.splitContainer2.SplitterDistance = 452;
            this.splitContainer2.TabIndex = 1;
            // 
            // lv_eingangr
            // 
            this.lv_eingangr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rechnungid,
            this.betragges,
            this.offbetrag,
            this.datum});
            this.lv_eingangr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_eingangr.GridLines = true;
            this.lv_eingangr.Location = new System.Drawing.Point(0, 0);
            this.lv_eingangr.Name = "lv_eingangr";
            this.lv_eingangr.Size = new System.Drawing.Size(452, 356);
            this.lv_eingangr.TabIndex = 0;
            this.lv_eingangr.UseCompatibleStateImageBehavior = false;
            this.lv_eingangr.View = System.Windows.Forms.View.Details;
            // 
            // rechnungid
            // 
            this.rechnungid.Text = "ID";
            this.rechnungid.Width = 54;
            // 
            // betragges
            // 
            this.betragges.Text = "Betrag gesamt";
            this.betragges.Width = 110;
            // 
            // offbetrag
            // 
            this.offbetrag.Text = "Offener Betrag";
            this.offbetrag.Width = 94;
            // 
            // datum
            // 
            this.datum.Text = "Datum";
            this.datum.Width = 93;
            // 
            // lv_ausgangr
            // 
            this.lv_ausgangr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.aid,
            this.abetrag,
            this.abetragoff,
            this.adatum});
            this.lv_ausgangr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_ausgangr.GridLines = true;
            this.lv_ausgangr.Location = new System.Drawing.Point(0, 0);
            this.lv_ausgangr.Name = "lv_ausgangr";
            this.lv_ausgangr.Size = new System.Drawing.Size(421, 356);
            this.lv_ausgangr.TabIndex = 1;
            this.lv_ausgangr.UseCompatibleStateImageBehavior = false;
            this.lv_ausgangr.View = System.Windows.Forms.View.Details;
            // 
            // aid
            // 
            this.aid.Text = "ID";
            this.aid.Width = 71;
            // 
            // abetrag
            // 
            this.abetrag.Text = "Betrag gesamt";
            this.abetrag.Width = 103;
            // 
            // abetragoff
            // 
            this.abetragoff.Text = "Offener Betrag";
            this.abetragoff.Width = 87;
            // 
            // adatum
            // 
            this.adatum.Text = "Datum";
            this.adatum.Width = 88;
            // 
            // sFD1
            // 
            this.sFD1.DefaultExt = "pdf";
            this.sFD1.FileName = "OffeneRechnungen";
            this.sFD1.Filter = "pdf|*.pdf";
            // 
            // UCOffeneRechnungenAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCOffeneRechnungenAnzeigen";
            this.Size = new System.Drawing.Size(877, 451);
            this.Load += new System.EventHandler(this.UCOffeneRechnungenAnzeigen_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnakt;
        private System.Windows.Forms.Button btngenpdf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView lv_eingangr;
        private System.Windows.Forms.ColumnHeader rechnungid;
        private System.Windows.Forms.ColumnHeader betragges;
        private System.Windows.Forms.ColumnHeader datum;
        private System.Windows.Forms.ListView lv_ausgangr;
        private System.Windows.Forms.ColumnHeader aid;
        private System.Windows.Forms.ColumnHeader abetrag;
        private System.Windows.Forms.ColumnHeader adatum;
        private System.Windows.Forms.ColumnHeader abetragoff;
        private System.Windows.Forms.ColumnHeader offbetrag;
        private System.Windows.Forms.SaveFileDialog sFD1;
    }
}
