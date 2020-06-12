using ItemManager.Domain.Entities;
using Manager.Application.Services;
using Microsoft.EntityFrameworkCore.SqlServer.Update.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemManager.Screens.Options
{
    public partial class CadastrarItem : Form
    {
        private readonly ItemServices _itemServices;
        public CadastrarItem(ItemServices itemServices)
        {
            InitializeComponent();
            _itemServices = itemServices;
        }
        private void cadastrarItemButton_Click(object sender, EventArgs e)
        {
            var decimalConvert = decimal.TryParse(valorCadastroBox.Text, out decimal valor);
            if (decimalConvert)
            {
                try
                {
                    var ms = new MemoryStream();
                    imagemCadastroBox.Image.Save(ms, imagemCadastroBox.Image.RawFormat);
                    var item = new Item()
                    {
                        Descricao = DescricaoCadastroBox.Text,
                        ValorUnidade = valor,
                        PercentualDesconto = 0,
                        Imagem = ms.ToArray()
                    };
                    _itemServices.RegisterItem(item);
                    DescricaoCadastroBox.Text = null;
                    valorCadastroBox.Text = null;
                    imagemCadastroBox.Image = null;

                    MessageBox.Show("Item cadastrado com sucesso!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("O valor do item deve ser numerico.");
            }


        }

        private void carregarImagemButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (file.ShowDialog() == DialogResult.OK)
            {
                imagemCadastroBox.Image = new Bitmap(file.FileName);
                imagemCadastroBox.Location = Location;
            }
        }

        private void cancelarItemButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removerImagemButton_Click(object sender, EventArgs e)
        {
            imagemCadastroBox.Image = null;
        }

        private void CadastrarItem_Load(object sender, EventArgs e)
        {

        }
    }
}
