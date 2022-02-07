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
                        if (itemBancoEstoque.TesteParaSeFoiFeitaMovimentaçãoNaQuant == true && itemBancoEstoque.TesteParaSaberSeFoiFaturadoZerandoAQuant == false)
                        {
                            foreach (var itemBancoSaidaNF in DadosGuardados.listaBancoSaidaNF)
                            {
                                if (itemBancoSaidaNF.NotaFiscalSaida.ToString() == DadosGuardados.NotaFiscalSaida.ToString() && itemBancoSaidaNF.TesteParaSaberSeFoiCanceladaSaidaNF == false)
                                {
                                    itemBancoSaidaNF.TesteParaSaberSeFoiCanceladaSaidaNF = true;

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
                    DadosGuardados.contParaGerarNotaFiscalDeSaida = 1;
                    DadosGuardados.NotaFiscalSaida++;
                }
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    DadosGuardados.contParaGerarNotaFiscalDeSaida = 1;
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
                    if (x.NotaFiscalEntrada.ToString() == txtEntrada_NF.Text && x.TesteParaSaberSeFoiDadoEnatradaBancoEstoque == false && x.TesteParaDiferenciarItensDaMesmaNF == false)
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
                    else if (x.NotaFiscalEntrada.ToString() == txtEntrada_NF.Text && x.TesteParaSaberSeFoiDadoEnatradaBancoEstoque == true && x.TesteParaDiferenciarItensDaMesmaNF == false)
                    {
                        dgvEntradaNF.ColumnCount = 11;
                        DateTime Lancamento = DateTime.Now;

                        foreach (var c in DadosGuardados.listaBancoEstoque)
                        {
                            if (c.NotaFiscal.ToString() == txtEntrada_NF.Text)
                            {

                                var rows = new List<string[]>();
                                string[] row1 = new string[] { c.NotaFiscal.ToString("D6"),c.CodDoProduto.ToString(),
                                c.Descricao,c.Fornecedor, c.Quantidade.ToString(),c.UnidadeDeMedia,x.Observavao,("R$ "+c.Valor.ToString("N2")),
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
            int contMessageBox_NFJaInformada = 1;
            int contMessageBox_EntradaComSucesso = 1;

            foreach (var x in DadosGuardados.listaNF)
            {
                //DadosGuardados.listaNF.ForEach(x =>
                // {
                if (x.TesteParaSaberSeFoiDadoEnatradaBancoEstoque == true && x.NotaFiscalEntrada.ToString() == txtEntrada_NF.Text)
                {
                    contMessageBox_NFJaInformada++;
                    if (contMessageBox_NFJaInformada == 2)
                    {
                        MessageBox.Show("NF Já Informada!");
                    }
                }
                else if (x.TesteParaSaberSeFoiDadoEnatradaBancoEstoque == false && x.TesteParaDiferenciarItensDaMesmaNF == false && x.NotaFiscalEntrada.ToString() == txtEntrada_NF.Text)
                {
                    DateTime Lote = DateTime.Today;

                    Lote.ToString().Replace("/", "");

                    DadosGuardados.listaBancoEstoque.Add(new BancoEstoque(x.NotaFiscalEntrada, x.Descricao, x.Fornecedor, x.UnidadeDeMedia,
                        x.Quantidade, x.Observavao, x.Valor, x.Emissao, DateTime.Today, x.CodDoProduto, "RECEBIMENTO", DadosGuardados.CodigoDeBarra++,
                        Lote, x.TesteParaSaberSeFoiDadoEnatradaBancoEstoque = false, x.TesteParaDiferenciarItensDaMesmaNF = false));

                    x.TesteParaSaberSeFoiDadoEnatradaBancoEstoque = true;

                    contMessageBox_EntradaComSucesso++;
                    if (contMessageBox_EntradaComSucesso == 2)
                    {
                        DialogResult OpcaoDoUsuario = new DialogResult();
                        OpcaoDoUsuario = MessageBox.Show("Entrada Realizada Com Sucesso", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

                // });
            }

            DadosGuardados.setListaBancoEstoque(DadosGuardados.listaBancoEstoque);
        }
        #endregion



        #region Botão Excluir

        private void btnEntradaNF_Excluir_Click(object sender, EventArgs e)
        {
            int contMessageBoxQuant = 1;

            foreach (var item1 in DadosGuardados.listaNF)
            {
                if (item1.TesteParaSaberSeFoiDadoEnatradaBancoEstoque == true && item1.TesteParaDiferenciarItensDaMesmaNF == false && item1.NotaFiscalEntrada.ToString() == txtEntrada_NF.Text)
                {
                    foreach (var item2 in DadosGuardados.listaBancoEstoque)
                    {
                        if (item2.NotaFiscal.ToString() == txtEntrada_NF.Text)
                        {
                           // if (item2.Quantidade == item1.Quantidade && item2.Local == item1.Local)
                            //{
                                DadosGuardados.listaBancoEstoque.Remove(item2);
                                contMessageBoxQuant++;
                                if (contMessageBoxQuant == 2)
                                {
                                    MessageBox.Show("NF Removida Com Sucesso!");
                                }
                                break;
                           // }
                            //else
                            //{
                            //    contMessageBoxQuant++;
                            //    if (contMessageBoxQuant == 2)
                            //    {
                            //        DialogResult OpcaoDoUsuario = new DialogResult();
                            //        OpcaoDoUsuario = MessageBox.Show("Quantidade ou Local Diferente da Origem", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //    }
                            //       break;
                            //}
                        }

                    }
                }
                item1.TesteParaSaberSeFoiDadoEnatradaBancoEstoque = false;
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
        //        if (x.NotaFiscalEntrada.ToString() == txtEntrada_NF.Text && x.TesteParaSaberSeFoiDadoEnatradaBancoEstoque == false)
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
        //        else if (x.NotaFiscalEntrada.ToString() == txtEntrada_NF.Text && x.TesteParaSaberSeFoiDadoEnatradaBancoEstoque == true)
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


        //DadosGuardados.listaNF[DadosGuardados.listaNF.FindIndex(ind => ind.TesteParaSaberSeFoiDadoEnatradaBancoEstoque.Equals(true))].TesteParaSaberSeFoiDadoEnatradaBancoEstoque = false;
        #endregion
    }
}
