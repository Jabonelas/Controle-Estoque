using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Estoque
{
    public partial class Form1 : Form
    {
    

        public Form1()
        {
            InitializeComponent();
            
            
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void loadform(object Form)
        {
            if (TelaInicial.Controls.Count > 0)
                TelaInicial.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            TelaInicial.Controls.Add(f);
            TelaInicial.Tag = f;
            f.Show();
        }

        // Tela de Entrada de NF
        private void EntradaNF_Click(object sender, EventArgs e)
        {
            loadform(new EntradaNF());

        }

        // Tela de Buscar
        private void Buscar_Click(object sender, EventArgs e)
        {
            loadform(new Estoque());
        }

        // Tela de Estoque
        private void Estoque_Click(object sender, EventArgs e)
        {
            loadform(new Buscar());
        }

        // Tela de SaidaNF
        private void SaidaNF_Click(object sender, EventArgs e)
        {
            loadform(new SaidaNF());
        }
    }
}
