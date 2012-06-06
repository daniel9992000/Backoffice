namespace Backoffice.UserControls
{
    partial class UCEingangAnzeigen
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
            this.bnedit = new System.Windows.Forms.Button();
            this.bndel = new System.Windows.Forms.Button();
            this.bnnew = new System.Windows.Forms.Button();
            this.lv_eingang = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bezeichnung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.betrag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pfad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tb_search);
            this.splitContainer1.Panel1.Controls.Add(this.bnedit);
            this.splitContainer1.Panel1.Controls.Add(this.bndel);
            this.splitContainer1.Panel1.Controls.Add(this.bnnew);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lv_eingang);
            this.splitContainer1.Size = new System.Drawing.Size(1002, 458);
            this.splitContainer1.SplitterDistance = 31;
            this.splitContainer1.TabIndex = 0;
            // 
            // bnedit
            // 
            this.bnedit.Location = new System.Drawing.Point(96, 4);
            this.bnedit.Name = "bnedit";
            this.bnedit.Size = new System.Drawing.Size(85, 23);
            this.bnedit.TabIndex = 2;
            this.bnedit.Text = "Bearbeiten";
            this.bnedit.UseVisualStyleBackColor = true;
            this.bnedit.Click += new System.EventHandler(this.bnedit_Click);
            // 
            // bndel
            // 
            this.bndel.Location = new System.Drawing.Point(187, 4);
            this.bndel.Name = "bndel";
            this.bndel.Size = new System.Drawing.Size(85, 23);
            this.bndel.TabIndex = 1;
            this.bndel.Text = "Löschen";
            this.bndel.UseVisualStyleBackColor = true;
            this.bndel.Click += new System.EventHandler(this.bndel_Click);
            // 
            // bnnew
            // 
            this.bnnew.Location = new System.Drawing.Point(5, 4);
            this.bnnew.Name = "bnnew";
            this.bnnew.Size = new System.Drawing.Size(85, 23);
            this.bnnew.TabIndex = 0;
            this.bnnew.Text = "Neu";
            this.bnnew.UseVisualStyleBackColor = true;
            this.bnnew.Click += new System.EventHandler(this.bnnew_Click);
            // 
            // lv_eingang
            // 
            this.lv_eingang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.bezeichnung,
            this.betrag,
            this.pfad,
            this.datum});
            this.lv_eingang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_eingang.FullRowSelect = true;
            this.lv_eingang.GridLines = true;
            this.lv_eingang.Location = new System.Drawing.Point(0, 0);
            this.lv_eingang.Name = "lv_eingang";
            this.lv_eingang.Size = new System.Drawing.Size(1002, 423);
            this.lv_eingang.TabIndex = 0;
            this.lv_eingang.UseCompatibleStateImageBehavior = false;
            this.lv_eingang.View = System.Windows.Forms.View.Details;
            this.lv_eingang.DoubleClick += new System.EventHandler(this.lv_eingang_DoubleClick);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // bezeichnung
            // 
            this.bezeichnung.Text = "Bezeichnung";
            this.bezeichnung.Width = 231;
            // 
            // betrag
            // 
            this.betrag.Text = "Betrag";
            this.betrag.Width = 141;
            // 
            // pfad
            // 
            this.pfad.Text = "Pfad";
            this.pfad.Width = 320;
            // 
            // datum
            // 
            this.datum.Text = "Datum";
            this.datum.Width = 104;
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(284, 6);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(237, 20);
            this.tb_search.TabIndex = 3;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // UCEingangAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCEingangAnzeigen";
            this.Size = new System.Drawing.Size(1002, 458);
            this.Load += new System.EventHandler(this.UCEingangAnzeigen_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lv_eingang;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader bezeichnung;
        private System.Windows.Forms.ColumnHeader betrag;
        private System.Windows.Forms.ColumnHeader pfad;
        private System.Windows.Forms.Button bnedit;
        private System.Windows.Forms.Button bndel;
        private System.Windows.Forms.Button bnnew;
        private System.Windows.Forms.ColumnHeader datum;
        private System.Windows.Forms.TextBox tb_search;
    }
}
