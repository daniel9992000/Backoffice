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
            this.kontakteAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.angeboteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alleAngeboteAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projekteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stundenEinlesenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechnungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechnungenAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eingangsrechnungenAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.berichteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prognostizierterJahresumsatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktuelleEinnahmenAusgabenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offeneRechnungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offeneProjekteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stundensatzProjektToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ucEingangAnzeigen1 = new Backoffice.UserControls.UCEingangAnzeigen();
            this.ucStundensatzAnzeigen1 = new Backoffice.UserControls.UCStundensatzAnzeigen();
            this.ucOffeneRechnungenAnzeigen1 = new Backoffice.UserControls.UCOffeneRechnungenAnzeigen();
            this.ucOffeneProjekteAnzeigen1 = new Backoffice.Dialogs.UCOffeneProjekteAnzeigen();
            this.ucEinahmenAusgabenAnzeigen1 = new Backoffice.UserControls.UCEinahmenAusgabenAnzeigen();
            this.ucJahresumsatzAnzeigen1 = new Backoffice.UserControls.UCJahresumsatzAnzeigen();
            this.ucRechnungenAnzeigen1 = new Backoffice.UserControls.UCRechnungenAnzeigen();
            this.ucKontakteAnzeigen1 = new Backoffice.UserControls.UCKontakteAnzeigen();
            this.ucAngeboteAnzeigen1 = new Backoffice.UserControls.UCAngeboteAnzeigen();
            this.ucProjekteAnzeigen1 = new Backoffice.UserControls.UCProjekteAnzeigen();
            this.uc_kundenAnzeigen = new Backoffice.UserControls.UCKundenAnzeigen();
            this.ucStundenEinlesenAnzeigen1 = new Backoffice.Dialogs.UCStundenEinlesenAnzeigen();
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
            this.kontakteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kontakteAnzeigenToolStripMenuItem});
            this.kontakteToolStripMenuItem.Name = "kontakteToolStripMenuItem";
            this.kontakteToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.kontakteToolStripMenuItem.Text = "Kontakte";
            // 
            // kontakteAnzeigenToolStripMenuItem
            // 
            this.kontakteAnzeigenToolStripMenuItem.Name = "kontakteAnzeigenToolStripMenuItem";
            this.kontakteAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.kontakteAnzeigenToolStripMenuItem.Text = "Kontakte anzeigen";
            this.kontakteAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.kontakteAnzeigenToolStripMenuItem_Click);
            // 
            // angeboteToolStripMenuItem
            // 
            this.angeboteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alleAngeboteAnzeigenToolStripMenuItem});
            this.angeboteToolStripMenuItem.Name = "angeboteToolStripMenuItem";
            this.angeboteToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.angeboteToolStripMenuItem.Text = "Angebote";
            // 
            // alleAngeboteAnzeigenToolStripMenuItem
            // 
            this.alleAngeboteAnzeigenToolStripMenuItem.Name = "alleAngeboteAnzeigenToolStripMenuItem";
            this.alleAngeboteAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.alleAngeboteAnzeigenToolStripMenuItem.Text = "Angebote anzeigen";
            this.alleAngeboteAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.alleAngeboteAnzeigenToolStripMenuItem_Click);
            // 
            // projekteToolStripMenuItem
            // 
            this.projekteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projektAnzeigenToolStripMenuItem,
            this.stundenEinlesenToolStripMenuItem});
            this.projekteToolStripMenuItem.Name = "projekteToolStripMenuItem";
            this.projekteToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.projekteToolStripMenuItem.Text = "Projekte";
            this.projekteToolStripMenuItem.Click += new System.EventHandler(this.projekteToolStripMenuItem_Click);
            // 
            // projektAnzeigenToolStripMenuItem
            // 
            this.projektAnzeigenToolStripMenuItem.Name = "projektAnzeigenToolStripMenuItem";
            this.projektAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.projektAnzeigenToolStripMenuItem.Text = "Projekt anzeigen";
            this.projektAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.projektAnzeigenToolStripMenuItem_Click);
            // 
            // stundenEinlesenToolStripMenuItem
            // 
            this.stundenEinlesenToolStripMenuItem.Name = "stundenEinlesenToolStripMenuItem";
            this.stundenEinlesenToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.stundenEinlesenToolStripMenuItem.Text = "Stunden einlesen";
            this.stundenEinlesenToolStripMenuItem.Click += new System.EventHandler(this.stundenEinlesenToolStripMenuItem_Click);
            // 
            // rechnungenToolStripMenuItem
            // 
            this.rechnungenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechnungenAnzeigenToolStripMenuItem,
            this.eingangsrechnungenAnzeigenToolStripMenuItem});
            this.rechnungenToolStripMenuItem.Name = "rechnungenToolStripMenuItem";
            this.rechnungenToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.rechnungenToolStripMenuItem.Text = "Rechnungen";
            // 
            // rechnungenAnzeigenToolStripMenuItem
            // 
            this.rechnungenAnzeigenToolStripMenuItem.Name = "rechnungenAnzeigenToolStripMenuItem";
            this.rechnungenAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.rechnungenAnzeigenToolStripMenuItem.Text = "Ausgangsrechnungen anzeigen";
            this.rechnungenAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.rechnungenAnzeigenToolStripMenuItem_Click);
            // 
            // eingangsrechnungenAnzeigenToolStripMenuItem
            // 
            this.eingangsrechnungenAnzeigenToolStripMenuItem.Name = "eingangsrechnungenAnzeigenToolStripMenuItem";
            this.eingangsrechnungenAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.eingangsrechnungenAnzeigenToolStripMenuItem.Text = "Eingangsrechnungen anzeigen";
            this.eingangsrechnungenAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.eingangsrechnungenAnzeigenToolStripMenuItem_Click);
            // 
            // berichteToolStripMenuItem
            // 
            this.berichteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prognostizierterJahresumsatToolStripMenuItem,
            this.aktuelleEinnahmenAusgabenToolStripMenuItem,
            this.offeneRechnungenToolStripMenuItem,
            this.offeneProjekteToolStripMenuItem,
            this.stundensatzProjektToolStripMenuItem});
            this.berichteToolStripMenuItem.Name = "berichteToolStripMenuItem";
            this.berichteToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.berichteToolStripMenuItem.Text = "Berichte";
            // 
            // prognostizierterJahresumsatToolStripMenuItem
            // 
            this.prognostizierterJahresumsatToolStripMenuItem.Name = "prognostizierterJahresumsatToolStripMenuItem";
            this.prognostizierterJahresumsatToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.prognostizierterJahresumsatToolStripMenuItem.Text = "Prognostizierter Jahresumsatz";
            this.prognostizierterJahresumsatToolStripMenuItem.Click += new System.EventHandler(this.prognostizierterJahresumsatToolStripMenuItem_Click);
            // 
            // aktuelleEinnahmenAusgabenToolStripMenuItem
            // 
            this.aktuelleEinnahmenAusgabenToolStripMenuItem.Name = "aktuelleEinnahmenAusgabenToolStripMenuItem";
            this.aktuelleEinnahmenAusgabenToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.aktuelleEinnahmenAusgabenToolStripMenuItem.Text = "Aktuelle Einnahmen/Ausgaben";
            this.aktuelleEinnahmenAusgabenToolStripMenuItem.Click += new System.EventHandler(this.aktuelleEinnahmenAusgabenToolStripMenuItem_Click);
            // 
            // offeneRechnungenToolStripMenuItem
            // 
            this.offeneRechnungenToolStripMenuItem.Name = "offeneRechnungenToolStripMenuItem";
            this.offeneRechnungenToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.offeneRechnungenToolStripMenuItem.Text = "Offene Rechnungen";
            this.offeneRechnungenToolStripMenuItem.Click += new System.EventHandler(this.offeneRechnungenToolStripMenuItem_Click);
            // 
            // offeneProjekteToolStripMenuItem
            // 
            this.offeneProjekteToolStripMenuItem.Name = "offeneProjekteToolStripMenuItem";
            this.offeneProjekteToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.offeneProjekteToolStripMenuItem.Text = "Offene Projekte";
            this.offeneProjekteToolStripMenuItem.Click += new System.EventHandler(this.offeneProjekteToolStripMenuItem_Click);
            // 
            // stundensatzProjektToolStripMenuItem
            // 
            this.stundensatzProjektToolStripMenuItem.Name = "stundensatzProjektToolStripMenuItem";
            this.stundensatzProjektToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.stundensatzProjektToolStripMenuItem.Text = "Stundensatz/Projekt";
            this.stundensatzProjektToolStripMenuItem.Click += new System.EventHandler(this.stundensatzProjektToolStripMenuItem_Click);
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
            // ucEingangAnzeigen1
            // 
            this.ucEingangAnzeigen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEingangAnzeigen1.Location = new System.Drawing.Point(0, 24);
            this.ucEingangAnzeigen1.Name = "ucEingangAnzeigen1";
            this.ucEingangAnzeigen1.Size = new System.Drawing.Size(933, 491);
            this.ucEingangAnzeigen1.TabIndex = 11;
            // 
            // ucStundensatzAnzeigen1
            // 
            this.ucStundensatzAnzeigen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucStundensatzAnzeigen1.Location = new System.Drawing.Point(0, 24);
            this.ucStundensatzAnzeigen1.Name = "ucStundensatzAnzeigen1";
            this.ucStundensatzAnzeigen1.Size = new System.Drawing.Size(933, 491);
            this.ucStundensatzAnzeigen1.TabIndex = 10;
            // 
            // ucOffeneRechnungenAnzeigen1
            // 
            this.ucOffeneRechnungenAnzeigen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOffeneRechnungenAnzeigen1.Location = new System.Drawing.Point(0, 24);
            this.ucOffeneRechnungenAnzeigen1.Name = "ucOffeneRechnungenAnzeigen1";
            this.ucOffeneRechnungenAnzeigen1.Size = new System.Drawing.Size(933, 491);
            this.ucOffeneRechnungenAnzeigen1.TabIndex = 9;
            // 
            // ucOffeneProjekteAnzeigen1
            // 
            this.ucOffeneProjekteAnzeigen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOffeneProjekteAnzeigen1.Location = new System.Drawing.Point(0, 24);
            this.ucOffeneProjekteAnzeigen1.Name = "ucOffeneProjekteAnzeigen1";
            this.ucOffeneProjekteAnzeigen1.Size = new System.Drawing.Size(933, 491);
            this.ucOffeneProjekteAnzeigen1.TabIndex = 8;
            // 
            // ucEinahmenAusgabenAnzeigen1
            // 
            this.ucEinahmenAusgabenAnzeigen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEinahmenAusgabenAnzeigen1.Location = new System.Drawing.Point(0, 24);
            this.ucEinahmenAusgabenAnzeigen1.Name = "ucEinahmenAusgabenAnzeigen1";
            this.ucEinahmenAusgabenAnzeigen1.Size = new System.Drawing.Size(933, 491);
            this.ucEinahmenAusgabenAnzeigen1.TabIndex = 7;
            // 
            // ucJahresumsatzAnzeigen1
            // 
            this.ucJahresumsatzAnzeigen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucJahresumsatzAnzeigen1.Location = new System.Drawing.Point(0, 24);
            this.ucJahresumsatzAnzeigen1.Name = "ucJahresumsatzAnzeigen1";
            this.ucJahresumsatzAnzeigen1.Size = new System.Drawing.Size(933, 491);
            this.ucJahresumsatzAnzeigen1.TabIndex = 6;
            // 
            // ucRechnungenAnzeigen1
            // 
            this.ucRechnungenAnzeigen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRechnungenAnzeigen1.Location = new System.Drawing.Point(0, 24);
            this.ucRechnungenAnzeigen1.Name = "ucRechnungenAnzeigen1";
            this.ucRechnungenAnzeigen1.Size = new System.Drawing.Size(933, 491);
            this.ucRechnungenAnzeigen1.TabIndex = 5;
            // 
            // ucKontakteAnzeigen1
            // 
            this.ucKontakteAnzeigen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucKontakteAnzeigen1.Location = new System.Drawing.Point(0, 24);
            this.ucKontakteAnzeigen1.Name = "ucKontakteAnzeigen1";
            this.ucKontakteAnzeigen1.Padding = new System.Windows.Forms.Padding(10);
            this.ucKontakteAnzeigen1.Size = new System.Drawing.Size(933, 491);
            this.ucKontakteAnzeigen1.TabIndex = 4;
            // 
            // ucAngeboteAnzeigen1
            // 
            this.ucAngeboteAnzeigen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAngeboteAnzeigen1.Location = new System.Drawing.Point(0, 24);
            this.ucAngeboteAnzeigen1.Name = "ucAngeboteAnzeigen1";
            this.ucAngeboteAnzeigen1.Padding = new System.Windows.Forms.Padding(10);
            this.ucAngeboteAnzeigen1.Size = new System.Drawing.Size(933, 491);
            this.ucAngeboteAnzeigen1.TabIndex = 3;
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
            // ucStundenEinlesenAnzeigen1
            // 
            this.ucStundenEinlesenAnzeigen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucStundenEinlesenAnzeigen1.Location = new System.Drawing.Point(0, 24);
            this.ucStundenEinlesenAnzeigen1.Name = "ucStundenEinlesenAnzeigen1";
            this.ucStundenEinlesenAnzeigen1.Size = new System.Drawing.Size(933, 491);
            this.ucStundenEinlesenAnzeigen1.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 515);
            this.Controls.Add(this.ucStundenEinlesenAnzeigen1);
            this.Controls.Add(this.ucEingangAnzeigen1);
            this.Controls.Add(this.ucStundensatzAnzeigen1);
            this.Controls.Add(this.ucOffeneRechnungenAnzeigen1);
            this.Controls.Add(this.ucOffeneProjekteAnzeigen1);
            this.Controls.Add(this.ucEinahmenAusgabenAnzeigen1);
            this.Controls.Add(this.ucJahresumsatzAnzeigen1);
            this.Controls.Add(this.ucRechnungenAnzeigen1);
            this.Controls.Add(this.ucKontakteAnzeigen1);
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
        private System.Windows.Forms.ToolStripMenuItem projektAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontakteAnzeigenToolStripMenuItem;
        private UserControls.UCKontakteAnzeigen ucKontakteAnzeigen1;
        private UserControls.UCRechnungenAnzeigen ucRechnungenAnzeigen1;
        private System.Windows.Forms.ToolStripMenuItem rechnungenAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prognostizierterJahresumsatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktuelleEinnahmenAusgabenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offeneRechnungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offeneProjekteToolStripMenuItem;
        private UserControls.UCJahresumsatzAnzeigen ucJahresumsatzAnzeigen1;
        private UserControls.UCEinahmenAusgabenAnzeigen ucEinahmenAusgabenAnzeigen1;
        private Dialogs.UCOffeneProjekteAnzeigen ucOffeneProjekteAnzeigen1;
        private UserControls.UCOffeneRechnungenAnzeigen ucOffeneRechnungenAnzeigen1;
        private System.Windows.Forms.ToolStripMenuItem stundensatzProjektToolStripMenuItem;
        private UserControls.UCStundensatzAnzeigen ucStundensatzAnzeigen1;
        private UserControls.UCEingangAnzeigen ucEingangAnzeigen1;
        private System.Windows.Forms.ToolStripMenuItem eingangsrechnungenAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stundenEinlesenToolStripMenuItem;
        private Dialogs.UCStundenEinlesenAnzeigen ucStundenEinlesenAnzeigen1;


    }
}

