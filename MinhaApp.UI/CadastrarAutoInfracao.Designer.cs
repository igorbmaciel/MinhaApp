namespace MinhaApp.UI
{
    partial class CadastrarAutoInfracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarAutoInfracao));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cmbProcesso = new System.Windows.Forms.ComboBox();
            this.processoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.minhaAppDataSet4 = new global::MinhaApp.UI.MinhaAppDataSet4();
            this.txtGravidade = new System.Windows.Forms.TextBox();
            this.cbAtenuante = new System.Windows.Forms.CheckBox();
            this.cbAgravante = new System.Windows.Forms.CheckBox();
            this.txtMulta = new System.Windows.Forms.TextBox();
            this.processoTableAdapter = new global::MinhaApp.UI.MinhaAppDataSet4TableAdapters.ProcessoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.processoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minhaAppDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Processo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gravidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Atenuante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Agravante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Multa";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(26, 200);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cmbProcesso
            // 
            this.cmbProcesso.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.processoBindingSource, "Id", true));
            this.cmbProcesso.DataSource = this.processoBindingSource;
            this.cmbProcesso.DisplayMember = "RelatoFiscalizacao";
            this.cmbProcesso.FormattingEnabled = true;
            this.cmbProcesso.Location = new System.Drawing.Point(126, 21);
            this.cmbProcesso.Name = "cmbProcesso";
            this.cmbProcesso.Size = new System.Drawing.Size(121, 21);
            this.cmbProcesso.TabIndex = 2;
            this.cmbProcesso.ValueMember = "Id";
            // 
            // processoBindingSource
            // 
            this.processoBindingSource.DataMember = "Processo";
            this.processoBindingSource.DataSource = this.minhaAppDataSet4;
            // 
            // minhaAppDataSet4
            // 
            this.minhaAppDataSet4.DataSetName = "MinhaAppDataSet4";
            this.minhaAppDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtGravidade
            // 
            this.txtGravidade.Location = new System.Drawing.Point(126, 56);
            this.txtGravidade.Name = "txtGravidade";
            this.txtGravidade.Size = new System.Drawing.Size(100, 20);
            this.txtGravidade.TabIndex = 3;
            // 
            // cbAtenuante
            // 
            this.cbAtenuante.AutoSize = true;
            this.cbAtenuante.Location = new System.Drawing.Point(126, 96);
            this.cbAtenuante.Name = "cbAtenuante";
            this.cbAtenuante.Size = new System.Drawing.Size(15, 14);
            this.cbAtenuante.TabIndex = 4;
            this.cbAtenuante.UseVisualStyleBackColor = true;
            // 
            // cbAgravante
            // 
            this.cbAgravante.AutoSize = true;
            this.cbAgravante.Location = new System.Drawing.Point(126, 126);
            this.cbAgravante.Name = "cbAgravante";
            this.cbAgravante.Size = new System.Drawing.Size(15, 14);
            this.cbAgravante.TabIndex = 4;
            this.cbAgravante.UseVisualStyleBackColor = true;
            // 
            // txtMulta
            // 
            this.txtMulta.Location = new System.Drawing.Point(126, 155);
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Size = new System.Drawing.Size(100, 20);
            this.txtMulta.TabIndex = 3;
            // 
            // processoTableAdapter
            // 
            this.processoTableAdapter.ClearBeforeFill = true;
            // 
            // CadastrarAutoInfracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 235);
            this.Controls.Add(this.cbAgravante);
            this.Controls.Add(this.cbAtenuante);
            this.Controls.Add(this.txtMulta);
            this.Controls.Add(this.txtGravidade);
            this.Controls.Add(this.cmbProcesso);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastrarAutoInfracao";
            this.Text = "CadastrarAutoInfracao";
            this.Load += new System.EventHandler(this.CadastrarAutoInfracao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.processoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minhaAppDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cmbProcesso;
        private System.Windows.Forms.TextBox txtGravidade;
        private System.Windows.Forms.CheckBox cbAtenuante;
        private System.Windows.Forms.CheckBox cbAgravante;
        private System.Windows.Forms.TextBox txtMulta;
        private MinhaAppDataSet4 minhaAppDataSet4;
        private System.Windows.Forms.BindingSource processoBindingSource;
        private MinhaAppDataSet4TableAdapters.ProcessoTableAdapter processoTableAdapter;
    }
}