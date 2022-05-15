namespace Server
{
    partial class Form1
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
            this.btnDekripto = new System.Windows.Forms.Button();
            this.btnDergo = new System.Windows.Forms.Button();
            this.btnVerifiko = new System.Windows.Forms.Button();
            this.btnCertifikata = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPergjigjaDekriptuar = new System.Windows.Forms.TextBox();
            this.btnEnkripto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPergjigjaEnkriptuar = new System.Windows.Forms.TextBox();
            this.txtKerkesaDekriptuar = new System.Windows.Forms.TextBox();
            this.txtKerkesaNenshkruar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNenshkruaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDekripto
            // 
            this.btnDekripto.Location = new System.Drawing.Point(525, 269);
            this.btnDekripto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDekripto.Name = "btnDekripto";
            this.btnDekripto.Size = new System.Drawing.Size(194, 35);
            this.btnDekripto.TabIndex = 16;
            this.btnDekripto.Text = "Dekripto Kerkesen";
            this.btnDekripto.UseVisualStyleBackColor = true;
            this.btnDekripto.Click += new System.EventHandler(this.btnDekripto_Click);
            // 
            // btnDergo
            // 
            this.btnDergo.Location = new System.Drawing.Point(573, 630);
            this.btnDergo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDergo.Name = "btnDergo";
            this.btnDergo.Size = new System.Drawing.Size(146, 35);
            this.btnDergo.TabIndex = 15;
            this.btnDergo.Text = "Dergo";
            this.btnDergo.UseVisualStyleBackColor = true;
            this.btnDergo.Click += new System.EventHandler(this.btnDergo_Click);
            // 
            // btnVerifiko
            // 
            this.btnVerifiko.Location = new System.Drawing.Point(28, 269);
            this.btnVerifiko.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerifiko.Name = "btnVerifiko";
            this.btnVerifiko.Size = new System.Drawing.Size(194, 35);
            this.btnVerifiko.TabIndex = 14;
            this.btnVerifiko.Text = "Verifiko Certifikaten";
            this.btnVerifiko.UseVisualStyleBackColor = true;
            this.btnVerifiko.Click += new System.EventHandler(this.btnVerifiko_Click);
            // 
            // btnCertifikata
            // 
            this.btnCertifikata.Location = new System.Drawing.Point(285, 269);
            this.btnCertifikata.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCertifikata.Name = "btnCertifikata";
            this.btnCertifikata.Size = new System.Drawing.Size(163, 35);
            this.btnCertifikata.TabIndex = 13;
            this.btnCertifikata.Text = "Vendos Certifikaten";
            this.btnCertifikata.UseVisualStyleBackColor = true;
            this.btnCertifikata.Click += new System.EventHandler(this.btnCertifikata_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 376);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pergjigja e dekriptuar e serverit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kerkesa e nenshkruar nga klienti";
            // 
            // txtPergjigjaDekriptuar
            // 
            this.txtPergjigjaDekriptuar.Location = new System.Drawing.Point(3, 419);
            this.txtPergjigjaDekriptuar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPergjigjaDekriptuar.Multiline = true;
            this.txtPergjigjaDekriptuar.Name = "txtPergjigjaDekriptuar";
            this.txtPergjigjaDekriptuar.Size = new System.Drawing.Size(359, 187);
            this.txtPergjigjaDekriptuar.TabIndex = 10;
            // 
            // btnEnkripto
            // 
            this.btnEnkripto.Location = new System.Drawing.Point(18, 630);
            this.btnEnkripto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnkripto.Name = "btnEnkripto";
            this.btnEnkripto.Size = new System.Drawing.Size(163, 35);
            this.btnEnkripto.TabIndex = 17;
            this.btnEnkripto.Text = "Enkripto";
            this.btnEnkripto.UseVisualStyleBackColor = true;
            this.btnEnkripto.Click += new System.EventHandler(this.btnEnkripto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(386, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Kerkesa e dekriptuar nga klienti";
            // 
            // txtPergjigjaEnkriptuar
            // 
            this.txtPergjigjaEnkriptuar.Location = new System.Drawing.Point(382, 419);
            this.txtPergjigjaEnkriptuar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPergjigjaEnkriptuar.Multiline = true;
            this.txtPergjigjaEnkriptuar.Name = "txtPergjigjaEnkriptuar";
            this.txtPergjigjaEnkriptuar.Size = new System.Drawing.Size(359, 187);
            this.txtPergjigjaEnkriptuar.TabIndex = 20;
            // 
            // txtKerkesaDekriptuar
            // 
            this.txtKerkesaDekriptuar.Location = new System.Drawing.Point(378, 61);
            this.txtKerkesaDekriptuar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKerkesaDekriptuar.Multiline = true;
            this.txtKerkesaDekriptuar.Name = "txtKerkesaDekriptuar";
            this.txtKerkesaDekriptuar.Size = new System.Drawing.Size(359, 187);
            this.txtKerkesaDekriptuar.TabIndex = 21;
            // 
            // txtKerkesaNenshkruar
            // 
            this.txtKerkesaNenshkruar.Location = new System.Drawing.Point(3, 61);
            this.txtKerkesaNenshkruar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKerkesaNenshkruar.Multiline = true;
            this.txtKerkesaNenshkruar.Name = "txtKerkesaNenshkruar";
            this.txtKerkesaNenshkruar.Size = new System.Drawing.Size(359, 187);
            this.txtKerkesaNenshkruar.TabIndex = 22;
            this.txtKerkesaNenshkruar.TextChanged += new System.EventHandler(this.txtKerkesaNenshkruar_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(390, 376);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(348, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Pergjigja e enkriptuar e serverit";
            // 
            // btnNenshkruaj
            // 
            this.btnNenshkruaj.Location = new System.Drawing.Point(285, 630);
            this.btnNenshkruaj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNenshkruaj.Name = "btnNenshkruaj";
            this.btnNenshkruaj.Size = new System.Drawing.Size(146, 35);
            this.btnNenshkruaj.TabIndex = 24;
            this.btnNenshkruaj.Text = "Nenshkruaj";
            this.btnNenshkruaj.UseVisualStyleBackColor = true;
            this.btnNenshkruaj.Click += new System.EventHandler(this.btnNenshkruaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 796);
            this.Controls.Add(this.btnNenshkruaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKerkesaNenshkruar);
            this.Controls.Add(this.txtKerkesaDekriptuar);
            this.Controls.Add(this.txtPergjigjaEnkriptuar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnkripto);
            this.Controls.Add(this.btnDekripto);
            this.Controls.Add(this.btnDergo);
            this.Controls.Add(this.btnVerifiko);
            this.Controls.Add(this.btnCertifikata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPergjigjaDekriptuar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDekripto;
        private System.Windows.Forms.Button btnDergo;
        private System.Windows.Forms.Button btnVerifiko;
        private System.Windows.Forms.Button btnCertifikata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPergjigjaDekriptuar;
        private System.Windows.Forms.Button btnEnkripto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPergjigjaEnkriptuar;
        private System.Windows.Forms.TextBox txtKerkesaDekriptuar;
        private System.Windows.Forms.TextBox txtKerkesaNenshkruar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNenshkruaj;
    }
}

