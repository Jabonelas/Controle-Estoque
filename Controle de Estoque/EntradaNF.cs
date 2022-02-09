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
        public bool FeitaABuscaEntradaNF;

        public EntradaNF()
        {
            InitializeComponent();
            DadosGuardados.PreencherBanco();
        }


        #region Entrada Load

        private void EntradaNF_Load(object sender, EventArgs e)
        {
            if (DadosGuardados.PassouTela == true)
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("A NF Não Foi Confimanda, Deseja Salva-la!", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.No)
                {
                    int contmbox_NFRemovidaComSucesso = 1;

                    foreach (var itemBancoEstoque in DadosGuardados.listaBancoEstoque)
                    {
                        if (itemBancoEstoque.TesteParaVerificarSeFoiSalvaNotaFiscalSaida == true && itemBancoEstoque.TesteParaSaberSeFoiFaturadoZerandoSaldo == false)
                        {
                            foreach (var itemBancoSaidaNF in DadosGuardados.listaBancoSaidaNF)
                            {
                                if (itemBancoSaidaNF.NotaFiscalSaida.ToString() == DadosGuardados.NotaFiscalSaida.ToString() && itemBancoSaidaNF.TesteParaSaberSeFoiCanceladaSaidaNF == false)
                                {
                                    itemBancoSaidaNF.TesteParaSaberSeFoiCanceladaSaidaNF = true;

                                    itemBancoEstoque.Quantidade = itemBancoEstoque.Quantidade + itemBancoSaidaNF.Quantidade;

                                    DadosGuardados.listaBancoSaidaNF.Remove(itemBancoSaidaNF);

                                    itemBancoEstoque.Local = "PRODUÇÃO";

                                    DadosGuardados.PassouTela = false;

                                    if (contmbox_NFRemovidaComSucesso == 1)
                                    {
                                        MessageBox.Show("NF Removida com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        contmbox_NFRemovidaComSucesso++;
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
                    DadosGuardados.PassouTela = false;
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
                MessageBox.Show("Os Campos Com * São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (var itemBancoEntradaNF in DadosGuardados.listaEntradaNF)
                //DadosGuardados.listaEntradaNF.ForEach(x =>
                {
                    //foreach (var itemBancoEstoque in DadosGuardados.listaBancoEstoque)
                    //{

                    ///Preenche quando não foi dado entrada
                    if (itemBancoEntradaNF.NotaFiscalEntrada.ToString() == txtEntrada_NF.Text && itemBancoEntradaNF.TesteParaSaberSeFoiDadoEnatradaBancoEstoque == false && itemBancoEntradaNF.TesteParaDiferenciarItensDaMesmaNF == false)
                    {
                        dgvEntradaNF.ColumnCount = 12;

                        var rows = new List<string[]>();
                        string[] row1 = new string[] {itemBancoEntradaNF.NotaFiscalEntrada.ToString("D6"),itemBancoEntradaNF.CodDoProduto.ToString(),
                            itemBancoEntradaNF.Descricao,itemBancoEntradaNF.Fornecedor, itemBancoEntradaNF.Quantidade.ToString(),itemBancoEntradaNF.UnidadeDeMedia,itemBancoEntradaNF.Observavao,("R$ "+itemBancoEntradaNF.Valor.ToString("N2")),
                            itemBancoEntradaNF.Local,itemBancoEntradaNF.Emissao.ToShortDateString(),"------","------"};
                        rows.Add(row1);

                        foreach (string[] item in rows)
                        {
                            dgvEntradaNF.Rows.Add(item);
                        }

                        lblNotaFiscal.Text = "";

                    }
                    ///Preenche quando deu entrada
                    else if (itemBancoEntradaNF.NotaFiscalEntrada.ToString() == txtEntrada_NF.Text && itemBancoEntradaNF.TesteParaSaberSeFoiDadoEnatradaBancoEstoque == true && itemBancoEntradaNF.TesteParaDiferenciarItensDaMesmaNF == false)
                    {
                        dgvEntradaNF.ColumnCount = 12;
                        DateTime Lancamento = DateTime.Now;

                        foreach (var itemBancoEstoque in DadosGuardados.listaBancoEstoque)
                        {
                            if (itemBancoEstoque.NotaFiscal.ToString() == txtEntrada_NF.Text)
                            {

                                var rows = new List<string[]>();
                                string[] row1 = new string[] { itemBancoEstoque.NotaFiscal.ToString("D6"),itemBancoEstoque.CodDoProduto.ToString(),
                                itemBancoEstoque.Descricao,itemBancoEstoque.Fornecedor, itemBancoEstoque.Quantidade.ToString(),itemBancoEstoque.UnidadeDeMedia,itemBancoEntradaNF.Observavao,("R$ "+itemBancoEstoque.Valor.ToString("N2")),
                                itemBancoEstoque.Local,itemBancoEstoque.Emissao.ToShortDateString(),itemBancoEstoque.Lancamento.ToShortDateString(),itemBancoEstoque.CodDeBarra.ToString("D10")};
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
                    //}
                }

                FeitaABuscaEntradaNF = true;



                //});
            }
        }

        #endregion



        #region Botão Confirmar

        private void EntradaNF_Confirmar_Click(object sender, EventArgs e)
        {
            int contmbox_NFJaInformada = 1;
            int contmbox_EntradaComSucesso = 1;

            foreach (var itemBancoEntradaNF in DadosGuardados.listaEntradaNF)
            {
                //DadosGuardados.listaEntradaNF.ForEach(x =>
                // {
                if (itemBancoEntradaNF.TesteParaSaberSeFoiDadoEnatradaBancoEstoque == true && itemBancoEntradaNF.NotaFiscalEntrada.ToString() == txtEntrada_NF.Text && FeitaABuscaEntradaNF == true)
                {
                    contmbox_NFJaInformada++;
                    if (contmbox_NFJaInformada == 2)
                    {
                        MessageBox.Show("NF Já Informada!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (itemBancoEntradaNF.TesteParaSaberSeFoiDadoEnatradaBancoEstoque == false && itemBancoEntradaNF.TesteParaDiferenciarItensDaMesmaNF == false && itemBancoEntradaNF.NotaFiscalEntrada.ToString() == txtEntrada_NF.Text && FeitaABuscaEntradaNF == true)
                {
                    DateTime Lote = DateTime.Today;

                    Lote.ToString().Replace("/", "");

                    DadosGuardados.listaBancoEstoque.Add(new BancoEstoque(itemBancoEntradaNF.NotaFiscalEntrada, itemBancoEntradaNF.Descricao, itemBancoEntradaNF.Fornecedor, itemBancoEntradaNF.UnidadeDeMedia,
                        itemBancoEntradaNF.Quantidade, itemBancoEntradaNF.Observavao, itemBancoEntradaNF.Valor, itemBancoEntradaNF.Emissao, DateTime.Today, itemBancoEntradaNF.CodDoProduto, "RECEBIMENTO", DadosGuardados.CodigoDeBarra++,
                        Lote, itemBancoEntradaNF.TesteParaSaberSeFoiDadoEnatradaBancoEstoque = false, itemBancoEntradaNF.TesteParaDiferenciarItensDaMesmaNF = false, false));

                    itemBancoEntradaNF.TesteParaSaberSeFoiDadoEnatradaBancoEstoque = true;

                    contmbox_EntradaComSucesso++;
                    if (contmbox_EntradaComSucesso == 2)
                    {
                        DialogResult OpcaoDoUsuario = new DialogResult();
                        OpcaoDoUsuario = MessageBox.Show("Entrada Realizada Com Sucesso", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

                // });
            }
            FeitaABuscaEntradaNF = false;
            DadosGuardados.setListaBancoEstoque(DadosGuardados.listaBancoEstoque);
        }
        #endregion



        #region Botão Excluir

        private void btnEntradaNF_Excluir_Click(object sender, EventArgs e)
        {
            int contmbox_NFRemovidaComSucesso = 1;

            bool ChaveForeach = false; /// Teste para parar caso entre em Quantidade e Local Precisão Esta Igual a Origem.

            foreach (var itemBancoEntradaNF in DadosGuardados.listaEntradaNF)
            {
                if (ChaveForeach == true)
                {
                    break;
                }

                else if (itemBancoEntradaNF.TesteParaSaberSeFoiDadoEnatradaBancoEstoque == true && itemBancoEntradaNF.TesteParaDiferenciarItensDaMesmaNF == false && itemBancoEntradaNF.NotaFiscalEntrada.ToString() == txtEntrada_NF.Text && FeitaABuscaEntradaNF == true)
                {
                    foreach (var itemBancoEstoque in DadosGuardados.listaBancoEstoque)
                    {
                        if (ChaveForeach == true)
                        {
                            break;
                        }

                        foreach (var item in DadosGuardados.listaBancoEstoque)
                        {
                            if (item.NotaFiscal.ToString() == txtEntrada_NF.Text && item.Local != "RECEBIMENTO")// && itemBancoEstoque.TesteParaSaberSeHouveMovimentaçãoDoSaldo == true)
                            {
                                ChaveForeach = true;
                                MessageBox.Show("Quantidade e Local Precisão Esta Igual a Origem!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            }
                        }

                        if (ChaveForeach == false)
                        {

                            if (itemBancoEstoque.NotaFiscal.ToString() == txtEntrada_NF.Text && itemBancoEstoque.TesteParaSaberSeHouveMovimentaçãoDoSaldo == false)
                            {

                                // FeitaABuscaEntradaNF = false;
                                DadosGuardados.listaBancoEstoque.Remove(itemBancoEstoque);

                                contmbox_NFRemovidaComSucesso++;
                                 itemBancoEntradaNF.TesteParaSaberSeFoiDadoEnatradaBancoEstoque = false;
                                if (contmbox_NFRemovidaComSucesso == 2)
                                {
                                    MessageBox.Show("NF Removida Com Sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;

                            }
                        }
                    }
                }
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


        ///Preencher um GridView

        //        dgvBuscar.Rows.Clear();
        //            if (txtBuscarCodItem_NF.Text == "")
        //            {
        //                lblErroBuscar.Text = "*";
        //                MessageBox.Show("Os Campos Com * São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            }
        //            else
        //            {
        //                DadosGuardados.listaBancoEstoque.ForEach(itemBancoEstoque =>
        //                {
        //                    if (itemBancoEstoque.TesteParaSaberSeFoiFaturadoZerandoSaldo == false)
        //                    {

        //                        if (itemBancoEstoque.CodDoProduto.ToString() == txtBuscarCodItem_NF.Text)
        //                        {

        //                            dgvBuscar.ColumnCount = 8;
        //                            //dgvEstoque.Columns[0].Name = "Nota Fiscal";
        //                            //dgvEstoque.Columns[0].Width = 120;
        //                            //dgvEstoque.Columns[1].Name = "Codigo do item";
        //                            //dgvEstoque.Columns[1].Width = 180;
        //                            //dgvEstoque.Columns[2].Name = "Descricção do item";
        //                            //dgvEstoque.Columns[2].Width = 380;
        //                            //dgvEstoque.Columns[3].Name = "Quantidade";
        //                            //dgvEstoque.Columns[3].Width = 110;
        //                            //dgvEstoque.Columns[4].Name = "Unidade";
        //                            //dgvEstoque.Columns[4].Width = 80;
        //                            //dgvEstoque.Columns[4].Name = "Local";
        //                            //dgvEstoque.Columns[5].Width = 80;
        //                            //dgvEstoque.Columns[5].Name = "Codigo de Barras";
        //                            //dgvEstoque.Columns[6].Width = 180;

        //                            var rows = new List<string[]>();
        //    string[] row1 = new string[] { itemBancoEstoque.NotaFiscal.ToString("D6"), itemBancoEstoque.CodDoProduto.ToString(),
        //                        itemBancoEstoque.Descricao, itemBancoEstoque.Quantidade.ToString (),itemBancoEstoque.UnidadeDeMedia,itemBancoEstoque.Local,itemBancoEstoque.Lote.ToShortDateString().Replace("/",""),itemBancoEstoque.CodDeBarra.ToString("D10") };
        //    rows.Add(row1);

        //                            foreach (string[] item in rows)
        //                            {
        //                                dgvBuscar.Rows.Add(item);
        //                            }
        //lblErroBuscar.Text = "";
        //                        }
        //                    }
        //                });
        //}


        /// Usando Lambda como um Foreach

        //if (txtEntrada_NF.Text == "")
        //{
        //    lblNotaFiscal.Text = "*";
        //    MessageBox.Show("Os campos com * são obrigatorios!");
        //}
        //else
        //{
        //    DadosGuardados.listaEntradaNF.ForEach(x =>
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
        //    });
        //}

        /// fazendo com foreach

        //foreach (var item in lista)
        //{
        //    if (item.NotaFiscalEntrada.ToString() == txtEntrada_NF.Text)
        //    {

        //    }
        //}

        ///Busca e substituição por Lambda 

        //DadosGuardados.listaEntradaNF[DadosGuardados.listaEntradaNF.FindIndex(ind => ind.TesteParaSaberSeFoiDadoEnatradaBancoEstoque.Equals(true))].TesteParaSaberSeFoiDadoEnatradaBancoEstoque = false;
        #endregion
    }
}
