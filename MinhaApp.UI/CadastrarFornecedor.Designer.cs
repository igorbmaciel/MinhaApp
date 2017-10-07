namespace MinhaApp.UI
{
    partial class CadastrarFornecedor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarFornecedor));
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtInscricaoMunicipal = new System.Windows.Forms.TextBox();
            this.txtReceitaBruta = new System.Windows.Forms.TextBox();
            this.cmbEndereco = new System.Windows.Forms.ComboBox();
            this.enderecoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.minhaAppDataSet1 = new global::MinhaApp.UI.MinhaAppDataSet1();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.minhaAppDataSet2 = new global::MinhaApp.UI.MinhaAppDataSet2();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.lblInscricaoMunicipal = new System.Windows.Forms.Label();
            this.lblReceitaBruta = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.minhaAppDataSet = new global::MinhaApp.UI.MinhaAppDataSet();
            this.enderecoTableAdapter1 = new global::MinhaApp.UI.MinhaAppDataSet1TableAdapters.EnderecoTableAdapter();
            this.produtoTableAdapter = new global::MinhaApp.UI.MinhaAppDataSet2TableAdapters.ProdutoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minhaAppDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minhaAppDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minhaAppDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(126, 26);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(100, 20);
            this.txtCNPJ.TabIndex = 0;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(126, 75);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(100, 20);
            this.txtRazaoSocial.TabIndex = 1;
            // 
            // txtInscricaoMunicipal
            // 
            this.txtInscricaoMunicipal.Location = new System.Drawing.Point(126, 124);
            this.txtInscricaoMunicipal.Name = "txtInscricaoMunicipal";
            this.txtInscricaoMunicipal.Size = new System.Drawing.Size(100, 20);
            this.txtInscricaoMunicipal.TabIndex = 2;
            // 
            // txtReceitaBruta
            // 
            this.txtReceitaBruta.Location = new System.Drawing.Point(126, 168);
            this.txtReceitaBruta.Name = "txtReceitaBruta";
            this.txtReceitaBruta.Size = new System.Drawing.Size(100, 20);
            this.txtReceitaBruta.TabIndex = 3;
            // 
            // cmbEndereco
            // 
            this.cmbEndereco.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.enderecoBindingSource1, "Id", true));
            this.cmbEndereco.DataSource = this.enderecoBindingSource1;
            this.cmbEndereco.DisplayMember = "Logradouro";
            this.cmbEndereco.FormattingEnabled = true;
            this.cmbEndereco.Location = new System.Drawing.Point(126, 210);
            this.cmbEndereco.Name = "cmbEndereco";
            this.cmbEndereco.Size = new System.Drawing.Size(121, 21);
            this.cmbEndereco.TabIndex = 4;
            this.cmbEndereco.ValueMember = "Id";
            // 
            // enderecoBindingSource1
            // 
            this.enderecoBindingSource1.DataMember = "Endereco";
            this.enderecoBindingSource1.DataSource = this.minhaAppDataSet1;
            // 
            // minhaAppDataSet1
            // 
            this.minhaAppDataSet1.DataSetName = "MinhaAppDataSet1";
            this.minhaAppDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbProduto
            // 
            this.cmbProduto.DataSource = this.produtoBindingSource;
            this.cmbProduto.DisplayMember = "Nome";
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(126, 256);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(121, 21);
            this.cmbProduto.TabIndex = 5;
            this.cmbProduto.ValueMember = "Id";
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.minhaAppDataSet2;
            // 
            // minhaAppDataSet2
            // 
            this.minhaAppDataSet2.DataSetName = "MinhaAppDataSet2";
            this.minhaAppDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(22, 33);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(34, 13);
            this.lblCNPJ.TabIndex = 6;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Location = new System.Drawing.Point(22, 82);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(70, 13);
            this.lblRazaoSocial.TabIndex = 7;
            this.lblRazaoSocial.Text = "Razão Social";
            // 
            // lblInscricaoMunicipal
            // 
            this.lblInscricaoMunicipal.AutoSize = true;
            this.lblInscricaoMunicipal.Location = new System.Drawing.Point(22, 131);
            this.lblInscricaoMunicipal.Name = "lblInscricaoMunicipal";
            this.lblInscricaoMunicipal.Size = new System.Drawing.Size(98, 13);
            this.lblInscricaoMunicipal.TabIndex = 8;
            this.lblInscricaoMunicipal.Text = "Inscrição Municipal";
            // 
            // lblReceitaBruta
            // 
            this.lblReceitaBruta.AutoSize = true;
            this.lblReceitaBruta.Location = new System.Drawing.Point(22, 175);
            this.lblReceitaBruta.Name = "lblReceitaBruta";
            this.lblReceitaBruta.Size = new System.Drawing.Size(72, 13);
            this.lblReceitaBruta.TabIndex = 9;
            this.lblReceitaBruta.Text = "Receita Bruta";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(25, 218);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 10;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(25, 256);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 11;
            this.lblProduto.Text = "Produto";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(25, 294);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // minhaAppDataSet
            // 
            this.minhaAppDataSet.DataSetName = "MinhaAppDataSet";
            this.minhaAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enderecoTableAdapter1
            // 
            this.enderecoTableAdapter1.ClearBeforeFill = true;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // CadastrarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 327);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblReceitaBruta);
            this.Controls.Add(this.lblInscricaoMunicipal);
            this.Controls.Add(this.lblRazaoSocial);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.cmbEndereco);
            this.Controls.Add(this.txtReceitaBruta);
            this.Controls.Add(this.txtInscricaoMunicipal);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.txtCNPJ);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastrarFornecedor";
            this.Text = "CadastrarFornecedor";
            this.Load += new System.EventHandler(this.CadastrarFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enderecoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minhaAppDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minhaAppDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minhaAppDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.TextBox txtInscricaoMunicipal;
        private System.Windows.Forms.TextBox txtReceitaBruta;
        private System.Windows.Forms.ComboBox cmbEndereco;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.Label lblInscricaoMunicipal;
        private System.Windows.Forms.Label lblReceitaBruta;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnSalvar;
        private MinhaAppDataSet minhaAppDataSet;
        private MinhaAppDataSet1 minhaAppDataSet1;
        private System.Windows.Forms.BindingSource enderecoBindingSource1;
        private MinhaAppDataSet1TableAdapters.EnderecoTableAdapter enderecoTableAdapter1;
        private MinhaAppDataSet2 minhaAppDataSet2;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private MinhaAppDataSet2TableAdapters.ProdutoTableAdapter produtoTableAdapter;
    }
}