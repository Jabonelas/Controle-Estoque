using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Estoque
{
    public partial class EntradaNF : Form
    {
        public EntradaNF()
        {
            InitializeComponent();
            DadosGuardados.PreencherBanco();
            DadosGuardados.PreencherBanco1();
        }

        #region Entrada Load

        private void EntradaNF_Load(object sender, EventArgs e)
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





        #region Botão buscar

        private void EntradaNF_Buscar_Click(object sender, EventArgs e)
        {
            dgvEntradaNF.Rows.Clear();


            if (txtEntrada_NF.Text == "")
            {
                lblNotaFiscal.Text = "*";
                MessageBox.Show("Os Campos Com * São Obrigatorios!");
            }
            else
            {

                foreach (var x in DadosGuardados.listaNF)
                //DadosGuardados.listaNF.ForEach(x =>
                {
                    if (x.NotaFiscalEntrada.ToString() == txtEntrada_NF.Text && x.TesteParaEntrada1 == false && x.TesteParaEntrada2 == false)
                    {
                        dgvEntradaNF.ColumnCount = 11;

                        var rows = new List<string[]>();
                        string[] row1 = new string[] { x.NotaFiscalEntrada.ToString("D6"),x.CodDoProduto.ToString(),
                        x.Descricao,x.Fornecedor, x.Quantidade.ToString(),x.UnidadeDeMedia,x.Observavao,("R$ "+x.Valor.ToString("N2")),
                        x.Local,x.Emissao.ToShortDateString()};
                        rows.Add(row1);

                        foreach (string[] item in rows)
                        {
                            dgvEntradaNF.Rows.Add(item);
                        }
                        lblNotaFiscal.Text = "";
                    }
                    else if (x.NotaFiscalEntrada.ToString() == txtEntrada_NF.Text && x.TesteParaEntrada1 == true && x.TesteParaEntrada2 == false)
                    {
                        dgvEntradaNF.ColumnCount = 11;
                        DateTime Lancamento = DateTime.Now;

                        foreach (var c in DadosGuardados.listaBancoEstoque)
                        {
                            if (c.NotaFiscal.ToString() == txtEntrada_NF.Text)
                            {

                                var rows = new List<string[]>();
                                string[] row1 = new string[] { c.NotaFiscal.ToString("D6"),c.CodDoProduto.ToString(),
                                c.Descricao,c.Fornecedor, x.Quantidade.ToString(),c.UnidadeDeMedia,x.Observavao,("R$ "+x.Valor.ToString("N2")),
                                c.Local,c.Emissao.ToShortDateString(),c.Lancamento.ToShortDateString()};
                                rows.Add(row1);
                                foreach (string[] item in rows)
                                {
                                    dgvEntradaNF.Rows.Add(item);
                                }

                                lblNotaFiscal.Text = "";
                            }
                        }
                        break;
                    }
                }
                //});
            }
        }

        #endregion



        #region Botão Confirmar

        private void EntradaNF_Confirmar_Click(object sender, EventArgs e)
        {
            int cont = 1;
            foreach (var x in DadosGuardados.listaNF)
            {
                //DadosGuardados.listaNF.ForEach(x =>
                // {
                if (x.TesteParaEntrada1 == true && x.NotaFiscalEntrada.ToString() == txtEntrada_NF.Text)
                {
                    cont++;
                    if (cont == 2)
                    {
                        MessageBox.Show("NF Já Informada!");
                    }
                }
                else if (x.TesteParaEntrada1 == false && x.TesteParaEntrada2 == false && x.NotaFiscalEntrada.ToString() == txtEntrada_NF.Text)
                {
                    DateTime Lote = DateTime.Today;

                    Lote.ToString().Replace("/", "");

                    DadosGuardados.listaBancoEstoque.Add(new BancoEstoque(x.NotaFiscalEntrada, x.Descricao, x.Fornecedor, x.UnidadeDeMedia,
                        x.Quantidade, x.Observavao, x.Valor, x.Emissao, DateTime.Today, x.CodDoProduto, "RECEBIMENTO", DadosGuardados.CodigoDeBarra++,
                        Lote, x.TesteParaEntrada1 = false, x.TesteParaEntrada2 = false));

                    x.TesteParaEntrada1 = true;

                    cont++;
                    if (cont == 2)
                    {
                        MessageBox.Show("Entrada Com Sucesso!");
                    }
                }
                // });
            }

            DadosGuardados.setListaBancoEstoque(DadosGuardados.listaBancoEstoque);
        }
        #endregion



        #region Botão Excluir
        // Botão de excluir
        private void btnEntradaNF_Excluir_Click(object sender, EventArgs e)
        {
            int cont = 1;

            foreach (var item1 in DadosGuardados.listaNF)
            {
                if (item1.TesteParaEntrada1 == true && item1.TesteParaEntrada2 == false && item1.NotaFiscalEntrada.ToString() == txtEntrada_NF.Text)
                {
                    foreach (var item2 in DadosGuardados.listaBancoEstoque)
                    {
                        if (item2.NotaFiscal.ToString() == txtEntrada_NF.Text)
                        {
                            DadosGuardados.listaBancoEstoque.Remove(item2);
                            cont++;
                            if (cont == 2)
                            {
                                MessageBox.Show("NF Removida Com Sucesso!");
                            }
                        }
                        break;
                    }
                }
                item1.TesteParaEntrada1 = false;
            }

        }
        #endregion



        #region Text Box Nota Fiscal
        private void txtEntrada_NF_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion



        #region Rascunho de Codigos

        //if (txtEntrada_NF.Text == "")
        //{
        //    lblNotaFiscal.Text = "*";
        //    MessageBox.Show("Os campos com * são obrigatorios!");
        //}
        //else
        //{
        //    DadosGuardados.listaNF.ForEach(x =>
        //    {
        //        if (x.NotaFiscalEntrada.ToString() == txtEntrada_NF.Text && x.TesteParaEntrada1 == false)
        //        {
        //            txtEntrada_Descricao.Text = x.Descricao;
        //            txtEntrada_Fornecedor.Text = x.Fornecedor;
        //            txtEntrada_Unidade.Text = x.UnidadeDeMedia;
        //            txtEntrada_Quantidade.Text = x.Quantidade.ToString();
        //            txtEntrada_Observação.Text = x.Observavao;
        //            txtEntrada_Valor.Text = ("R$ " + x.Valor);
        //            txtEntrada_Emissao.Text = Convert.ToDateTime(x.Emissao.ToString()).ToShortDateString();
        //            txtEntrada_Lancamento.Text = "";
        //            txtEntrada_Cod.Text = x.CodDoProduto.ToString();
        //            lblNotaFiscal.Text = "";
        //        }
        //        else if (x.NotaFiscalEntrada.ToString() == txtEntrada_NF.Text && x.TesteParaEntrada1 == true)
        //        {
        //            txtEntrada_Descricao.Text = x.Descricao;
        //            txtEntrada_Fornecedor.Text = x.Fornecedor;
        //            txtEntrada_Unidade.Text = x.UnidadeDeMedia;
        //            txtEntrada_Quantidade.Text = x.Quantidade.ToString();
        //            txtEntrada_Observação.Text = x.Observavao;
        //            txtEntrada_Valor.Text = ("R$ " + x.Valor);
        //            txtEntrada_Emissao.Text = Convert.ToDateTime(x.Emissao.ToString()).ToShortDateString();
        //            DadosGuardados.listaBancoEstoque.ForEach(c =>
        //            {
        //                txtEntrada_Lancamento.Text = Convert.ToDateTime(c.Lancamento.ToString()).ToShortDateString();
        //            });
        //            txtEntrada_Cod.Text = x.CodDoProduto.ToString();
        //            lblNotaFiscal.Text = "";
        //            MessageBox.Show("NF já foi dado entrada");
        //        }
        //    });
        //}

        /// fazendo com foreach

        //foreach (var item in lista)
        //{
        //    if (item.NotaFiscalEntrada.ToString() == txtEntrada_NF.Text)
        //    {

        //    }
        //}


        //DadosGuardados.listaNF[DadosGuardados.listaNF.FindIndex(ind => ind.TesteParaEntrada1.Equals(true))].TesteParaEntrada1 = false;
        #endregion
    }
}
