namespace Client
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
            this.txtKerkesa = new System.Windows.Forms.TextBox();
            this.txtPergjigjaEnkriptuar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCertifikata = new System.Windows.Forms.Button();
            this.btnVerifiko = new System.Windows.Forms.Button();
            this.btnDergo = new System.Windows.Forms.Button();
            this.btnEnkripto = new System.Windows.Forms.Button();
            this.btnDekripto = new System.Windows.Forms.Button();
            this.btnNenshkruaj = new System.Windows.Forms.Button();
            this.txtKerkesaEnkriptuar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPergjigjaDekriptuar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtKerkesa
            // 
            this.txtKerkesa.Location = new System.Drawing.Point(8, 64);
            this.txtKerkesa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKerkesa.Multiline = true;
            this.txtKerkesa.Name = "txtKerkesa";
            this.txtKerkesa.Size = new System.Drawing.Size(359, 185);
            this.txtKerkesa.TabIndex = 0;
            this.txtKerkesa.TextChanged += new System.EventHandler(this.txtKerkesa_TextChanged);
            // 
            // txtPergjigjaEnkriptuar
            // 
            this.txtPergjigjaEnkriptuar.Location = new System.Drawing.Point(7, 449);
            this.txtPergjigjaEnkriptuar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPergjigjaEnkriptuar.Multiline = true;
            this.txtPergjigjaEnkriptuar.Name = "txtPergjigjaEnkriptuar";
            this.txtPergjigjaEnkriptuar.Size = new System.Drawing.Size(359, 185);
            this.txtPergjigjaEnkriptuar.TabIndex = 1;
            this.txtPergjigjaEnkriptuar.TextChanged += new System.EventHandler(this.txtPergjigja_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kerkesa e dekriptuar e klientit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 404);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pergjigja e enkriptuar e serverit";
            // 
            // btnCertifikata
            // 
            this.btnCertifikata.Location = new System.Drawing.Point(203, 261);
            this.btnCertifikata.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCertifikata.Name = "btnCertifikata";
            this.btnCertifikata.Size = new System.Drawing.Size(163, 35);
            this.btnCertifikata.TabIndex = 5;
            this.btnCertifikata.Text = "Vendos Certifikaten";
            this.btnCertifikata.UseVisualStyleBackColor = true;
            this.btnCertifikata.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVerifiko
            // 
            this.btnVerifiko.Location = new System.Drawing.Point(304, 689);
            this.btnVerifiko.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerifiko.Name = "btnVerifiko";
            this.btnVerifiko.Size = new System.Drawing.Size(163, 35);
            this.btnVerifiko.TabIndex = 6;
            this.btnVerifiko.Text = "Verifiko Certifikaten";
            this.btnVerifiko.UseVisualStyleBackColor = true;
            this.btnVerifiko.Click += new System.EventHandler(this.btnVerifiko_Click);
            // 
            // btnDergo
            // 
            this.btnDergo.Location = new System.Drawing.Point(304, 351);
            this.btnDergo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDergo.Name = "btnDergo";
            this.btnDergo.Size = new System.Drawing.Size(146, 35);
            this.btnDergo.TabIndex = 7;
            this.btnDergo.Text = "Dergo";
            this.btnDergo.UseVisualStyleBackColor = true;
            this.btnDergo.Click += new System.EventHandler(this.btnDergo_Click);
            // 
            // btnEnkripto
            // 
            this.btnEnkripto.Location = new System.Drawing.Point(388, 261);
            this.btnEnkripto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnkripto.Name = "btnEnkripto";
            this.btnEnkripto.Size = new System.Drawing.Size(164, 35);
            this.btnEnkripto.TabIndex = 8;
            this.btnEnkripto.Text = "Enkripto Kerkesen";
            this.btnEnkripto.UseVisualStyleBackColor = true;
            this.btnEnkripto.Click += new System.EventHandler(this.btnEnkripto_Click);
            // 
            // btnDekripto
            // 
            this.btnDekripto.Location = new System.Drawing.Point(304, 644);
            this.btnDekripto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDekripto.Name = "btnDekripto";
            this.btnDekripto.Size = new System.Drawing.Size(163, 35);
            this.btnDekripto.TabIndex = 9;
            this.btnDekripto.Text = "Dekripto Pergjigjen";
            this.btnDekripto.UseVisualStyleBackColor = true;
            this.btnDekripto.Click += new System.EventHandler(this.btnDekripto_Click);
            // 
            // btnNenshkruaj
            // 
            this.btnNenshkruaj.Location = new System.Drawing.Point(304, 306);
            this.btnNenshkruaj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNenshkruaj.Name = "btnNenshkruaj";
            this.btnNenshkruaj.Size = new System.Drawing.Size(146, 35);
            this.btnNenshkruaj.TabIndex = 10;
            this.btnNenshkruaj.Text = "Nenshkruaj";
            this.btnNenshkruaj.UseVisualStyleBackColor = true;
            this.btnNenshkruaj.Click += new System.EventHandler(this.btnNenshkruaj_Click);
            // 
            // txtKerkesaEnkriptuar
            // 
            this.txtKerkesaEnkriptuar.Location = new System.Drawing.Point(388, 64);
            this.txtKerkesaEnkriptuar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKerkesaEnkriptuar.Multiline = true;
            this.txtKerkesaEnkriptuar.Name = "txtKerkesaEnkriptuar";
            this.txtKerkesaEnkriptuar.Size = new System.Drawing.Size(359, 187);
            this.txtKerkesaEnkriptuar.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Kerkesa e enkriptuar e klientit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(399, 404);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "Pergjigja e dekriptuar e serverit";
            // 
            // txtPergjigjaDekriptuar
            // 
            this.txtPergjigjaDekriptuar.Location = new System.Drawing.Point(389, 449);
            this.txtPergjigjaDekriptuar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPergjigjaDekriptuar.Multiline = true;
            this.txtPergjigjaDekriptuar.Name = "txtPergjigjaDekriptuar";
            this.txtPergjigjaDekriptuar.Size = new System.Drawing.Size(359, 185);
            this.txtPergjigjaDekriptuar.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 729);
            this.Controls.Add(this.txtPergjigjaDekriptuar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKerkesaEnkriptuar);
            this.Controls.Add(this.btnNenshkruaj);
            this.Controls.Add(this.btnDekripto);
            this.Controls.Add(this.btnEnkripto);
            this.Controls.Add(this.btnDergo);
            this.Controls.Add(this.btnVerifiko);
            this.Controls.Add(this.btnCertifikata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPergjigjaEnkriptuar);
            this.Controls.Add(this.txtKerkesa);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKerkesa;
        private System.Windows.Forms.TextBox txtPergjigjaEnkriptuar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCertifikata;
        private System.Windows.Forms.Button btnVerifiko;
        private System.Windows.Forms.Button btnDergo;
        private System.Windows.Forms.Button btnEnkripto;
        private System.Windows.Forms.Button btnDekripto;
        private System.Windows.Forms.Button btnNenshkruaj;
        private System.Windows.Forms.TextBox txtKerkesaEnkriptuar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPergjigjaDekriptuar;
    }
}

