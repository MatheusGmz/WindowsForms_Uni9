namespace ItemManager.Screens.Options
{
    partial class AlterarDesconto
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
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.aplicarDescontoButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.percentualBox = new System.Windows.Forms.TextBox();
            this.idSearchBox = new System.Windows.Forms.TextBox();
            this.valorItemBox = new System.Windows.Forms.TextBox();
            this.searchItemButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageBox
            // 
            this.ImageBox.Location = new System.Drawing.Point(37, 22);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(163, 151);
            this.ImageBox.TabIndex = 0;
            this.ImageBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Percentual: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Valor do item:";
            // 
            // aplicarDescontoButton
            // 
            this.aplicarDescontoButton.Location = new System.Drawing.Point(19, 285);
            this.aplicarDescontoButton.Name = "aplicarDescontoButton";
            this.aplicarDescontoButton.Size = new System.Drawing.Size(75, 23);
            this.aplicarDescontoButton.TabIndex = 6;
            this.aplicarDescontoButton.Text = "Aplicar";
            this.aplicarDescontoButton.UseVisualStyleBackColor = true;
            this.aplicarDescontoButton.Click += new System.EventHandler(this.aplicarDescontoButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(100, 285);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 7;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(88, 201);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionBox.TabIndex = 9;
            // 
            // percentualBox
            // 
            this.percentualBox.Location = new System.Drawing.Point(88, 225);
            this.percentualBox.Name = "percentualBox";
            this.percentualBox.Size = new System.Drawing.Size(100, 20);
            this.percentualBox.TabIndex = 10;
            this.percentualBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // idSearchBox
            // 
            this.idSearchBox.Location = new System.Drawing.Point(88, 179);
            this.idSearchBox.Name = "idSearchBox";
            this.idSearchBox.Size = new System.Drawing.Size(100, 20);
            this.idSearchBox.TabIndex = 11;
            // 
            // valorItemBox
            // 
            this.valorItemBox.Location = new System.Drawing.Point(88, 251);
            this.valorItemBox.Name = "valorItemBox";
            this.valorItemBox.ReadOnly = true;
            this.valorItemBox.Size = new System.Drawing.Size(100, 20);
            this.valorItemBox.TabIndex = 12;
            // 
            // searchItemButton
            // 
            this.searchItemButton.Location = new System.Drawing.Point(194, 179);
            this.searchItemButton.Name = "searchItemButton";
            this.searchItemButton.Size = new System.Drawing.Size(56, 20);
            this.searchItemButton.TabIndex = 13;
            this.searchItemButton.Text = "Procurar";
            this.searchItemButton.UseVisualStyleBackColor = true;
            this.searchItemButton.Click += new System.EventHandler(this.searchItemButton_Click);
            // 
            // AlterarDesconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 329);
            this.Controls.Add(this.searchItemButton);
            this.Controls.Add(this.valorItemBox);
            this.Controls.Add(this.idSearchBox);
            this.Controls.Add(this.percentualBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.aplicarDescontoButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImageBox);
            this.Name = "AlterarDesconto";
            this.Text = "AlterarDesconto";
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button aplicarDescontoButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TextBox percentualBox;
        private System.Windows.Forms.TextBox idSearchBox;
        private System.Windows.Forms.TextBox valorItemBox;
        private System.Windows.Forms.Button searchItemButton;
    }
}