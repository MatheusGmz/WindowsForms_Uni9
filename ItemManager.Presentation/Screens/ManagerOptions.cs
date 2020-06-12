using ItemManager.Screens.Options;
using System;
using System.Windows.Forms;

namespace ItemManager.Screens
{
    public partial class ManagerOptions : Form
    {
        private readonly AlterarDesconto _alterarDesconto;
        private readonly CadastrarItem _cadastrarItem;
        private readonly RemoverItem _removerItem;
        public ManagerOptions(AlterarDesconto alterarDesconto, CadastrarItem cadastrarItem, RemoverItem removerItem)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _alterarDesconto = alterarDesconto;
            _cadastrarItem = cadastrarItem;
            _removerItem = removerItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _cadastrarItem.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _removerItem.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _alterarDesconto.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var consultarPedido = new ConsultarPedido();
            consultarPedido.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var atualizarPedido = new AtualizarPedido();
            atualizarPedido.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
