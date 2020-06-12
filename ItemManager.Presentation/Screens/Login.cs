using AutoMapper;
using ItemManager.Screens;
using Manager.Application.Services;
using System;
using System.Windows.Forms;

namespace ItemManager
{
    public partial class Login : Form
    {
        private readonly FuncionarioServices _funcionarioServices;
        private readonly ManagerOptions _managerOptions;

        // public Login()
        // {
        //     InitializeComponent();
        //     this.StartPosition = FormStartPosition.CenterScreen;
        // }

        public Login(FuncionarioServices funcionarioServices, ManagerOptions managerOptions)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _funcionarioServices = funcionarioServices;
            _managerOptions = managerOptions;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Preencha o login.");
            }
            else if (string.IsNullOrEmpty(passwordText.Text))
            {
                MessageBox.Show("O password não pode estar em branco.");
            }
            else
            {
                
                if (_funcionarioServices.CheckCredentials(idTextBox.Text, passwordText.Text))
                {
                    idTextBox.Text = null;
                    passwordText.Text = null;
                    _managerOptions.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Password incorreto");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
