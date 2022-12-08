using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class frmfrutas : Form
    {
        public frmfrutas()
        {
            InitializeComponent();
        }

        private void btnselecionar_Click(object sender, EventArgs e)
        {
            int operador;
            string frutas = "";

            operador = int.Parse(txtbdigitarfruta.Text);

            switch (operador)
            {
                case 1: frutas = "Banana";
                    break;
                case 2: frutas = "maça";
                    break;
                case 3:
                    frutas = "Pera";
                    break;
                case 4:
                    frutas = "melancia";
                    break;
                default: frutas = "Nenhuma fruta selecionada.";
                    break;
            }
            txtselecione.Text= frutas;
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            //executar o método criado
            limparcampos();
        }
        //criar um método para limpar os componentes 
        public void limparcampos()
        {
            txtbdigitarfruta.Clear();
            txtselecione.Text = "";
            ltbFrutas.Items.Clear();
            cdbfrutaslistadas.Text = "";

            txtbdigitarfruta.Focus();
        }

        private void ltbFrutas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            ltbFrutas.Items.Clear();
            ltbFrutas.Items.Add(txtselecione.Text);

            cdbfrutaslistadas.Items.Add(txtselecione.Text);

        }

        private void cdbfrutaslistadas_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
