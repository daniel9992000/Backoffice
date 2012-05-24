namespace Backoffice.Dialogs
{
    partial class ProjekteDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorControl1 = new Backoffice.DataBinding.ErrorControl();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bn_save = new System.Windows.Forms.Button();
            this.bn_cancel = new System.Windows.Forms.Button();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.lv_angebote = new System.Windows.Forms.ListView();
            this.gb3 = new System.Windows.Forms.GroupBox();
            this.lv_rechungen = new System.Windows.Forms.ListView();
            this.gb4 = new System.Windows.Forms.GroupBox();
            this.lv_stunden = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.gb3.SuspendLayout();
            this.gb4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.errorControl1);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.tb_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Allgemein";
            // 
            // errorControl1
            // 
            this.errorControl1.AutoSize = true;
            this.errorControl1.Location = new System.Drawing.Point(201, 51);
            this.errorControl1.Name = "errorControl1";
            this.errorControl1.Size = new System.Drawing.Size(0, 13);
            this.errorControl1.TabIndex = 4;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(95, 48);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 20);
            this.tb_name.TabIndex = 3;
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(95, 22);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(50, 20);
            this.tb_id.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Projektname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // bn_save
            // 
            this.bn_save.Location = new System.Drawing.Point(15, 448);
            this.bn_save.Name = "bn_save";
            this.bn_save.Size = new System.Drawing.Size(75, 23);
            this.bn_save.TabIndex = 1;
            this.bn_save.Text = "Speichern";
            this.bn_save.UseVisualStyleBackColor = true;
            this.bn_save.Click += new System.EventHandler(this.bn_save_Click_1);
            // 
            // bn_cancel
            // 
            this.bn_cancel.Location = new System.Drawing.Point(96, 448);
            this.bn_cancel.Name = "bn_cancel";
            this.bn_cancel.Size = new System.Drawing.Size(75, 23);
            this.bn_cancel.TabIndex = 2;
            this.bn_cancel.Text = "Abbrechen";
            this.bn_cancel.UseVisualStyleBackColor = true;
            this.bn_cancel.Click += new System.EventHandler(this.bn_cancel_Click);
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.lv_angebote);
            this.gb2.Location = new System.Drawing.Point(12, 112);
            this.gb2.Name = "gb2";
            this.gb2.Padding = new System.Windows.Forms.Padding(5);
            this.gb2.Size = new System.Drawing.Size(442, 162);
            this.gb2.TabIndex = 3;
            this.gb2.TabStop = false;
            this.gb2.Text = "Angebote";
            // 
            // lv_angebote
            // 
            this.lv_angebote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_angebote.Location = new System.Drawing.Point(5, 18);
            this.lv_angebote.Name = "lv_angebote";
            this.lv_angebote.Size = new System.Drawing.Size(432, 139);
            this.lv_angebote.TabIndex = 0;
            this.lv_angebote.UseCompatibleStateImageBehavior = false;
            this.lv_angebote.View = System.Windows.Forms.View.Details;
            // 
            // gb3
            // 
            this.gb3.Controls.Add(this.lv_rechungen);
            this.gb3.Location = new System.Drawing.Point(12, 280);
            this.gb3.Name = "gb3";
            this.gb3.Padding = new System.Windows.Forms.Padding(5);
            this.gb3.Size = new System.Drawing.Size(437, 162);
            this.gb3.TabIndex = 4;
            this.gb3.TabStop = false;
            this.gb3.Text = "Rechnungen";
            // 
            // lv_rechungen
            // 
            this.lv_rechungen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_rechungen.Location = new System.Drawing.Point(5, 18);
            this.lv_rechungen.Name = "lv_rechungen";
            this.lv_rechungen.Size = new System.Drawing.Size(427, 139);
            this.lv_rechungen.TabIndex = 0;
            this.lv_rechungen.UseCompatibleStateImageBehavior = false;
            this.lv_rechungen.View = System.Windows.Forms.View.Details;
            // 
            // gb4
            // 
            this.gb4.Controls.Add(this.lv_stunden);
            this.gb4.Location = new System.Drawing.Point(460, 12);
            this.gb4.Name = "gb4";
            this.gb4.Padding = new System.Windows.Forms.Padding(5);
            this.gb4.Size = new System.Drawing.Size(407, 430);
            this.gb4.TabIndex = 4;
            this.gb4.TabStop = false;
            this.gb4.Text = "Stunden";
            // 
            // lv_stunden
            // 
            this.lv_stunden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_stunden.Location = new System.Drawing.Point(5, 18);
            this.lv_stunden.Name = "lv_stunden";
            this.lv_stunden.Size = new System.Drawing.Size(397, 407);
            this.lv_stunden.TabIndex = 0;
            this.lv_stunden.UseCompatibleStateImageBehavior = false;
            this.lv_stunden.View = System.Windows.Forms.View.Details;
            // 
            // ProjekteDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 480);
            this.Controls.Add(this.gb4);
            this.Controls.Add(this.gb3);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.bn_cancel);
            this.Controls.Add(this.bn_save);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProjekteDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjekteDetail";
            this.Load += new System.EventHandler(this.ProjekteDetail_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb3.ResumeLayout(false);
            this.gb4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bn_save;
        private System.Windows.Forms.Button bn_cancel;
        private DataBinding.ErrorControl errorControl1;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.ListView lv_angebote;
        private System.Windows.Forms.GroupBox gb3;
        private System.Windows.Forms.ListView lv_rechungen;
        private System.Windows.Forms.GroupBox gb4;
        private System.Windows.Forms.ListView lv_stunden;
    }
}