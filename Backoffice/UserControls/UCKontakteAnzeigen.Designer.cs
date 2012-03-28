﻿namespace Backoffice.UserControls
{
    partial class UCKontakteAnzeigen
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
            this.bnnew = new System.Windows.Forms.Button();
            this.bndelete = new System.Windows.Forms.Button();
            this.bnedit = new System.Windows.Forms.Button();
            this.lv_kontakte = new System.Windows.Forms.ListView();
            this.kontaktid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firmenname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vorname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nachname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.splitContainer1.Panel1.Controls.Add(this.bnedit);
            this.splitContainer1.Panel1.Controls.Add(this.bndelete);
            this.splitContainer1.Panel1.Controls.Add(this.bnnew);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lv_kontakte);
            this.splitContainer1.Size = new System.Drawing.Size(454, 348);
            this.splitContainer1.SplitterDistance = 43;
            this.splitContainer1.TabIndex = 0;
            // 
            // bnnew
            // 
            this.bnnew.Location = new System.Drawing.Point(11, 8);
            this.bnnew.Margin = new System.Windows.Forms.Padding(10);
            this.bnnew.Name = "bnnew";
            this.bnnew.Size = new System.Drawing.Size(72, 25);
            this.bnnew.TabIndex = 0;
            this.bnnew.Text = "Neu";
            this.bnnew.UseVisualStyleBackColor = true;
            this.bnnew.Click += new System.EventHandler(this.bnnew_Click);
            // 
            // bndelete
            // 
            this.bndelete.Location = new System.Drawing.Point(179, 8);
            this.bndelete.Margin = new System.Windows.Forms.Padding(10);
            this.bndelete.Name = "bndelete";
            this.bndelete.Size = new System.Drawing.Size(72, 25);
            this.bndelete.TabIndex = 1;
            this.bndelete.Text = "Löschen";
            this.bndelete.UseVisualStyleBackColor = true;
            this.bndelete.Click += new System.EventHandler(this.bndelete_Click);
            // 
            // bnedit
            // 
            this.bnedit.Location = new System.Drawing.Point(92, 8);
            this.bnedit.Margin = new System.Windows.Forms.Padding(10);
            this.bnedit.Name = "bnedit";
            this.bnedit.Size = new System.Drawing.Size(72, 25);
            this.bnedit.TabIndex = 2;
            this.bnedit.Text = "Bearbeiten";
            this.bnedit.UseVisualStyleBackColor = true;
            this.bnedit.Click += new System.EventHandler(this.bnedit_Click);
            // 
            // lv_kontakte
            // 
            this.lv_kontakte.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.kontaktid,
            this.firmenname,
            this.vorname,
            this.nachname});
            this.lv_kontakte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_kontakte.FullRowSelect = true;
            this.lv_kontakte.GridLines = true;
            this.lv_kontakte.Location = new System.Drawing.Point(0, 0);
            this.lv_kontakte.Name = "lv_kontakte";
            this.lv_kontakte.Size = new System.Drawing.Size(454, 301);
            this.lv_kontakte.TabIndex = 0;
            this.lv_kontakte.UseCompatibleStateImageBehavior = false;
            this.lv_kontakte.View = System.Windows.Forms.View.Details;
            this.lv_kontakte.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_kontakte_MouseDoubleClick);
            // 
            // kontaktid
            // 
            this.kontaktid.Text = "Kontaktid";
            // 
            // firmenname
            // 
            this.firmenname.Text = "Firmenname";
            this.firmenname.Width = 120;
            // 
            // vorname
            // 
            this.vorname.Text = "Vorname";
            this.vorname.Width = 100;
            // 
            // nachname
            // 
            this.nachname.Text = "Nachname";
            this.nachname.Width = 100;
            // 
            // UCKontakteAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCKontakteAnzeigen";
            this.Size = new System.Drawing.Size(454, 348);
            this.Load += new System.EventHandler(this.UCKontakteAnzeigen_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bnedit;
        private System.Windows.Forms.Button bndelete;
        private System.Windows.Forms.Button bnnew;
        private System.Windows.Forms.ListView lv_kontakte;
        private System.Windows.Forms.ColumnHeader kontaktid;
        private System.Windows.Forms.ColumnHeader firmenname;
        private System.Windows.Forms.ColumnHeader vorname;
        private System.Windows.Forms.ColumnHeader nachname;
    }
}