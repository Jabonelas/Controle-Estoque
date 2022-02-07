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

        public bool buscarOK;
        public Estoque()
        {
            InitializeComponent();
            DadosGuardados.listaBancoEstoque = DadosGuardados.getListaBancoEstoque();
            DadosGuardados.PreencherBanco1();
        }



        #region Buscar Load


        private void Buscar_Load(object sender, EventArgs e)
        {
            if (DadosGuardados.PassarTela == false)
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("A NF Não Foi Confimanda, Deseja Salva-la!", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.No)
                {
                    int cont = 1;

                    foreach (var itemBancoEstoque in DadosGuardados.listaBancoEstoque)
                    {
                        if (itemBancoEstoque.TesteParaEntrada3 == true && itemBancoEstoque.TesteParaEntrada4 == false)
                        {
                            foreach (var itemBancoSaidaNF in DadosGuardados.listaBancoSaidaNF)
                            {
                                if (itemBancoSaidaNF.NotaFiscalSaida.ToString() == DadosGuardados.NotaFiscalSaida.ToString() && itemBancoSaidaNF.TesteParaEntrada5 == false)
                                {
                                    itemBancoSaidaNF.TesteParaEntrada5 = true;

                                    itemBancoEstoque.Quantidade = itemBancoEstoque.Quantidade + itemBancoSaidaNF.Quantidade;

                                    DadosGuardados.listaBancoSaidaNF.Remove(itemBancoSaidaNF);

                                    itemBancoEstoque.Local = "PRODUÇÃO";

                                    DadosGuardados.PassarTela = true;

                                    if (cont == 1)
                                    {
                                        MessageBox.Show("NF Removida com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cont++;
                                    }
                                }
                                break;
                            }
                        }
                    }
                    DadosGuardados.cont1 = 1;
                    DadosGuardados.NotaFiscalSaida++;
                }
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    DadosGuardados.cont1 = 1;
                    DadosGuardados.NotaFiscalSaida++;
                    DadosGuardados.PassarTela = true;
                    MessageBox.Show("NF Confirmada com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        #endregion




        #region Botão Confirmar

        private void btnEstoqueConfirmar_Buscar_Click(object sender, EventArgs e)
        {
            dgvEstoque.Rows.Clear();


            if (txtEstoqueCodBarra.Text == "" || txtEstoqueDestino.Text == "")
            {
                lblbarra.Text = "*";
                lblDestino.Text = "*";
                MessageBox.Show("Os campos com * são obrigatorios!");
            }
            else
            {
                DadosGuardados.listaBancoEstoque.ForEach(x =>
                {
                    if (x.CodDeBarra.ToString("D10") == txtEstoqueCodBarra.Text && buscarOK == true)
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

                        buscarOK = false;

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

                //DadosGuardados.listaBancoEstoque.ForEach(x =>
                foreach (var x in DadosGuardados.listaBancoEstoque)
                {







                    if (x.CodDeBarra.ToString("D10") == txtEstoqueCodBarra.Text)
                    {
                        foreach (var item in DadosGuardados.listaBancoEstoque)
                        {
                            if (item.CodDoProduto == x.CodDoProduto && x.CodDeBarra == item.CodDeBarra)
                            {
                                txtEstoqueCodItem.Text = x.CodDoProduto.ToString();
                                txtEstoqueDescricao.Text = x.Descricao;
                                txtEstoqueCodItem.Text = x.CodDoProduto.ToString();
                                txtEstoqueLote.Text = x.Lote.ToShortDateString().Replace("/", "");
                                txtEstoqueQuantidade.Text = x.Quantidade.ToString();
                                txtEstoqueLocal.Text = x.Local;
                                lblbarra.Text = "";

                                buscarOK = true;
                                MessageBox.Show("ok é o da vez");
                                break;
                            }
                            else if (item.CodDoProduto == x.CodDoProduto && item.CodDeBarra != x.CodDeBarra)
                            {
                                MessageBox.Show("não é o da vez");
                                break;
                            }
                        }














                    }

                }//);
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
