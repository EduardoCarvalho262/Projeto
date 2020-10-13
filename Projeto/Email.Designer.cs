namespace Projeto
{
    partial class Email
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
            this.lblPara = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.lblDe = new System.Windows.Forms.Label();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.lblFicheiro = new System.Windows.Forms.Label();
            this.txtFicheiro = new System.Windows.Forms.TextBox();
            this.BtnProcurar = new System.Windows.Forms.Button();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.lblPara.Location = new System.Drawing.Point(45, 77);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(53, 24);
            this.lblPara.TabIndex = 0;
            this.lblPara.Text = "Para:";
            // 
            // txtPara
            // 
            this.txtPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPara.Location = new System.Drawing.Point(45, 104);
            this.txtPara.Name = "txtPara";
            this.txtPara.ReadOnly = true;
            this.txtPara.Size = new System.Drawing.Size(392, 28);
            this.txtPara.TabIndex = 1;
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.lblDe.Location = new System.Drawing.Point(45, 158);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(39, 24);
            this.lblDe.TabIndex = 2;
            this.lblDe.Text = "De:";
            this.lblDe.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDe
            // 
            this.txtDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDe.Location = new System.Drawing.Point(44, 185);
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(393, 28);
            this.txtDe.TabIndex = 3;
            // 
            // lblFicheiro
            // 
            this.lblFicheiro.AutoSize = true;
            this.lblFicheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFicheiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.lblFicheiro.Location = new System.Drawing.Point(45, 244);
            this.lblFicheiro.Name = "lblFicheiro";
            this.lblFicheiro.Size = new System.Drawing.Size(150, 24);
            this.lblFicheiro.TabIndex = 4;
            this.lblFicheiro.Text = "Anexar Ficheiro:";
            // 
            // txtFicheiro
            // 
            this.txtFicheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFicheiro.Location = new System.Drawing.Point(44, 271);
            this.txtFicheiro.Name = "txtFicheiro";
            this.txtFicheiro.Size = new System.Drawing.Size(393, 28);
            this.txtFicheiro.TabIndex = 5;
            // 
            // BtnProcurar
            // 
            this.BtnProcurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.BtnProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProcurar.ForeColor = System.Drawing.Color.White;
            this.BtnProcurar.Location = new System.Drawing.Point(332, 305);
            this.BtnProcurar.Name = "BtnProcurar";
            this.BtnProcurar.Size = new System.Drawing.Size(105, 33);
            this.BtnProcurar.TabIndex = 6;
            this.BtnProcurar.Text = "Procurar";
            this.BtnProcurar.UseVisualStyleBackColor = false;
            this.BtnProcurar.Click += new System.EventHandler(this.BtnProcurar_Click);
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssunto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.lblAssunto.Location = new System.Drawing.Point(45, 356);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(83, 24);
            this.lblAssunto.TabIndex = 7;
            this.lblAssunto.Text = "Assunto:";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssunto.Location = new System.Drawing.Point(44, 383);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.ReadOnly = true;
            this.txtAssunto.Size = new System.Drawing.Size(392, 28);
            this.txtAssunto.TabIndex = 8;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.lblMensagem.Location = new System.Drawing.Point(45, 436);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(110, 24);
            this.lblMensagem.TabIndex = 9;
            this.lblMensagem.Text = "Mensagem:";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensagem.Location = new System.Drawing.Point(44, 463);
            this.txtMensagem.MaxLength = 255;
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(393, 153);
            this.txtMensagem.TabIndex = 10;
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.BtnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnviar.ForeColor = System.Drawing.Color.White;
            this.BtnEnviar.Location = new System.Drawing.Point(296, 622);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(141, 35);
            this.BtnEnviar.TabIndex = 11;
            this.BtnEnviar.Text = "Enviar Email";
            this.BtnEnviar.UseVisualStyleBackColor = false;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(483, 669);
            this.Controls.Add(this.BtnEnviar);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.lblAssunto);
            this.Controls.Add(this.BtnProcurar);
            this.Controls.Add(this.txtFicheiro);
            this.Controls.Add(this.lblFicheiro);
            this.Controls.Add(this.txtDe);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.lblPara);
            this.Name = "Email";
            this.Text = "Email";
            this.Load += new System.EventHandler(this.Email_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.Label lblFicheiro;
        private System.Windows.Forms.TextBox txtFicheiro;
        private System.Windows.Forms.Button BtnProcurar;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}