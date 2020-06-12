namespace ItemManager.Screens.Options
{
    partial class CadastrarItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarItem));
            this.imagemCadastroBox = new System.Windows.Forms.PictureBox();
            this.carregarImagemButton = new System.Windows.Forms.Button();
            this.removerImagemButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.categoriaCadastroCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.valorCadastroBox = new System.Windows.Forms.TextBox();
            this.DescricaoCadastroBox = new System.Windows.Forms.TextBox();
            this.NomeCadastroBox = new System.Windows.Forms.TextBox();
            this.cadastrarItemButton = new System.Windows.Forms.Button();
            this.cancelarItemButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagemCadastroBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imagemCadastroBox
            // 
            this.imagemCadastroBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("imagemCadastroBox.InitialImage")));
            this.imagemCadastroBox.Location = new System.Drawing.Point(30, 24);
            this.imagemCadastroBox.Name = "imagemCadastroBox";
            this.imagemCadastroBox.Size = new System.Drawing.Size(420, 237);
            this.imagemCadastroBox.TabIndex = 0;
            this.imagemCadastroBox.TabStop = false;
            // 
            // carregarImagemButton
            // 
            this.carregarImagemButton.Location = new System.Drawing.Point(30, 267);
            this.carregarImagemButton.Name = "carregarImagemButton";
            this.carregarImagemButton.Size = new System.Drawing.Size(194, 23);
            this.carregarImagemButton.TabIndex = 1;
            this.carregarImagemButton.Text = "Carregar Imagem";
            this.carregarImagemButton.UseVisualStyleBackColor = true;
            this.carregarImagemButton.Click += new System.EventHandler(this.carregarImagemButton_Click);
            // 
            // removerImagemButton
            // 
            this.removerImagemButton.Location = new System.Drawing.Point(253, 267);
            this.removerImagemButton.Name = "removerImagemButton";
            this.removerImagemButton.Size = new System.Drawing.Size(197, 23);
            this.removerImagemButton.TabIndex = 2;
            this.removerImagemButton.Text = "Remover Image";
            this.removerImagemButton.UseVisualStyleBackColor = true;
            this.removerImagemButton.Click += new System.EventHandler(this.removerImagemButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor:";
            // 
            // categoriaCadastroCombo
            // 
            this.categoriaCadastroCombo.FormattingEnabled = true;
            this.categoriaCadastroCombo.Location = new System.Drawing.Point(88, 379);
            this.categoriaCadastroCombo.Name = "categoriaCadastroCombo";
            this.categoriaCadastroCombo.Size = new System.Drawing.Size(121, 21);
            this.categoriaCadastroCombo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categoria:";
            // 
            // valorCadastroBox
            // 
            this.valorCadastroBox.Location = new System.Drawing.Point(88, 351);
            this.valorCadastroBox.Name = "valorCadastroBox";
            this.valorCadastroBox.Size = new System.Drawing.Size(100, 20);
            this.valorCadastroBox.TabIndex = 8;
            // 
            // DescricaoCadastroBox
            // 
            this.DescricaoCadastroBox.Location = new System.Drawing.Point(88, 322);
            this.DescricaoCadastroBox.Name = "DescricaoCadastroBox";
            this.DescricaoCadastroBox.Size = new System.Drawing.Size(100, 20);
            this.DescricaoCadastroBox.TabIndex = 9;
            // 
            // NomeCadastroBox
            // 
            this.NomeCadastroBox.Location = new System.Drawing.Point(88, 295);
            this.NomeCadastroBox.Name = "NomeCadastroBox";
            this.NomeCadastroBox.Size = new System.Drawing.Size(100, 20);
            this.NomeCadastroBox.TabIndex = 10;
            // 
            // cadastrarItemButton
            // 
            this.cadastrarItemButton.Location = new System.Drawing.Point(303, 302);
            this.cadastrarItemButton.Name = "cadastrarItemButton";
            this.cadastrarItemButton.Size = new System.Drawing.Size(75, 40);
            this.cadastrarItemButton.TabIndex = 11;
            this.cadastrarItemButton.Text = "Cadastrar";
            this.cadastrarItemButton.UseVisualStyleBackColor = true;
            this.cadastrarItemButton.Click += new System.EventHandler(this.cadastrarItemButton_Click);
            // 
            // cancelarItemButton
            // 
            this.cancelarItemButton.Location = new System.Drawing.Point(303, 348);
            this.cancelarItemButton.Name = "cancelarItemButton";
            this.cancelarItemButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarItemButton.TabIndex = 12;
            this.cancelarItemButton.Text = "Cancelar";
            this.cancelarItemButton.UseVisualStyleBackColor = true;
            this.cancelarItemButton.Click += new System.EventHandler(this.cancelarItemButton_Click);
            // 
            // CadastrarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 428);
            this.Controls.Add(this.cancelarItemButton);
            this.Controls.Add(this.cadastrarItemButton);
            this.Controls.Add(this.NomeCadastroBox);
            this.Controls.Add(this.DescricaoCadastroBox);
            this.Controls.Add(this.valorCadastroBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.categoriaCadastroCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removerImagemButton);
            this.Controls.Add(this.carregarImagemButton);
            this.Controls.Add(this.imagemCadastroBox);
            this.Name = "CadastrarItem";
            this.Text = "CadastrarItem";
            this.Load += new System.EventHandler(this.CadastrarItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagemCadastroBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagemCadastroBox;
        private System.Windows.Forms.Button carregarImagemButton;
        private System.Windows.Forms.Button removerImagemButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox categoriaCadastroCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox valorCadastroBox;
        private System.Windows.Forms.TextBox DescricaoCadastroBox;
        private System.Windows.Forms.TextBox NomeCadastroBox;
        private System.Windows.Forms.Button cadastrarItemButton;
        private System.Windows.Forms.Button cancelarItemButton;
    }
}