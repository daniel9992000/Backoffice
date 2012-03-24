namespace Backoffice.Dialogs
{
    partial class AngebotDetail
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
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.bn_save = new System.Windows.Forms.Button();
            this.bn_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_angebotid = new System.Windows.Forms.TextBox();
            this.tb_titel = new System.Windows.Forms.TextBox();
            this.tb_dauer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_datum = new System.Windows.Forms.DateTimePicker();
            this.tb_summe = new System.Windows.Forms.TextBox();
            this.tb_chance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.label6);
            this.gb1.Controls.Add(this.label5);
            this.gb1.Controls.Add(this.tb_chance);
            this.gb1.Controls.Add(this.tb_summe);
            this.gb1.Controls.Add(this.dtp_datum);
            this.gb1.Controls.Add(this.label4);
            this.gb1.Controls.Add(this.tb_dauer);
            this.gb1.Controls.Add(this.tb_titel);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.tb_angebotid);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Location = new System.Drawing.Point(12, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(315, 195);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "Angebot";
            // 
            // bn_save
            // 
            this.bn_save.Location = new System.Drawing.Point(12, 334);
            this.bn_save.Name = "bn_save";
            this.bn_save.Size = new System.Drawing.Size(75, 23);
            this.bn_save.TabIndex = 1;
            this.bn_save.Text = "Speichern";
            this.bn_save.UseVisualStyleBackColor = true;
            this.bn_save.Click += new System.EventHandler(this.bn_save_Click);
            // 
            // bn_cancel
            // 
            this.bn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bn_cancel.Location = new System.Drawing.Point(93, 334);
            this.bn_cancel.Name = "bn_cancel";
            this.bn_cancel.Size = new System.Drawing.Size(75, 23);
            this.bn_cancel.TabIndex = 2;
            this.bn_cancel.Text = "Abbrechen";
            this.bn_cancel.UseVisualStyleBackColor = true;
            this.bn_cancel.Click += new System.EventHandler(this.bn_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Titel";
            // 
            // tb_angebotid
            // 
            this.tb_angebotid.Enabled = false;
            this.tb_angebotid.Location = new System.Drawing.Point(81, 28);
            this.tb_angebotid.Name = "tb_angebotid";
            this.tb_angebotid.Size = new System.Drawing.Size(44, 20);
            this.tb_angebotid.TabIndex = 3;
            // 
            // tb_titel
            // 
            this.tb_titel.Location = new System.Drawing.Point(81, 54);
            this.tb_titel.Name = "tb_titel";
            this.tb_titel.Size = new System.Drawing.Size(127, 20);
            this.tb_titel.TabIndex = 4;
            // 
            // tb_dauer
            // 
            this.tb_dauer.Location = new System.Drawing.Point(81, 106);
            this.tb_dauer.Name = "tb_dauer";
            this.tb_dauer.Size = new System.Drawing.Size(44, 20);
            this.tb_dauer.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dauer";
            // 
            // dtp_datum
            // 
            this.dtp_datum.Location = new System.Drawing.Point(81, 80);
            this.dtp_datum.Name = "dtp_datum";
            this.dtp_datum.Size = new System.Drawing.Size(200, 20);
            this.dtp_datum.TabIndex = 8;
            // 
            // tb_summe
            // 
            this.tb_summe.Location = new System.Drawing.Point(81, 132);
            this.tb_summe.Name = "tb_summe";
            this.tb_summe.Size = new System.Drawing.Size(95, 20);
            this.tb_summe.TabIndex = 9;
            // 
            // tb_chance
            // 
            this.tb_chance.Location = new System.Drawing.Point(81, 158);
            this.tb_chance.Name = "tb_chance";
            this.tb_chance.Size = new System.Drawing.Size(44, 20);
            this.tb_chance.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Summe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Chance";
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.comboBox1);
            this.gb2.Location = new System.Drawing.Point(12, 213);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(315, 100);
            this.gb2.TabIndex = 3;
            this.gb2.TabStop = false;
            this.gb2.Text = "Kunde";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(303, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // AngebotDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 368);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.bn_cancel);
            this.Controls.Add(this.bn_save);
            this.Controls.Add(this.gb1);
            this.Name = "AngebotDetail";
            this.Text = "AngebotDetail";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button bn_save;
        private System.Windows.Forms.Button bn_cancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_chance;
        private System.Windows.Forms.TextBox tb_summe;
        private System.Windows.Forms.DateTimePicker dtp_datum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_dauer;
        private System.Windows.Forms.TextBox tb_titel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_angebotid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}