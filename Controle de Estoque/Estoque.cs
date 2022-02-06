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
    public partial class Estoque : Form
    {

        public Estoque()
        {
            InitializeComponent();
            DadosGuardados.listaBancoEstoque = DadosGuardados.getListaBancoEstoque();
        }



        private void Buscar_Load(object sender, EventArgs e)
        {

        }


        #region Botão Confirmar

        private void btnEstoqueConfirmar_Buscar_Click(object sender, EventArgs e)
        {
            dgvEstoque.Rows.Clear();

            if (txtEstoqueCodBarra.Text == ""  || txtEstoqueDestino.Text == "" )
            {
                lblbarra.Text = "*";
                lblDestino.Text = "*";
                MessageBox.Show("Os campos com * são obrigatorios!");

            }
            else
            {
                DadosGuardados.listaBancoEstoque.ForEach(x =>
                {
                    if (x.CodDeBarra.ToString("D10") == txtEstoqueCodBarra.Text)
                    {
                        x.Local = txtEstoqueDestino.Text;

                        dgvEstoque.ColumnCount = 8;

                        var rows = new List<string[]>();
                        string[] row1 = new string[] { x.NotaFiscal.ToString("D6"), x.CodDoProduto.ToString(),
                        x.Descricao, x.Quantidade.ToString(),x.UnidadeDeMedia,x.Local,x.Lote.ToShortDateString().Replace("/",""),x.CodDeBarra.ToString("D10") };
                        rows.Add(row1);

                        foreach (string[] item in rows)
                        {
                            dgvEstoque.Rows.Add(item);
                        }
                        lblbarra.Text = "";
                        lblDestino.Text = "";


                        txtEstoqueCodBarra.Text = "";
                        txtEstoqueCodItem.Text = "";
                        txtEstoqueDescricao.Text = "";
                        txtEstoqueLote.Text = "";
                        txtEstoqueQuantidade.Text = "";
                        txtEstoqueLocal.Text = "";
                        txtEstoqueDestino.Text = "";

                        MessageBox.Show("Movimentação realizada com sucesso!");
                    }
                });
            }
        }

        #endregion




        #region Botão Buscar

        //Botao de buscar
        private void btnEstoqueCodBarra_Buscar_Click(object sender, EventArgs e)
        {
            if (txtEstoqueCodBarra.Text == "")
            {
                lblbarra.Text = "*";
                MessageBox.Show("Os campos com * são obrigatorios!");
            }
            else
            {
                DadosGuardados.listaBancoEstoque.OrderBy(d => d.Lote);

                DadosGuardados.listaBancoEstoque.ForEach(x =>
                {
                    if (x.CodDeBarra.ToString("D10") == txtEstoqueCodBarra.Text)
                    {
                        txtEstoqueCodItem.Text = x.CodDoProduto.ToString();
                        txtEstoqueDescricao.Text = x.Descricao;
                        txtEstoqueCodItem.Text = x.CodDoProduto.ToString();
                        txtEstoqueLote.Text = x.Lote.ToShortDateString().Replace("/", "");
                        txtEstoqueQuantidade.Text = x.Quantidade.ToString();
                        txtEstoqueLocal.Text = x.Local;
                        lblbarra.Text = "";
                    }

                });
            }
        }

        #endregion




        #region Text Box Cod de Barra

        private void txtEstoqueCodBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}
