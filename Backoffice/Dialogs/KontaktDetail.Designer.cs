namespace Backoffice.Dialogs
{
    partial class KontaktDetail
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
            this.bnsave = new System.Windows.Forms.Button();
            this.bncancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_firmenname = new System.Windows.Forms.TextBox();
            this.tb_vorname = new System.Windows.Forms.TextBox();
            this.tb_nachname = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_nachname);
            this.groupBox1.Controls.Add(this.tb_vorname);
            this.groupBox1.Controls.Add(this.tb_firmenname);
            this.groupBox1.Controls.Add(this.tb_id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Allgmein";
            // 
            // bnsave
            // 
            this.bnsave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bnsave.Location = new System.Drawing.Point(168, 259);
            this.bnsave.Name = "bnsave";
            this.bnsave.Size = new System.Drawing.Size(88, 31);
            this.bnsave.TabIndex = 1;
            this.bnsave.Text = "Speichern";
            this.bnsave.UseVisualStyleBackColor = true;
            this.bnsave.Click += new System.EventHandler(this.bnsave_Click);
            // 
            // bncancel
            // 
            this.bncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bncancel.Location = new System.Drawing.Point(280, 259);
            this.bncancel.Name = "bncancel";
            this.bncancel.Size = new System.Drawing.Size(88, 31);
            this.bncancel.TabIndex = 2;
            this.bncancel.Text = "Abbrechen";
            this.bncancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firmenname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vorname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nachname";
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(165, 20);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(39, 20);
            this.tb_id.TabIndex = 4;
            // 
            // tb_firmenname
            // 
            this.tb_firmenname.Location = new System.Drawing.Point(165, 49);
            this.tb_firmenname.Name = "tb_firmenname";
            this.tb_firmenname.Size = new System.Drawing.Size(100, 20);
            this.tb_firmenname.TabIndex = 5;
            // 
            // tb_vorname
            // 
            this.tb_vorname.Location = new System.Drawing.Point(165, 75);
            this.tb_vorname.Name = "tb_vorname";
            this.tb_vorname.Size = new System.Drawing.Size(100, 20);
            this.tb_vorname.TabIndex = 6;
            // 
            // tb_nachname
            // 
            this.tb_nachname.Location = new System.Drawing.Point(165, 101);
            this.tb_nachname.Name = "tb_nachname";
            this.tb_nachname.Size = new System.Drawing.Size(100, 20);
            this.tb_nachname.TabIndex = 7;
            // 
            // KontaktDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 350);
            this.Controls.Add(this.bncancel);
            this.Controls.Add(this.bnsave);
            this.Controls.Add(this.groupBox1);
            this.Name = "KontaktDetail";
            this.Text = "KontaktDetail";
            this.Load += new System.EventHandler(this.KontaktDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnsave;
        private System.Windows.Forms.Button bncancel;
        private System.Windows.Forms.TextBox tb_nachname;
        private System.Windows.Forms.TextBox tb_vorname;
        private System.Windows.Forms.TextBox tb_firmenname;
        private System.Windows.Forms.TextBox tb_id;
    }
}