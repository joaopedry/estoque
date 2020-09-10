namespace Estoque
{
    partial class Form1
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
            this.lbEstoque = new System.Windows.Forms.Label();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.lbQtdEstoque = new System.Windows.Forms.Label();
            this.grvProduto = new System.Windows.Forms.DataGridView();
            this.grvVenda = new System.Windows.Forms.DataGridView();
            this.lbProduto = new System.Windows.Forms.Label();
            this.lbVenda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEstoque
            // 
            this.lbEstoque.AutoSize = true;
            this.lbEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstoque.Location = new System.Drawing.Point(15, 256);
            this.lbEstoque.Name = "lbEstoque";
            this.lbEstoque.Size = new System.Drawing.Size(214, 25);
            this.lbEstoque.TabIndex = 0;
            this.lbEstoque.Text = "Quantidade Estoque:";
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(444, 244);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(108, 37);
            this.btAtualizar.TabIndex = 1;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // lbQtdEstoque
            // 
            this.lbQtdEstoque.AutoSize = true;
            this.lbQtdEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQtdEstoque.Location = new System.Drawing.Point(226, 257);
            this.lbQtdEstoque.Name = "lbQtdEstoque";
            this.lbQtdEstoque.Size = new System.Drawing.Size(22, 24);
            this.lbQtdEstoque.TabIndex = 2;
            this.lbQtdEstoque.Text = "--";
            // 
            // grvProduto
            // 
            this.grvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvProduto.Location = new System.Drawing.Point(20, 66);
            this.grvProduto.Name = "grvProduto";
            this.grvProduto.Size = new System.Drawing.Size(240, 168);
            this.grvProduto.TabIndex = 3;
            // 
            // grvVenda
            // 
            this.grvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvVenda.Location = new System.Drawing.Point(312, 66);
            this.grvVenda.Name = "grvVenda";
            this.grvVenda.Size = new System.Drawing.Size(240, 168);
            this.grvVenda.TabIndex = 4;
            // 
            // lbProduto
            // 
            this.lbProduto.AutoSize = true;
            this.lbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduto.Location = new System.Drawing.Point(15, 38);
            this.lbProduto.Name = "lbProduto";
            this.lbProduto.Size = new System.Drawing.Size(98, 25);
            this.lbProduto.TabIndex = 5;
            this.lbProduto.Text = "Produtos";
            // 
            // lbVenda
            // 
            this.lbVenda.AutoSize = true;
            this.lbVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVenda.Location = new System.Drawing.Point(307, 38);
            this.lbVenda.Name = "lbVenda";
            this.lbVenda.Size = new System.Drawing.Size(85, 25);
            this.lbVenda.TabIndex = 6;
            this.lbVenda.Text = "Vendas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 290);
            this.Controls.Add(this.lbVenda);
            this.Controls.Add(this.lbProduto);
            this.Controls.Add(this.grvVenda);
            this.Controls.Add(this.grvProduto);
            this.Controls.Add(this.lbQtdEstoque);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.lbEstoque);
            this.Name = "Form1";
            this.Text = "Sistema de Estoque";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEstoque;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Label lbQtdEstoque;
        private System.Windows.Forms.DataGridView grvProduto;
        private System.Windows.Forms.DataGridView grvVenda;
        private System.Windows.Forms.Label lbProduto;
        private System.Windows.Forms.Label lbVenda;
    }
}

