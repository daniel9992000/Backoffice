namespace Backoffice.Dialogs
{
    partial class UCOffeneProjekteAnzeigen
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
            this.lv_angebote = new System.Windows.Forms.ListView();
            this.projektid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Angebotname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.summe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bnakt = new System.Windows.Forms.Button();
            this.bngenpdf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboffprojekte = new System.Windows.Forms.TextBox();
            this.sFD1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.lv_angebote);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bnakt);
            this.splitContainer1.Panel2.Controls.Add(this.bngenpdf);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.tboffprojekte);
            this.splitContainer1.Size = new System.Drawing.Size(917, 401);
            this.splitContainer1.SplitterDistance = 293;
            this.splitContainer1.TabIndex = 0;
            // 
            // lv_angebote
            // 
            this.lv_angebote.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.projektid,
            this.Angebotname,
            this.chance,
            this.summe,
            this.datum});
            this.lv_angebote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_angebote.GridLines = true;
            this.lv_angebote.Location = new System.Drawing.Point(0, 0);
            this.lv_angebote.Name = "lv_angebote";
            this.lv_angebote.Size = new System.Drawing.Size(917, 293);
            this.lv_angebote.TabIndex = 0;
            this.lv_angebote.UseCompatibleStateImageBehavior = false;
            this.lv_angebote.View = System.Windows.Forms.View.Details;
            // 
            // projektid
            // 
            this.projektid.Text = "ID";
            // 
            // Angebotname
            // 
            this.Angebotname.Text = "Angebotname";
            this.Angebotname.Width = 160;
            // 
            // chance
            // 
            this.chance.Text = "Chance";
            this.chance.Width = 121;
            // 
            // summe
            // 
            this.summe.Text = "Summe";
            this.summe.Width = 112;
            // 
            // datum
            // 
            this.datum.Text = "Datum";
            this.datum.Width = 119;
            // 
            // bnakt
            // 
            this.bnakt.Location = new System.Drawing.Point(532, 33);
            this.bnakt.Name = "bnakt";
            this.bnakt.Size = new System.Drawing.Size(116, 44);
            this.bnakt.TabIndex = 3;
            this.bnakt.Text = "Bericht aktualisieren";
            this.bnakt.UseVisualStyleBackColor = true;
            this.bnakt.Click += new System.EventHandler(this.bnakt_Click);
            // 
            // bngenpdf
            // 
            this.bngenpdf.Location = new System.Drawing.Point(682, 33);
            this.bngenpdf.Name = "bngenpdf";
            this.bngenpdf.Size = new System.Drawing.Size(130, 44);
            this.bngenpdf.TabIndex = 2;
            this.bngenpdf.Text = "Pdf generieren";
            this.bngenpdf.UseVisualStyleBackColor = true;
            this.bngenpdf.Click += new System.EventHandler(this.bngenpdf_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anzahl offene Projekte: ";
            // 
            // tboffprojekte
            // 
            this.tboffprojekte.Location = new System.Drawing.Point(209, 46);
            this.tboffprojekte.Name = "tboffprojekte";
            this.tboffprojekte.ReadOnly = true;
            this.tboffprojekte.Size = new System.Drawing.Size(100, 20);
            this.tboffprojekte.TabIndex = 0;
            // 
            // sFD1
            // 
            this.sFD1.DefaultExt = "pdf";
            this.sFD1.FileName = "Offene_Projekte";
            this.sFD1.Filter = "pdf|*.pdf";
            // 
            // UCOffeneProjekteAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCOffeneProjekteAnzeigen";
            this.Size = new System.Drawing.Size(917, 401);
            this.Load += new System.EventHandler(this.UCOffeneProjekteAnzeigen_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lv_angebote;
        private System.Windows.Forms.ColumnHeader projektid;
        private System.Windows.Forms.ColumnHeader Angebotname;
        private System.Windows.Forms.ColumnHeader chance;
        private System.Windows.Forms.ColumnHeader summe;
        private System.Windows.Forms.ColumnHeader datum;
        private System.Windows.Forms.Button bngenpdf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboffprojekte;
        private System.Windows.Forms.Button bnakt;
        private System.Windows.Forms.SaveFileDialog sFD1;
    }
}
