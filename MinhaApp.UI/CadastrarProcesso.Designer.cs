namespace MinhaApp.UI
{
    partial class CadastrarProcesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarProcesso));
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblRelatoFiscalizacao = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.minhaAppDataSet3 = new global::MinhaApp.UI.MinhaAppDataSet3();
            this.txtRelato = new System.Windows.Forms.TextBox();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.minhaAppDataSet = new global::MinhaApp.UI.MinhaAppDataSet();
            this.minhaAppDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedorTableAdapter = new global::MinhaApp.UI.MinhaAppDataSet3TableAdapters.FornecedorTableAdapter();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minhaAppDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minhaAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minhaAppDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(29, 43);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 0;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // lblRelatoFiscalizacao
            // 
            this.lblRelatoFiscalizacao.AutoSize = true;
            this.lblRelatoFiscalizacao.Location = new System.Drawing.Point(29, 94);
            this.lblRelatoFiscalizacao.Name = "lblRelatoFiscalizacao";
            this.lblRelatoFiscalizacao.Size = new System.Drawing.Size(114, 13);
            this.lblRelatoFiscalizacao.TabIndex = 1;
            this.lblRelatoFiscalizacao.Text = "Relato de Fiscalização";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data do Relato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fiscal Responsável";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fornecedorBindingSource, "Id", true));
            this.cmbFornecedor.DataSource = this.fornecedorBindingSource;
            this.cmbFornecedor.DisplayMember = "RazaoSocial";
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(128, 35);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(121, 21);
            this.cmbFornecedor.TabIndex = 4;
            this.cmbFornecedor.ValueMember = "Id";
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "Fornecedor";
            this.fornecedorBindingSource.DataSource = this.minhaAppDataSet3;
            // 
            // minhaAppDataSet3
            // 
            this.minhaAppDataSet3.DataSetName = "MinhaAppDataSet3";
            this.minhaAppDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtRelato
            // 
            this.txtRelato.Location = new System.Drawing.Point(149, 87);
            this.txtRelato.Name = "txtRelato";
            this.txtRelato.Size = new System.Drawing.Size(100, 20);
            this.txtRelato.TabIndex = 5;
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Location = new System.Drawing.Point(149, 183);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(100, 20);
            this.txtResponsavel.TabIndex = 5;
            // 
            // minhaAppDataSet
            // 
            this.minhaAppDataSet.DataSetName = "MinhaAppDataSet";
            this.minhaAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // minhaAppDataSetBindingSource
            // 
            this.minhaAppDataSetBindingSource.DataSource = this.minhaAppDataSet;
            this.minhaAppDataSetBindingSource.Position = 0;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(32, 230);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(149, 134);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 7;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // CadastrarProcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 265);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtResponsavel);
            this.Controls.Add(this.txtRelato);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRelatoFiscalizacao);
            this.Controls.Add(this.lblFornecedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastrarProcesso";
            this.Text = "CadastrarProcesso";
            this.Load += new System.EventHandler(this.CadastrarProcesso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minhaAppDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minhaAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minhaAppDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblRelatoFiscalizacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.TextBox txtRelato;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.BindingSource minhaAppDataSetBindingSource;
        private MinhaAppDataSet minhaAppDataSet;
        private MinhaAppDataSet3 minhaAppDataSet3;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private MinhaAppDataSet3TableAdapters.FornecedorTableAdapter fornecedorTableAdapter;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox txtData;
    }
}