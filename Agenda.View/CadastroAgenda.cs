using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agenda.BLL;
using Agenda.DTO;

namespace Agenda.View
{
    public partial class CadastroAgenda : Form
    {
        public CadastroAgenda()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int r;

            Contato objContato = new Contato();
            objContato.Nome = txtNome.Text;
            objContato.Telefone = txtTelefone.Text;
            objContato.Email = txtEmail.Text;

            r = ContatoBLL.InserirContatoBLL(objContato);

            if (r == 1)
                MessageBox.Show("Contato cadastrado com sucesso!");
            else
                MessageBox.Show("Houve erros ao salvar um contato!");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
