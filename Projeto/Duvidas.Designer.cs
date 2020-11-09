namespace Projeto
{
    partial class Duvidas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvDuvidas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnResponder = new System.Windows.Forms.Button();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.mskTxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.cboSituacao = new System.Windows.Forms.ComboBox();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDuvidas)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDuvidas
            // 
            this.DgvDuvidas.AllowUserToOrderColumns = true;
            this.DgvDuvidas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvDuvidas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvDuvidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDuvidas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDuvidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDuvidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDuvidas.EnableHeadersVisualStyles = false;
            this.DgvDuvidas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.DgvDuvidas.Location = new System.Drawing.Point(12, 76);
            this.DgvDuvidas.Name = "DgvDuvidas";
            this.DgvDuvidas.ReadOnly = true;
            this.DgvDuvidas.RowHeadersWidth = 20;
            this.DgvDuvidas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.DgvDuvidas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDuvidas.RowTemplate.Height = 24;
            this.DgvDuvidas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvDuvidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDuvidas.Size = new System.Drawing.Size(695, 531);
            this.DgvDuvidas.TabIndex = 1;
            this.DgvDuvidas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDuvidas_CellClick);
            this.DgvDuvidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(759, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(884, 78);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(416, 28);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.label2.Location = new System.Drawing.Point(759, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(884, 156);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(416, 28);
            this.txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.label3.Location = new System.Drawing.Point(750, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.label4.Location = new System.Drawing.Point(750, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mensagem:";
            // 
            // BtnResponder
            // 
            this.BtnResponder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnResponder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.BtnResponder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResponder.ForeColor = System.Drawing.Color.White;
            this.BtnResponder.Location = new System.Drawing.Point(921, 505);
            this.BtnResponder.Name = "BtnResponder";
            this.BtnResponder.Size = new System.Drawing.Size(201, 54);
            this.BtnResponder.TabIndex = 10;
            this.BtnResponder.Text = "Responder";
            this.BtnResponder.UseVisualStyleBackColor = false;
            this.BtnResponder.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMensagem
            // 
            this.txtMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensagem.Location = new System.Drawing.Point(884, 273);
            this.txtMensagem.MaxLength = 255;
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.ReadOnly = true;
            this.txtMensagem.Size = new System.Drawing.Size(419, 149);
            this.txtMensagem.TabIndex = 11;
            // 
            // mskTxtTelefone
            // 
            this.mskTxtTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mskTxtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTxtTelefone.Location = new System.Drawing.Point(884, 226);
            this.mskTxtTelefone.Mask = "00000-0000";
            this.mskTxtTelefone.Name = "mskTxtTelefone";
            this.mskTxtTelefone.ReadOnly = true;
            this.mskTxtTelefone.Size = new System.Drawing.Size(206, 28);
            this.mskTxtTelefone.TabIndex = 12;
            // 
            // lblSituacao
            // 
            this.lblSituacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.lblSituacao.Location = new System.Drawing.Point(759, 456);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(104, 25);
            this.lblSituacao.TabIndex = 13;
            this.lblSituacao.Text = "Situacao:";
            // 
            // cboSituacao
            // 
            this.cboSituacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSituacao.FormattingEnabled = true;
            this.cboSituacao.Items.AddRange(new object[] {
            "Respondido"});
            this.cboSituacao.Location = new System.Drawing.Point(884, 456);
            this.cboSituacao.Name = "cboSituacao";
            this.cboSituacao.Size = new System.Drawing.Size(416, 30);
            this.cboSituacao.TabIndex = 14;
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.BtnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.ForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.Location = new System.Drawing.Point(921, 576);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(201, 54);
            this.BtnAtualizar.TabIndex = 15;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // Duvidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 633);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.cboSituacao);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.mskTxtTelefone);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.BtnResponder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvDuvidas);
            this.Name = "Duvidas";
            this.Text = "Dúvidas";
            this.Load += new System.EventHandler(this.Duvidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDuvidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvDuvidas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnResponder;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.MaskedTextBox mskTxtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.ComboBox cboSituacao;
        private System.Windows.Forms.Button BtnAtualizar;
    }
}