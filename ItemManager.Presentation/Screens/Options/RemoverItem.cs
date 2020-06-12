using Manager.Application.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemManager.Screens.Options
{
    public partial class RemoverItem : Form
    {
        private readonly ItemServices _itemServices;
        public RemoverItem(ItemServices itemServices)
        {
            InitializeComponent();
            _itemServices = itemServices;
        }
        int searchedId = 0;
        private void idBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pesquisarButton_Click(object sender, EventArgs e)
        {
            int.TryParse(idBox.Text, out int id);
            var result = _itemServices.GetItemById(id);
            descricaoBox.Text = result.Descricao;
            var ms = new MemoryStream(_itemServices.CarregarImagem(id));
            imageBox.Image = Image.FromStream(ms);
            searchedId = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (searchedId != 0)
            {
                DialogResult dialogResult = MessageBox.Show(string.Concat("Excluir item: ", searchedId, ", ", descricaoBox.Text), "Cancelar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Item excluído com sucesso!");
                    _itemServices.ExcluirItem(searchedId);
                }
                else
                {
                    MessageBox.Show("Ok, o item não foi excluído.");
                }
            }
            else
            {
                MessageBox.Show("Você deve pesquisar o item que irá excluir.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
