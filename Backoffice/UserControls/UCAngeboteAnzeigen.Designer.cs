namespace Backoffice.UserControls
{
    partial class UCAngeboteAnzeigen
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
            this.bn_delete = new System.Windows.Forms.Button();
            this.bn_edit = new System.Windows.Forms.Button();
            this.bn_new = new System.Windows.Forms.Button();
            this.lv_angebote = new System.Windows.Forms.ListView();
            this.angebotid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dauer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.summe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
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
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lv_angebote);
            this.splitContainer1.Size = new System.Drawing.Size(771, 532);
            this.splitContainer1.SplitterDistance = 29;
            this.splitContainer1.TabIndex = 0;
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
            // lv_angebote
            // 
            this.lv_angebote.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.angebotid,
            this.titel,
            this.datum,
            this.dauer,
            this.summe,
            this.chance});
            this.lv_angebote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_angebote.FullRowSelect = true;
            this.lv_angebote.GridLines = true;
            this.lv_angebote.Location = new System.Drawing.Point(0, 0);
            this.lv_angebote.Name = "lv_angebote";
            this.lv_angebote.Size = new System.Drawing.Size(771, 499);
            this.lv_angebote.TabIndex = 0;
            this.lv_angebote.UseCompatibleStateImageBehavior = false;
            this.lv_angebote.View = System.Windows.Forms.View.Details;
            this.lv_angebote.DoubleClick += new System.EventHandler(this.lv_angebote_DoubleClick);
            // 
            // angebotid
            // 
            this.angebotid.Text = "ID";
            this.angebotid.Width = 30;
            // 
            // titel
            // 
            this.titel.Text = "Titel";
            this.titel.Width = 100;
            // 
            // datum
            // 
            this.datum.Text = "Datum";
            this.datum.Width = 80;
            // 
            // dauer
            // 
            this.dauer.Text = "Dauer";
            this.dauer.Width = 50;
            // 
            // summe
            // 
            this.summe.Text = "Summe";
            // 
            // chance
            // 
            this.chance.Text = "Chance";
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(246, 5);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(188, 20);
            this.tb_search.TabIndex = 3;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // UCAngeboteAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCAngeboteAnzeigen";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(791, 552);
            this.Load += new System.EventHandler(this.UCAngeboteAnzeigen_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bn_delete;
        private System.Windows.Forms.Button bn_edit;
        private System.Windows.Forms.Button bn_new;
        private System.Windows.Forms.ListView lv_angebote;
        private System.Windows.Forms.ColumnHeader angebotid;
        private System.Windows.Forms.ColumnHeader datum;
        private System.Windows.Forms.ColumnHeader dauer;
        private System.Windows.Forms.ColumnHeader summe;
        private System.Windows.Forms.ColumnHeader chance;
        private System.Windows.Forms.ColumnHeader titel;
        private System.Windows.Forms.TextBox tb_search;
    }
}
