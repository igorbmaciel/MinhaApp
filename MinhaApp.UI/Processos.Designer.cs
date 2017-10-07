namespace MinhaApp.UI
{
    partial class Processos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Processos));
            this.dgvProcessos = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProcessos
            // 
            this.dgvProcessos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcessos.Location = new System.Drawing.Point(12, 46);
            this.dgvProcessos.Name = "dgvProcessos";
            this.dgvProcessos.Size = new System.Drawing.Size(363, 150);
            this.dgvProcessos.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(13, 13);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // Processos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 210);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgvProcessos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Processos";
            this.Text = "Processos";
            this.Load += new System.EventHandler(this.Processos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProcessos;
        private System.Windows.Forms.Button btnCadastrar;
    }
}