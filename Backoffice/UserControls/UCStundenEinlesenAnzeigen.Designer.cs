namespace Backoffice.Dialogs
{
    partial class UCStundenEinlesenAnzeigen
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
            this.cb_projekt = new System.Windows.Forms.ComboBox();
            this.errorControl1 = new Backoffice.DataBinding.ErrorControl();
            this.label1 = new System.Windows.Forms.Label();
            this.bnnew = new System.Windows.Forms.Button();
            this.lv_stunden = new System.Windows.Forms.ListView();
            this.projektname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mitarbeiter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stunden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oFD = new System.Windows.Forms.OpenFileDialog();
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
            this.splitContainer1.Panel1.Controls.Add(this.cb_projekt);
            this.splitContainer1.Panel1.Controls.Add(this.errorControl1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.bnnew);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lv_stunden);
            this.splitContainer1.Size = new System.Drawing.Size(1035, 470);
            this.splitContainer1.SplitterDistance = 93;
            this.splitContainer1.TabIndex = 0;
            // 
            // cb_projekt
            // 
            this.cb_projekt.FormattingEnabled = true;
            this.cb_projekt.Location = new System.Drawing.Point(445, 38);
            this.cb_projekt.Name = "cb_projekt";
            this.cb_projekt.Size = new System.Drawing.Size(121, 21);
            this.cb_projekt.TabIndex = 3;
            this.cb_projekt.SelectedIndexChanged += new System.EventHandler(this.cb_projekt_SelectedIndexChanged);
            // 
            // errorControl1
            // 
            this.errorControl1.AutoSize = true;
            this.errorControl1.Location = new System.Drawing.Point(593, 46);
            this.errorControl1.Name = "errorControl1";
            this.errorControl1.Size = new System.Drawing.Size(67, 13);
            this.errorControl1.TabIndex = 2;
            this.errorControl1.Text = "errorControl1";
            this.errorControl1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Projekt wählen";
            // 
            // bnnew
            // 
            this.bnnew.Location = new System.Drawing.Point(81, 30);
            this.bnnew.Name = "bnnew";
            this.bnnew.Size = new System.Drawing.Size(142, 45);
            this.bnnew.TabIndex = 0;
            this.bnnew.Text = "Neue Stunden einlesen";
            this.bnnew.UseVisualStyleBackColor = true;
            this.bnnew.Click += new System.EventHandler(this.bnnew_Click);
            // 
            // lv_stunden
            // 
            this.lv_stunden.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.projektname,
            this.Mitarbeiter,
            this.Stunden,
            this.Datum});
            this.lv_stunden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_stunden.GridLines = true;
            this.lv_stunden.Location = new System.Drawing.Point(0, 0);
            this.lv_stunden.Name = "lv_stunden";
            this.lv_stunden.Size = new System.Drawing.Size(1035, 373);
            this.lv_stunden.TabIndex = 0;
            this.lv_stunden.UseCompatibleStateImageBehavior = false;
            this.lv_stunden.View = System.Windows.Forms.View.Details;
            // 
            // projektname
            // 
            this.projektname.Text = "Projektname";
            this.projektname.Width = 234;
            // 
            // Mitarbeiter
            // 
            this.Mitarbeiter.Text = "Mitarbeiter";
            this.Mitarbeiter.Width = 241;
            // 
            // Stunden
            // 
            this.Stunden.Text = "Stunden";
            this.Stunden.Width = 201;
            // 
            // Datum
            // 
            this.Datum.Text = "datum";
            this.Datum.Width = 152;
            // 
            // oFD
            // 
            this.oFD.FileName = "openFileDialog1";
            // 
            // UCStundenEinlesenAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCStundenEinlesenAnzeigen";
            this.Size = new System.Drawing.Size(1035, 470);
            this.Load += new System.EventHandler(this.UCStundenEinlesenAnzeigen_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cb_projekt;
        private DataBinding.ErrorControl errorControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnnew;
        private System.Windows.Forms.ListView lv_stunden;
        private System.Windows.Forms.ColumnHeader projektname;
        private System.Windows.Forms.ColumnHeader Mitarbeiter;
        private System.Windows.Forms.ColumnHeader Stunden;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.OpenFileDialog oFD;
    }
}
