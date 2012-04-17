namespace Backoffice.UserControls
{
    partial class UCStundensatzAnzeigen
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
            this.lv_projekte = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projekname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Projektdauer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Projektkosten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stundensatz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.tbstdsatz = new System.Windows.Forms.TextBox();
            this.bngen = new System.Windows.Forms.Button();
            this.bnakt = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel1.Controls.Add(this.lv_projekte);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bnakt);
            this.splitContainer1.Panel2.Controls.Add(this.bngen);
            this.splitContainer1.Panel2.Controls.Add(this.tbstdsatz);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(886, 455);
            this.splitContainer1.SplitterDistance = 359;
            this.splitContainer1.TabIndex = 0;
            // 
            // lv_projekte
            // 
            this.lv_projekte.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.projekname,
            this.Projektdauer,
            this.Projektkosten,
            this.Stundensatz});
            this.lv_projekte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_projekte.GridLines = true;
            this.lv_projekte.Location = new System.Drawing.Point(0, 0);
            this.lv_projekte.Name = "lv_projekte";
            this.lv_projekte.Size = new System.Drawing.Size(886, 359);
            this.lv_projekte.TabIndex = 0;
            this.lv_projekte.UseCompatibleStateImageBehavior = false;
            this.lv_projekte.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // projekname
            // 
            this.projekname.Text = "Projektname";
            this.projekname.Width = 160;
            // 
            // Projektdauer
            // 
            this.Projektdauer.Text = "Projektdauer";
            this.Projektdauer.Width = 126;
            // 
            // Projektkosten
            // 
            this.Projektkosten.Text = "Projektkosten";
            this.Projektkosten.Width = 119;
            // 
            // Stundensatz
            // 
            this.Stundensatz.Text = "Stundensatz";
            this.Stundensatz.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Durchschnittlicher Stundensatz:";
            // 
            // tbstdsatz
            // 
            this.tbstdsatz.Location = new System.Drawing.Point(199, 33);
            this.tbstdsatz.Name = "tbstdsatz";
            this.tbstdsatz.ReadOnly = true;
            this.tbstdsatz.Size = new System.Drawing.Size(100, 20);
            this.tbstdsatz.TabIndex = 1;
            // 
            // bngen
            // 
            this.bngen.Location = new System.Drawing.Point(683, 24);
            this.bngen.Name = "bngen";
            this.bngen.Size = new System.Drawing.Size(155, 51);
            this.bngen.TabIndex = 2;
            this.bngen.Text = "Pdf generieren";
            this.bngen.UseVisualStyleBackColor = true;
            this.bngen.Click += new System.EventHandler(this.bngen_Click);
            // 
            // bnakt
            // 
            this.bnakt.Location = new System.Drawing.Point(484, 24);
            this.bnakt.Name = "bnakt";
            this.bnakt.Size = new System.Drawing.Size(155, 51);
            this.bnakt.TabIndex = 3;
            this.bnakt.Text = "Bericht aktualisieren";
            this.bnakt.UseVisualStyleBackColor = true;
            this.bnakt.Click += new System.EventHandler(this.bnakt_Click);
            // 
            // UCStundensatzAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCStundensatzAnzeigen";
            this.Size = new System.Drawing.Size(886, 455);
            this.Load += new System.EventHandler(this.UCStundensatzAnzeigen_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lv_projekte;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader projekname;
        private System.Windows.Forms.ColumnHeader Projektdauer;
        private System.Windows.Forms.ColumnHeader Projektkosten;
        private System.Windows.Forms.ColumnHeader Stundensatz;
        private System.Windows.Forms.Button bnakt;
        private System.Windows.Forms.Button bngen;
        private System.Windows.Forms.TextBox tbstdsatz;
        private System.Windows.Forms.Label label1;
    }
}
