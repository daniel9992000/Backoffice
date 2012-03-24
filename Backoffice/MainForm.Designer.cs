namespace Backoffice
{
    partial class MainForm
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kundenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alleKundenAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuerKundeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontakteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.angeboteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projekteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechnungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.berichteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alleAngeboteAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucProjekteAnzeigen1 = new Backoffice.UserControls.UCProjekteAnzeigen();
            this.uc_kundenAnzeigen = new Backoffice.UserControls.UCKundenAnzeigen();
            this.ucAngeboteAnzeigen1 = new Backoffice.UserControls.UCAngeboteAnzeigen();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // kundenToolStripMenuItem
            // 
            this.kundenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alleKundenAnzeigenToolStripMenuItem,
            this.neuerKundeToolStripMenuItem});
            this.kundenToolStripMenuItem.Name = "kundenToolStripMenuItem";
            this.kundenToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.kundenToolStripMenuItem.Text = "Kunden";
            // 
            // alleKundenAnzeigenToolStripMenuItem
            // 
            this.alleKundenAnzeigenToolStripMenuItem.Name = "alleKundenAnzeigenToolStripMenuItem";
            this.alleKundenAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.alleKundenAnzeigenToolStripMenuItem.Text = "Kunden anzeigen";
            this.alleKundenAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.alleKundenAnzeigenToolStripMenuItem_Click);
            // 
            // neuerKundeToolStripMenuItem
            // 
            this.neuerKundeToolStripMenuItem.Name = "neuerKundeToolStripMenuItem";
            this.neuerKundeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.neuerKundeToolStripMenuItem.Text = "Neuer Kunde";
            this.neuerKundeToolStripMenuItem.Click += new System.EventHandler(this.neuerKundeToolStripMenuItem_Click);
            // 
            // kontakteToolStripMenuItem
            // 
            this.kontakteToolStripMenuItem.Name = "kontakteToolStripMenuItem";
            this.kontakteToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.kontakteToolStripMenuItem.Text = "Kontakte";
            // 
            // angeboteToolStripMenuItem
            // 
            this.angeboteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alleAngeboteAnzeigenToolStripMenuItem});
            this.angeboteToolStripMenuItem.Name = "angeboteToolStripMenuItem";
            this.angeboteToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.angeboteToolStripMenuItem.Text = "Angebote";
            // 
            // projekteToolStripMenuItem
            // 
            this.projekteToolStripMenuItem.Name = "projekteToolStripMenuItem";
            this.projekteToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.projekteToolStripMenuItem.Text = "Projekte";
            this.projekteToolStripMenuItem.Click += new System.EventHandler(this.projekteToolStripMenuItem_Click);
            // 
            // rechnungenToolStripMenuItem
            // 
            this.rechnungenToolStripMenuItem.Name = "rechnungenToolStripMenuItem";
            this.rechnungenToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.rechnungenToolStripMenuItem.Text = "Rechnungen";
            // 
            // berichteToolStripMenuItem
            // 
            this.berichteToolStripMenuItem.Name = "berichteToolStripMenuItem";
            this.berichteToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.berichteToolStripMenuItem.Text = "Berichte";
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            this.hilfeToolStripMenuItem.Click += new System.EventHandler(this.hilfeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.kundenToolStripMenuItem,
            this.kontakteToolStripMenuItem,
            this.angeboteToolStripMenuItem,
            this.projekteToolStripMenuItem,
            this.rechnungenToolStripMenuItem,
            this.berichteToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alleAngeboteAnzeigenToolStripMenuItem
            // 
            this.alleAngeboteAnzeigenToolStripMenuItem.Name = "alleAngeboteAnzeigenToolStripMenuItem";
            this.alleAngeboteAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.alleAngeboteAnzeigenToolStripMenuItem.Text = "Angebote anzeigen";
            this.alleAngeboteAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.alleAngeboteAnzeigenToolStripMenuItem_Click);
            // 
            // ucProjekteAnzeigen1
            // 
            this.ucProjekteAnzeigen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProjekteAnzeigen1.Location = new System.Drawing.Point(0, 24);
            this.ucProjekteAnzeigen1.Name = "ucProjekteAnzeigen1";
            this.ucProjekteAnzeigen1.Padding = new System.Windows.Forms.Padding(10);
            this.ucProjekteAnzeigen1.Size = new System.Drawing.Size(933, 491);
            this.ucProjekteAnzeigen1.TabIndex = 2;
            // 
            // uc_kundenAnzeigen
            // 
            this.uc_kundenAnzeigen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_kundenAnzeigen.Location = new System.Drawing.Point(0, 24);
            this.uc_kundenAnzeigen.Name = "uc_kundenAnzeigen";
            this.uc_kundenAnzeigen.Padding = new System.Windows.Forms.Padding(10);
            this.uc_kundenAnzeigen.Size = new System.Drawing.Size(933, 491);
            this.uc_kundenAnzeigen.TabIndex = 1;
            // 
            // ucAngeboteAnzeigen1
            // 
            this.ucAngeboteAnzeigen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAngeboteAnzeigen1.Location = new System.Drawing.Point(0, 24);
            this.ucAngeboteAnzeigen1.Name = "ucAngeboteAnzeigen1";
            this.ucAngeboteAnzeigen1.Size = new System.Drawing.Size(933, 491);
            this.ucAngeboteAnzeigen1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 515);
            this.Controls.Add(this.ucAngeboteAnzeigen1);
            this.Controls.Add(this.ucProjekteAnzeigen1);
            this.Controls.Add(this.uc_kundenAnzeigen);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Backoffice";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kundenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alleKundenAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontakteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem angeboteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projekteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechnungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem berichteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private UserControls.UCKundenAnzeigen uc_kundenAnzeigen;
        private System.Windows.Forms.ToolStripMenuItem neuerKundeToolStripMenuItem;
        private UserControls.UCProjekteAnzeigen ucProjekteAnzeigen1;
        private System.Windows.Forms.ToolStripMenuItem alleAngeboteAnzeigenToolStripMenuItem;
        private UserControls.UCAngeboteAnzeigen ucAngeboteAnzeigen1;


    }
}

