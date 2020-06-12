using Manager.Application.Services;
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
    public partial class AlterarDesconto : Form
    {
        private readonly ItemServices _itemServices;
        public AlterarDesconto(ItemServices servives)
        {
            InitializeComponent();
            _itemServices = servives;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void searchItemButton_Click(object sender, EventArgs e)
        {
            try
            {

                var id = int.TryParse(idSearchBox.Text, out int idConverted);
                if (id)
                {
                    var item = _itemServices.GetItemById(idConverted);
                    var ms = new MemoryStream(_itemServices.CarregarImagem(idConverted));
                    ImageBox.Image = Image.FromStream(ms);
                    descriptionBox.Text = item.Descricao;
                    valorItemBox.Text = item.ValorUnidade.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void aplicarDescontoButton_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(idSearchBox.Text, out int idConverted);
                decimal.TryParse(percentualBox.Text, out decimal valorConverted);
                _itemServices.AplicarDesconto(idConverted, valorConverted);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
