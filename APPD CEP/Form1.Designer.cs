namespace APPD_CEP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblcep = new System.Windows.Forms.Label();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcep.Location = new System.Drawing.Point(26, 66);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(108, 21);
            this.lblcep.TabIndex = 0;
            this.lblcep.Text = "Digite o CEP:";
            this.lblcep.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnconsultar.Location = new System.Drawing.Point(215, 64);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(196, 23);
            this.btnconsultar.TabIndex = 1;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(135, 64);
            this.txtCEP.Mask = "00000-999";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(62, 23);
            this.txtCEP.TabIndex = 2;
            this.txtCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(135, 107);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(276, 23);
            this.txtEndereco.TabIndex = 3;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(135, 149);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(276, 23);
            this.txtCidade.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(135, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(165, 30);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Busca Endereço";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEndereco.Location = new System.Drawing.Point(26, 109);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(109, 21);
            this.lblEndereco.TabIndex = 6;
            this.lblEndereco.Text = "Logradrouro:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBairro.Location = new System.Drawing.Point(26, 151);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(94, 21);
            this.lblBairro.TabIndex = 7;
            this.lblBairro.Text = "Cidade/UF:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 213);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.lblcep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblcep;
        private Button btnconsultar;
        private MaskedTextBox txtCEP;
        private TextBox txtEndereco;
        private TextBox txtCidade;
        private Label lblTitulo;
        private Label lblEndereco;
        private Label lblBairro;
    }
}