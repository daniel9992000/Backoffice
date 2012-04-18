namespace Backoffice.UserControls
{
    partial class UCJahresumsatzAnzeigen
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
            this.bngenpdf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbsumangebote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbanzangebote = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lv_angebote = new System.Windows.Forms.ListView();
            this.titel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.summe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bnaktualisieren = new System.Windows.Forms.Button();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbisumang = new System.Windows.Forms.TextBox();
            this.tbianzang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.sFD1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bngenpdf
            // 
            this.bngenpdf.Location = new System.Drawing.Point(677, 87);
            this.bngenpdf.Name = "bngenpdf";
            this.bngenpdf.Size = new System.Drawing.Size(122, 35);
            this.bngenpdf.TabIndex = 0;
            this.bngenpdf.Text = "Pdf generieren";
            this.bngenpdf.UseVisualStyleBackColor = true;
            this.bngenpdf.Click += new System.EventHandler(this.bngenpdf_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anzahl der Angebote";
            // 
            // tbsumangebote
            // 
            this.tbsumangebote.Location = new System.Drawing.Point(169, 56);
            this.tbsumangebote.Name = "tbsumangebote";
            this.tbsumangebote.ReadOnly = true;
            this.tbsumangebote.Size = new System.Drawing.Size(110, 20);
            this.tbsumangebote.TabIndex = 2;
            this.tbsumangebote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Summe aller Angebote";
            // 
            // tbanzangebote
            // 
            this.tbanzangebote.Location = new System.Drawing.Point(18, 56);
            this.tbanzangebote.Name = "tbanzangebote";
            this.tbanzangebote.ReadOnly = true;
            this.tbanzangebote.Size = new System.Drawing.Size(103, 20);
            this.tbanzangebote.TabIndex = 4;
            this.tbanzangebote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
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
            this.splitContainer1.Panel2.Controls.Add(this.bnaktualisieren);
            this.splitContainer1.Panel2.Controls.Add(this.gb1);
            this.splitContainer1.Panel2.Controls.Add(this.gb2);
            this.splitContainer1.Panel2.Controls.Add(this.bngenpdf);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(849, 482);
            this.splitContainer1.SplitterDistance = 317;
            this.splitContainer1.TabIndex = 5;
            // 
            // lv_angebote
            // 
            this.lv_angebote.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titel,
            this.summe,
            this.datum,
            this.chance});
            this.lv_angebote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_angebote.GridLines = true;
            this.lv_angebote.Location = new System.Drawing.Point(0, 0);
            this.lv_angebote.Name = "lv_angebote";
            this.lv_angebote.Size = new System.Drawing.Size(849, 317);
            this.lv_angebote.TabIndex = 0;
            this.lv_angebote.UseCompatibleStateImageBehavior = false;
            this.lv_angebote.View = System.Windows.Forms.View.Details;
            // 
            // titel
            // 
            this.titel.Text = "Titel";
            this.titel.Width = 153;
            // 
            // summe
            // 
            this.summe.Text = "Summe";
            this.summe.Width = 120;
            // 
            // datum
            // 
            this.datum.Text = "Datum";
            this.datum.Width = 98;
            // 
            // chance
            // 
            this.chance.Text = "Chance";
            this.chance.Width = 97;
            // 
            // bnaktualisieren
            // 
            this.bnaktualisieren.Location = new System.Drawing.Point(677, 37);
            this.bnaktualisieren.Name = "bnaktualisieren";
            this.bnaktualisieren.Size = new System.Drawing.Size(122, 33);
            this.bnaktualisieren.TabIndex = 7;
            this.bnaktualisieren.Text = "Bericht aktualisieren";
            this.bnaktualisieren.UseVisualStyleBackColor = true;
            this.bnaktualisieren.Click += new System.EventHandler(this.bnaktualisieren_Click);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.tbisumang);
            this.gb1.Controls.Add(this.tbianzang);
            this.gb1.Controls.Add(this.label4);
            this.gb1.Location = new System.Drawing.Point(22, 31);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(294, 91);
            this.gb1.TabIndex = 6;
            this.gb1.TabStop = false;
            this.gb1.Text = "Ist-Stand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Summe aller Angebote";
            // 
            // tbisumang
            // 
            this.tbisumang.Location = new System.Drawing.Point(169, 56);
            this.tbisumang.Name = "tbisumang";
            this.tbisumang.ReadOnly = true;
            this.tbisumang.Size = new System.Drawing.Size(110, 20);
            this.tbisumang.TabIndex = 2;
            this.tbisumang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbianzang
            // 
            this.tbianzang.Location = new System.Drawing.Point(18, 56);
            this.tbianzang.Name = "tbianzang";
            this.tbianzang.ReadOnly = true;
            this.tbianzang.Size = new System.Drawing.Size(103, 20);
            this.tbianzang.TabIndex = 4;
            this.tbianzang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Anzahl der Angebote";
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.label2);
            this.gb2.Controls.Add(this.tbsumangebote);
            this.gb2.Controls.Add(this.tbanzangebote);
            this.gb2.Controls.Add(this.label1);
            this.gb2.Location = new System.Drawing.Point(335, 31);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(294, 91);
            this.gb2.TabIndex = 5;
            this.gb2.TabStop = false;
            this.gb2.Text = "Prognose";
            // 
            // sFD1
            // 
            this.sFD1.DefaultExt = "pdf";
            this.sFD1.FileName = "Jahresumsatz";
            this.sFD1.Filter = "pdf|*.pdf";
            // 
            // UCJahresumsatzAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCJahresumsatzAnzeigen";
            this.Size = new System.Drawing.Size(849, 482);
            this.Load += new System.EventHandler(this.UCJahresumsatzAnzeigen_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bngenpdf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbsumangebote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbanzangebote;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lv_angebote;
        private System.Windows.Forms.ColumnHeader titel;
        private System.Windows.Forms.ColumnHeader summe;
        private System.Windows.Forms.ColumnHeader datum;
        private System.Windows.Forms.ColumnHeader chance;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbisumang;
        private System.Windows.Forms.TextBox tbianzang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Button bnaktualisieren;
        private System.Windows.Forms.SaveFileDialog sFD1;
    }
}
