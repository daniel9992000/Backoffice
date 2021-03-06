﻿namespace Backoffice.UserControls
{
    partial class UCKundenAnzeigen
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
            this.lv_kunden = new System.Windows.Forms.ListView();
            this.kundenid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vorname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nachname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hausnummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.plz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.bn_delete = new System.Windows.Forms.Button();
            this.bn_edit = new System.Windows.Forms.Button();
            this.bn_new = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_kunden
            // 
            this.lv_kunden.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.kundenid,
            this.vorname,
            this.nachname,
            this.email,
            this.adresse,
            this.hausnummer,
            this.plz,
            this.ort});
            this.lv_kunden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_kunden.FullRowSelect = true;
            this.lv_kunden.GridLines = true;
            this.lv_kunden.Location = new System.Drawing.Point(0, 0);
            this.lv_kunden.Margin = new System.Windows.Forms.Padding(10);
            this.lv_kunden.Name = "lv_kunden";
            this.lv_kunden.Size = new System.Drawing.Size(732, 314);
            this.lv_kunden.TabIndex = 0;
            this.lv_kunden.UseCompatibleStateImageBehavior = false;
            this.lv_kunden.View = System.Windows.Forms.View.Details;
            this.lv_kunden.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lv_kunden_ColumnClick);
            this.lv_kunden.SelectedIndexChanged += new System.EventHandler(this.lv_kunden_SelectedIndexChanged);
            this.lv_kunden.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_kunden_MouseDoubleClick);
            // 
            // kundenid
            // 
            this.kundenid.Text = "ID";
            this.kundenid.Width = 51;
            // 
            // vorname
            // 
            this.vorname.Text = "Vorname";
            this.vorname.Width = 89;
            // 
            // nachname
            // 
            this.nachname.Text = "Nachname";
            this.nachname.Width = 111;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 130;
            // 
            // adresse
            // 
            this.adresse.Text = "Adresse";
            this.adresse.Width = 90;
            // 
            // hausnummer
            // 
            this.hausnummer.Text = "Hausnummer";
            // 
            // plz
            // 
            this.plz.Text = "PLZ";
            this.plz.Width = 40;
            // 
            // ort
            // 
            this.ort.Text = "Ort";
            this.ort.Width = 100;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tb_search);
            this.splitContainer1.Panel1.Controls.Add(this.bn_delete);
            this.splitContainer1.Panel1.Controls.Add(this.bn_edit);
            this.splitContainer1.Panel1.Controls.Add(this.bn_new);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lv_kunden);
            this.splitContainer1.Size = new System.Drawing.Size(732, 349);
            this.splitContainer1.SplitterDistance = 31;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(250, 5);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(248, 20);
            this.tb_search.TabIndex = 3;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // bn_delete
            // 
            this.bn_delete.Location = new System.Drawing.Point(165, 3);
            this.bn_delete.Name = "bn_delete";
            this.bn_delete.Size = new System.Drawing.Size(75, 23);
            this.bn_delete.TabIndex = 2;
            this.bn_delete.Text = "Löschen";
            this.bn_delete.UseVisualStyleBackColor = true;
            this.bn_delete.Click += new System.EventHandler(this.bn_delete_Click);
            // 
            // bn_edit
            // 
            this.bn_edit.Location = new System.Drawing.Point(84, 3);
            this.bn_edit.Name = "bn_edit";
            this.bn_edit.Size = new System.Drawing.Size(75, 23);
            this.bn_edit.TabIndex = 1;
            this.bn_edit.Text = "Bearbeiten";
            this.bn_edit.UseVisualStyleBackColor = true;
            this.bn_edit.Click += new System.EventHandler(this.bn_edit_Click);
            // 
            // bn_new
            // 
            this.bn_new.Location = new System.Drawing.Point(3, 3);
            this.bn_new.Name = "bn_new";
            this.bn_new.Size = new System.Drawing.Size(75, 23);
            this.bn_new.TabIndex = 0;
            this.bn_new.Text = "Neu";
            this.bn_new.UseVisualStyleBackColor = true;
            this.bn_new.Click += new System.EventHandler(this.bn_new_Click);
            // 
            // UCKundenAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCKundenAnzeigen";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(752, 369);
            this.Load += new System.EventHandler(this.UCKundenAnzeigen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UCKundenAnzeigen_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_kunden;
        private System.Windows.Forms.ColumnHeader kundenid;
        private System.Windows.Forms.ColumnHeader vorname;
        private System.Windows.Forms.ColumnHeader nachname;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bn_delete;
        private System.Windows.Forms.Button bn_edit;
        private System.Windows.Forms.Button bn_new;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader adresse;
        private System.Windows.Forms.ColumnHeader hausnummer;
        private System.Windows.Forms.ColumnHeader plz;
        private System.Windows.Forms.ColumnHeader ort;
        private System.Windows.Forms.TextBox tb_search;
    }
}
