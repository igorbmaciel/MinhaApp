namespace MinhaApp.UI
{
    partial class MinhaApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinhaApp));
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnProcesso = new System.Windows.Forms.Button();
            this.btnAutoInfracao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Location = new System.Drawing.Point(12, 24);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btnFornecedor.TabIndex = 0;
            this.btnFornecedor.Text = "Fornecedor";
            this.btnFornecedor.UseVisualStyleBackColor = true;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // btnProcesso
            // 
            this.btnProcesso.Location = new System.Drawing.Point(118, 24);
            this.btnProcesso.Name = "btnProcesso";
            this.btnProcesso.Size = new System.Drawing.Size(75, 23);
            this.btnProcesso.TabIndex = 0;
            this.btnProcesso.Text = "Processo";
            this.btnProcesso.UseVisualStyleBackColor = true;
            this.btnProcesso.Click += new System.EventHandler(this.btnProcesso_Click);
            // 
            // btnAutoInfracao
            // 
            this.btnAutoInfracao.Location = new System.Drawing.Point(214, 24);
            this.btnAutoInfracao.Name = "btnAutoInfracao";
            this.btnAutoInfracao.Size = new System.Drawing.Size(90, 23);
            this.btnAutoInfracao.TabIndex = 0;
            this.btnAutoInfracao.Text = "AutoInfracao";
            this.btnAutoInfracao.UseVisualStyleBackColor = true;
            this.btnAutoInfracao.Click += new System.EventHandler(this.btnAutoInfracao_Click);
            // 
            // MinhaApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 68);
            this.Controls.Add(this.btnAutoInfracao);
            this.Controls.Add(this.btnProcesso);
            this.Controls.Add(this.btnFornecedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MinhaApp";
            this.Text = "MinhaApp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Button btnProcesso;
        private System.Windows.Forms.Button btnAutoInfracao;
    }
}