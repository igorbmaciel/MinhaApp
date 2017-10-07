namespace MinhaApp.UI
{
    partial class Fornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fornecedores));
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Location = new System.Drawing.Point(12, 61);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.Size = new System.Drawing.Size(363, 225);
            this.dgvFornecedor.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(13, 22);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 299);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgvFornecedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fornecedor";
            this.Text = "Fornecedor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.Button btnCadastrar;
    }
}

