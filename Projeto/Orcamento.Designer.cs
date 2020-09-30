namespace Projeto
{
    partial class Orcamento
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
            this.DvgOrcamento = new System.Windows.Forms.DataGridView();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.BtnResponder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DvgOrcamento)).BeginInit();
            this.SuspendLayout();
            // 
            // DvgOrcamento
            // 
            this.DvgOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgOrcamento.Location = new System.Drawing.Point(12, 108);
            this.DvgOrcamento.Name = "DvgOrcamento";
            this.DvgOrcamento.ReadOnly = true;
            this.DvgOrcamento.RowTemplate.Height = 24;
            this.DvgOrcamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DvgOrcamento.Size = new System.Drawing.Size(589, 520);
            this.DvgOrcamento.TabIndex = 0;
            this.DvgOrcamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DvgOrcamento_CellClick);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(667, 202);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(90, 29);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(670, 234);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(372, 28);
            this.txtNome.TabIndex = 2;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(665, 287);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(125, 29);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(670, 319);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ReadOnly = true;
            this.txtTelefone.Size = new System.Drawing.Size(261, 28);
            this.txtTelefone.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(667, 373);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(86, 29);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(670, 405);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(372, 28);
            this.txtEmail.TabIndex = 6;
            // 
            // BtnResponder
            // 
            this.BtnResponder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResponder.Location = new System.Drawing.Point(749, 473);
            this.BtnResponder.Name = "BtnResponder";
            this.BtnResponder.Size = new System.Drawing.Size(201, 54);
            this.BtnResponder.TabIndex = 7;
            this.BtnResponder.Text = "Responder";
            this.BtnResponder.UseVisualStyleBackColor = true;
            this.BtnResponder.Click += new System.EventHandler(this.BtnResponder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pedidos de Orçamento";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Orcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 640);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnResponder);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.DvgOrcamento);
            this.Name = "Orcamento";
            this.Text = "Orcamento";
            this.Load += new System.EventHandler(this.Orcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DvgOrcamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DvgOrcamento;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button BtnResponder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
    }
}