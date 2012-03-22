namespace Backoffice.UserControls
{
    partial class UCProjekteAnzeigen
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
            this.lv_projekte = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Projektname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bn_delete);
            this.splitContainer1.Panel1.Controls.Add(this.bn_edit);
            this.splitContainer1.Panel1.Controls.Add(this.bn_new);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lv_projekte);
            this.splitContainer1.Size = new System.Drawing.Size(384, 375);
            this.splitContainer1.SplitterDistance = 33;
            this.splitContainer1.TabIndex = 1;
            // 
            // bn_delete
            // 
            this.bn_delete.Location = new System.Drawing.Point(191, 3);
            this.bn_delete.Name = "bn_delete";
            this.bn_delete.Size = new System.Drawing.Size(75, 27);
            this.bn_delete.TabIndex = 2;
            this.bn_delete.Text = "Löschen";
            this.bn_delete.UseVisualStyleBackColor = true;
            this.bn_delete.Click += new System.EventHandler(this.bn_delete_Click_1);
            // 
            // bn_edit
            // 
            this.bn_edit.Location = new System.Drawing.Point(98, 3);
            this.bn_edit.Name = "bn_edit";
            this.bn_edit.Size = new System.Drawing.Size(75, 27);
            this.bn_edit.TabIndex = 1;
            this.bn_edit.Text = "Bearbeiten";
            this.bn_edit.UseVisualStyleBackColor = true;
            this.bn_edit.Click += new System.EventHandler(this.bn_edit_Click_1);
            // 
            // bn_new
            // 
            this.bn_new.Location = new System.Drawing.Point(3, 3);
            this.bn_new.Name = "bn_new";
            this.bn_new.Size = new System.Drawing.Size(79, 27);
            this.bn_new.TabIndex = 0;
            this.bn_new.Text = "Neu";
            this.bn_new.UseVisualStyleBackColor = true;
            this.bn_new.Click += new System.EventHandler(this.bn_new_Click_1);
            // 
            // lv_projekte
            // 
            this.lv_projekte.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Projektname});
            this.lv_projekte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_projekte.FullRowSelect = true;
            this.lv_projekte.GridLines = true;
            this.lv_projekte.Location = new System.Drawing.Point(0, 0);
            this.lv_projekte.Margin = new System.Windows.Forms.Padding(10);
            this.lv_projekte.Name = "lv_projekte";
            this.lv_projekte.Size = new System.Drawing.Size(384, 338);
            this.lv_projekte.TabIndex = 0;
            this.lv_projekte.UseCompatibleStateImageBehavior = false;
            this.lv_projekte.View = System.Windows.Forms.View.Details;
            this.lv_projekte.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_projekte_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Projektname
            // 
            this.Projektname.Text = "Projektname";
            this.Projektname.Width = 180;
            // 
            // UCProjekteAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCProjekteAnzeigen";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(404, 395);
            this.Load += new System.EventHandler(this.UCProjekteAnzeigen_Load_1);
            this.splitContainer1.Panel1.ResumeLayout(false);
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
        private System.Windows.Forms.ListView lv_projekte;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Projektname;
    }
}
