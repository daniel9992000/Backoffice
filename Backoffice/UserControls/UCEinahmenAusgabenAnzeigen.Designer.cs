namespace Backoffice.UserControls
{
    partial class UCEinahmenAusgabenAnzeigen
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
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bn_createpdf = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lv_einnahmen = new System.Windows.Forms.ListView();
            this.eid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ebetrag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eKategorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eDatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_ausgaben = new System.Windows.Forms.ListView();
            this.aID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.abetrag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aKategorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bnaktualisieren = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel1.Controls.Add(this.bnaktualisieren);
            this.splitContainer1.Panel1.Controls.Add(this.dtp1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.bn_createpdf);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(953, 462);
            this.splitContainer1.SplitterDistance = 73;
            this.splitContainer1.TabIndex = 0;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(243, 14);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 20);
            this.dtp1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(704, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ausgaben:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Einnahmen:";
            // 
            // bn_createpdf
            // 
            this.bn_createpdf.Location = new System.Drawing.Point(483, 14);
            this.bn_createpdf.Name = "bn_createpdf";
            this.bn_createpdf.Size = new System.Drawing.Size(172, 44);
            this.bn_createpdf.TabIndex = 0;
            this.bn_createpdf.Text = "Pdf generieren";
            this.bn_createpdf.UseVisualStyleBackColor = true;
            this.bn_createpdf.Click += new System.EventHandler(this.bn_createpdf_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lv_einnahmen);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lv_ausgaben);
            this.splitContainer2.Size = new System.Drawing.Size(953, 385);
            this.splitContainer2.SplitterDistance = 479;
            this.splitContainer2.TabIndex = 0;
            // 
            // lv_einnahmen
            // 
            this.lv_einnahmen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.eid,
            this.ebetrag,
            this.eKategorie,
            this.eDatum});
            this.lv_einnahmen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_einnahmen.GridLines = true;
            this.lv_einnahmen.Location = new System.Drawing.Point(0, 0);
            this.lv_einnahmen.Name = "lv_einnahmen";
            this.lv_einnahmen.Size = new System.Drawing.Size(479, 385);
            this.lv_einnahmen.TabIndex = 0;
            this.lv_einnahmen.UseCompatibleStateImageBehavior = false;
            this.lv_einnahmen.View = System.Windows.Forms.View.Details;
            // 
            // eid
            // 
            this.eid.Text = "ID";
            // 
            // ebetrag
            // 
            this.ebetrag.Text = "Betrag";
            this.ebetrag.Width = 105;
            // 
            // eKategorie
            // 
            this.eKategorie.Text = "Kategorie";
            this.eKategorie.Width = 107;
            // 
            // eDatum
            // 
            this.eDatum.Text = "Datum";
            this.eDatum.Width = 90;
            // 
            // lv_ausgaben
            // 
            this.lv_ausgaben.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.aID,
            this.abetrag,
            this.adatum,
            this.aKategorie});
            this.lv_ausgaben.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_ausgaben.GridLines = true;
            this.lv_ausgaben.Location = new System.Drawing.Point(0, 0);
            this.lv_ausgaben.Name = "lv_ausgaben";
            this.lv_ausgaben.Size = new System.Drawing.Size(470, 385);
            this.lv_ausgaben.TabIndex = 0;
            this.lv_ausgaben.UseCompatibleStateImageBehavior = false;
            this.lv_ausgaben.View = System.Windows.Forms.View.Details;
            // 
            // aID
            // 
            this.aID.Text = "ID";
            // 
            // abetrag
            // 
            this.abetrag.Text = "Betrag";
            this.abetrag.Width = 94;
            // 
            // adatum
            // 
            this.adatum.DisplayIndex = 3;
            this.adatum.Text = "Datum";
            this.adatum.Width = 99;
            // 
            // aKategorie
            // 
            this.aKategorie.DisplayIndex = 2;
            this.aKategorie.Text = "Kategorie";
            this.aKategorie.Width = 117;
            // 
            // bnaktualisieren
            // 
            this.bnaktualisieren.Location = new System.Drawing.Point(243, 34);
            this.bnaktualisieren.Name = "bnaktualisieren";
            this.bnaktualisieren.Size = new System.Drawing.Size(200, 30);
            this.bnaktualisieren.TabIndex = 4;
            this.bnaktualisieren.Text = "Bericht aktualisieren";
            this.bnaktualisieren.UseVisualStyleBackColor = true;
            this.bnaktualisieren.Click += new System.EventHandler(this.bnaktualisieren_Click);
            // 
            // UCEinahmenAusgabenAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCEinahmenAusgabenAnzeigen";
            this.Size = new System.Drawing.Size(953, 462);
            this.Load += new System.EventHandler(this.UCEinahmenAusgabenAnzeigen_Load);
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
        private System.Windows.Forms.Button bn_createpdf;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView lv_einnahmen;
        private System.Windows.Forms.ColumnHeader eid;
        private System.Windows.Forms.ColumnHeader ebetrag;
        private System.Windows.Forms.ColumnHeader eKategorie;
        private System.Windows.Forms.ColumnHeader eDatum;
        private System.Windows.Forms.ListView lv_ausgaben;
        private System.Windows.Forms.ColumnHeader aID;
        private System.Windows.Forms.ColumnHeader abetrag;
        private System.Windows.Forms.ColumnHeader adatum;
        private System.Windows.Forms.ColumnHeader aKategorie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Button bnaktualisieren;
    }
}
