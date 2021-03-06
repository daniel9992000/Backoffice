﻿namespace Backoffice.UserControls
{
    partial class UCBuchungenAnzeigen
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
            this.bn_delete = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bn_edit = new System.Windows.Forms.Button();
            this.bn_new = new System.Windows.Forms.Button();
            this.lv_buchungen = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.bn_delete);
            this.splitContainer1.Panel1.Controls.Add(this.bn_edit);
            this.splitContainer1.Panel1.Controls.Add(this.bn_new);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lv_buchungen);
            this.splitContainer1.Size = new System.Drawing.Size(698, 429);
            this.splitContainer1.SplitterDistance = 31;
            this.splitContainer1.TabIndex = 3;
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
            // lv_buchungen
            // 
            this.lv_buchungen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_buchungen.Location = new System.Drawing.Point(0, 0);
            this.lv_buchungen.Name = "lv_buchungen";
            this.lv_buchungen.Size = new System.Drawing.Size(698, 394);
            this.lv_buchungen.TabIndex = 0;
            this.lv_buchungen.UseCompatibleStateImageBehavior = false;
            this.lv_buchungen.DoubleClick += new System.EventHandler(this.lv_buchungen_DoubleClick);
            // 
            // UCBuchungenAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCBuchungenAnzeigen";
            this.Size = new System.Drawing.Size(698, 429);
            this.Load += new System.EventHandler(this.UCBuchungenAnzeigen_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bn_delete;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bn_edit;
        private System.Windows.Forms.Button bn_new;
        private System.Windows.Forms.ListView lv_buchungen;
    }
}
