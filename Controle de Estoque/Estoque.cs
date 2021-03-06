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

        public bool FeitaABuscaEstoque;
        public Estoque()
        {
            InitializeComponent();
            DadosGuardados.listaBancoEstoque = DadosGuardados.getListaBancoEstoque();
        }



        #region Buscar Load

        private void Buscar_Load(object sender, EventArgs e)
        {
            if (DadosGuardados.PassouTela == true)
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("A NF Não Foi Confirmada, Deseja Salva-la?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.No)
                {
                    int contmbox_NFREmovidaComSucesso = 1;

                    foreach (BancoEstoque itemBancoEstoque in DadosGuardados.listaBancoEstoque)
                    {
                        if (itemBancoEstoque.TesteParaVerificarSeFoiSalvaNotaFiscalSaida == true && itemBancoEstoque.TesteParaSaberSeFoiFaturadoZerandoSaldo == false)
                        {
                            foreach (BancoSaidaNF itemBancoSaidaNF in DadosGuardados.listaBancoSaidaNF)
                            {
                                if (itemBancoSaidaNF.NotaFiscalSaida.ToString() == DadosGuardados.NotaFiscalSaida.ToString() && itemBancoSaidaNF.TesteParaSaberSeFoiCanceladaSaidaNF == false)
                                {
                                    itemBancoSaidaNF.TesteParaSaberSeFoiCanceladaSaidaNF = true;

                                    itemBancoEstoque.Quantidade = itemBancoEstoque.Quantidade + itemBancoSaidaNF.Quantidade;

                                    DadosGuardados.listaBancoSaidaNF.Remove(itemBancoSaidaNF);

                                    itemBancoEstoque.Local = "PRODUÇÃO";

                                    DadosGuardados.PassouTela = false;

                                    if (contmbox_NFREmovidaComSucesso == 1)
                                    {
                                        MessageBox.Show("NF Removida com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        contmbox_NFREmovidaComSucesso++;
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




        #region Botão Confirmar

        private void btnEstoqueConfirmar_Buscar_Click(object sender, EventArgs e)
        {
            dgvEstoque.Rows.Clear();

            if (txtEstoqueCodBarra.Text == "" || txtEstoqueDestino.Text == "")
            {
                lblbarra.Text = "*";
                lblDestino.Text = "*";
                MessageBox.Show("Os campos com * são obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //DadosGuardados.listaBancoEstoque.ForEach(x =>
                foreach (BancoEstoque itemBancoEstoque in DadosGuardados.listaBancoEstoque)

                {
                    if (itemBancoEstoque.CodDeBarra.ToString("D10") == txtEstoqueCodBarra.Text && itemBancoEstoque.TesteParaSaberSeHouveMovimentaçãoDoSaldo == false)
                    {

                        foreach (BancoEstoque itemBancoEstoque2 in DadosGuardados.listaBancoEstoque)
                        {
                            if (itemBancoEstoque2.TesteParaSaberSeFoiFaturadoZerandoSaldo == false)
                            {
                                if (txtEstoqueDestino.Text == "PRODUÇÃO")
                                {
                                    if (itemBancoEstoque2.CodDoProduto == itemBancoEstoque.CodDoProduto && itemBancoEstoque.CodDeBarra == itemBancoEstoque2.CodDeBarra)
                                    {

                                        txtEstoqueCodItem.Text = itemBancoEstoque.CodDoProduto.ToString();
                                        txtEstoqueDescricao.Text = itemBancoEstoque.Descricao;
                                        txtEstoqueCodItem.Text = itemBancoEstoque.CodDoProduto.ToString();
                                        txtEstoqueLote.Text = itemBancoEstoque.Lote.ToShortDateString().Replace("/", "");
                                        txtEstoqueQuantidade.Text = itemBancoEstoque.Quantidade.ToString();
                                        txtEstoqueLocal.Text = itemBancoEstoque.Local;
                                        lblbarra.Text = "";

                                        itemBancoEstoque.Local = txtEstoqueDestino.Text;

                                        dgvEstoque.ColumnCount = 8;

                                        var rows = new List<string[]>();
                                        string[] row1 = new string[] { itemBancoEstoque.NotaFiscal.ToString("D6"),"-------", itemBancoEstoque.CodDoProduto.ToString(),
                                        itemBancoEstoque.Descricao, itemBancoEstoque.Quantidade.ToString(),itemBancoEstoque.UnidadeDeMedia,itemBancoEstoque.Local,itemBancoEstoque.Lote.ToShortDateString().Replace("/",""),itemBancoEstoque.CodDeBarra.ToString("D10") };
                                        rows.Add(row1);

                                        foreach (string[] item in rows)
                                        {
                                            dgvEstoque.Rows.Add(item);
                                        }
                                        lblbarra.Text = "";
                                        lblDestino.Text = "";

                                        FeitaABuscaEstoque = false;

                                        DialogResult OpcaoDoUsuario = new DialogResult();
                                        OpcaoDoUsuario = MessageBox.Show("Movimentação Realizada Com Sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        if (OpcaoDoUsuario == DialogResult.OK)
                                        {
                                            txtEstoqueCodBarra.Text = "";
                                            txtEstoqueCodItem.Text = "";
                                            txtEstoqueDescricao.Text = "";
                                            txtEstoqueCodItem.Text = "";
                                            txtEstoqueLote.Text = "";
                                            txtEstoqueQuantidade.Text = "";
                                            txtEstoqueLocal.Text = "";
                                            txtEstoqueDestino.Text = "";
                                            lblbarra.Text = "";
                                        }

                                        break;
                                    }
                                    else if (itemBancoEstoque2.CodDoProduto == itemBancoEstoque.CodDoProduto && itemBancoEstoque2.CodDeBarra != itemBancoEstoque.CodDeBarra)
                                    {
                                        DialogResult OpcaoDoUsuario = new DialogResult();
                                        OpcaoDoUsuario = MessageBox.Show("Etiqueta Bloqueada por FIFO!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        if (OpcaoDoUsuario == DialogResult.OK)
                                        {
                                            txtEstoqueCodBarra.Text = "";
                                            txtEstoqueCodItem.Text = "";
                                            txtEstoqueDescricao.Text = "";
                                            txtEstoqueCodItem.Text = "";
                                            txtEstoqueLote.Text = "";
                                            txtEstoqueQuantidade.Text = "";
                                            txtEstoqueLocal.Text = "";
                                            lblbarra.Text = "";
                                        }

                                        FeitaABuscaEstoque = false;

                                        break;
                                    }
                                }
                                else
                                {
                                    txtEstoqueCodItem.Text = itemBancoEstoque.CodDoProduto.ToString();
                                    txtEstoqueDescricao.Text = itemBancoEstoque.Descricao;
                                    txtEstoqueCodItem.Text = itemBancoEstoque.CodDoProduto.ToString();
                                    txtEstoqueLote.Text = itemBancoEstoque.Lote.ToShortDateString().Replace("/", "");
                                    txtEstoqueQuantidade.Text = itemBancoEstoque.Quantidade.ToString();
                                    txtEstoqueLocal.Text = itemBancoEstoque.Local;
                                    lblbarra.Text = "";

                                    itemBancoEstoque.Local = txtEstoqueDestino.Text;

                                    dgvEstoque.ColumnCount = 8;

                                    var rows = new List<string[]>();
                                    string[] row1 = new string[] { itemBancoEstoque.NotaFiscal.ToString("D6"), itemBancoEstoque.CodDoProduto.ToString(),
                                    itemBancoEstoque.Descricao, itemBancoEstoque.Quantidade.ToString(),itemBancoEstoque.UnidadeDeMedia,itemBancoEstoque.Local,itemBancoEstoque.Lote.ToShortDateString().Replace("/",""),itemBancoEstoque.CodDeBarra.ToString("D10") };
                                    rows.Add(row1);

                                    foreach (string[] item1 in rows)
                                    {
                                        dgvEstoque.Rows.Add(item1);
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

                                    FeitaABuscaEstoque = false;

                                    break;

                                }
                            }
                        }
                    }

                }//);
            }
        }

        #endregion




        #region Botão Buscar

        private void btnEstoqueCodBarra_Buscar_Click(object sender, EventArgs e)
        {
            int contmbox_EssaEtiquetaJaTeveSaldoFaturado = 1;
            int contmbox_EtiquejaFaturada = 1;


            dgvEstoque.Rows.Clear();

            if (txtEstoqueCodBarra.Text == "")
            {
                lblbarra.Text = "*";
                MessageBox.Show("Os campos com * são obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DadosGuardados.listaBancoEstoque.OrderBy(d => d.Lote);

                //DadosGuardados.listaBancoEstoque.ForEach(x =>
                foreach (BancoEstoque itemBancoEstoque in DadosGuardados.listaBancoEstoque)
                {
                    if (itemBancoEstoque.CodDeBarra.ToString("D10") == txtEstoqueCodBarra.Text)
                    {
                        //Etiqueta com o saldo total
                        if (itemBancoEstoque.TesteParaSaberSeFoiFaturadoZerandoSaldo == false && itemBancoEstoque.TesteParaSaberSeHouveMovimentaçãoDoSaldo == false)
                        {
                            txtEstoqueCodItem.Text = itemBancoEstoque.CodDoProduto.ToString();
                            txtEstoqueDescricao.Text = itemBancoEstoque.Descricao;
                            txtEstoqueCodItem.Text = itemBancoEstoque.CodDoProduto.ToString();
                            txtEstoqueLote.Text = itemBancoEstoque.Lote.ToShortDateString().Replace("/", "");
                            txtEstoqueQuantidade.Text = itemBancoEstoque.Quantidade.ToString();
                            txtEstoqueLocal.Text = itemBancoEstoque.Local;
                            lblbarra.Text = "";

                            FeitaABuscaEstoque = true;
                            break;
                        }
                        else
                        {

                            foreach (BancoSaidaNF itemBancoSaidaNF in DadosGuardados.listaBancoSaidaNF)
                            {
                                //Etiqueta com saldo totalmente consumido
                                if (itemBancoEstoque.TesteParaSaberSeFoiFaturadoZerandoSaldo == true && itemBancoEstoque.TesteParaSaberSeHouveMovimentaçãoDoSaldo == true && itemBancoSaidaNF.CodDoProduto == itemBancoEstoque.CodDoProduto && itemBancoEstoque.CodDeBarra == itemBancoSaidaNF.CodDeBarra)
                                {

                                    txtEstoqueCodItem.Text = itemBancoEstoque.CodDoProduto.ToString();
                                    txtEstoqueDescricao.Text = itemBancoEstoque.Descricao;
                                    txtEstoqueCodItem.Text = itemBancoEstoque.CodDoProduto.ToString();
                                    txtEstoqueLote.Text = itemBancoEstoque.Lote.ToShortDateString().Replace("/", "");
                                    txtEstoqueQuantidade.Text = itemBancoEstoque.Quantidade.ToString();
                                    txtEstoqueLocal.Text = itemBancoEstoque.Local;
                                    lblbarra.Text = "";

                                    //itemBancoEstoque.Local = txtEstoqueDestino.Text;

                                    dgvEstoque.ColumnCount = 8;

                                    var rows = new List<string[]>();
                                    string[] row1 = new string[] { itemBancoEstoque.NotaFiscal.ToString("D6"), itemBancoSaidaNF.NotaFiscalSaida.ToString("D6"),itemBancoEstoque.CodDoProduto.ToString(),
                                        itemBancoEstoque.Descricao, itemBancoSaidaNF.Quantidade.ToString(),itemBancoEstoque.UnidadeDeMedia,itemBancoSaidaNF.Local,itemBancoEstoque.Lote.ToShortDateString().Replace("/",""),itemBancoEstoque.CodDeBarra.ToString("D10") };
                                    rows.Add(row1);

                                    foreach (string[] item in rows)
                                    {
                                        dgvEstoque.Rows.Add(item);
                                    }
                                    lblbarra.Text = "";
                                    lblDestino.Text = "";

                                    FeitaABuscaEstoque = true;

                                    if (contmbox_EtiquejaFaturada == 1)
                                    {
                                        DialogResult OpcaoDoUsuario = new DialogResult();
                                        OpcaoDoUsuario = MessageBox.Show("Etiqueja já Faturada!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        if (OpcaoDoUsuario == DialogResult.OK)
                                        {
                                            txtEstoqueCodBarra.Text = "";
                                            txtEstoqueCodItem.Text = "";
                                            txtEstoqueDescricao.Text = "";
                                            txtEstoqueCodItem.Text = "";
                                            txtEstoqueLote.Text = "";
                                            txtEstoqueQuantidade.Text = "";
                                            txtEstoqueLocal.Text = "";
                                            lblbarra.Text = "";
                                            // break;
                                        }
                                        contmbox_EtiquejaFaturada++;
                                    }
                                }

                                //Etiqueta com saldo que já sofreu movimentação
                                else if (itemBancoEstoque.TesteParaSaberSeFoiFaturadoZerandoSaldo == false && itemBancoEstoque.TesteParaSaberSeHouveMovimentaçãoDoSaldo == true && itemBancoSaidaNF.CodDoProduto == itemBancoEstoque.CodDoProduto && itemBancoEstoque.CodDeBarra == itemBancoSaidaNF.CodDeBarra)
                                {
                                    txtEstoqueCodItem.Text = itemBancoEstoque.CodDoProduto.ToString();
                                    txtEstoqueDescricao.Text = itemBancoEstoque.Descricao;
                                    txtEstoqueCodItem.Text = itemBancoEstoque.CodDoProduto.ToString();
                                    txtEstoqueLote.Text = itemBancoEstoque.Lote.ToShortDateString().Replace("/", "");
                                    txtEstoqueQuantidade.Text = itemBancoEstoque.Quantidade.ToString();
                                    txtEstoqueLocal.Text = itemBancoEstoque.Local;
                                    lblbarra.Text = "";


                                    //itemBancoEstoque.Local = txtEstoqueDestino.Text;

                                    dgvEstoque.ColumnCount = 8;

                                    var rows = new List<string[]>();


                                    if (contmbox_EssaEtiquetaJaTeveSaldoFaturado == 1)
                                    {
                                        ///linha do banco de estoque
                                        string[] row1 = new string[] { itemBancoEstoque.NotaFiscal.ToString("D6"),"-------",itemBancoEstoque.CodDoProduto.ToString(),
                                        itemBancoEstoque.Descricao, itemBancoEstoque.Quantidade.ToString(),itemBancoEstoque.UnidadeDeMedia,itemBancoEstoque.Local,
                                        itemBancoEstoque.Lote.ToShortDateString().Replace("/",""),itemBancoEstoque.CodDeBarra.ToString("D10") };
                                        rows.Add(row1);
                                    }
                                    ///linha do bando de saida de NF
                                    string[] row2 = new string[] { itemBancoEstoque.NotaFiscal.ToString("D6"), itemBancoSaidaNF.NotaFiscalSaida.ToString("D6"),
                                        itemBancoEstoque.CodDoProduto.ToString(),itemBancoEstoque.Descricao, itemBancoSaidaNF.Quantidade.ToString(),
                                        itemBancoEstoque.UnidadeDeMedia,itemBancoSaidaNF.Local,itemBancoEstoque.Lote.ToShortDateString().Replace("/",""),
                                        itemBancoEstoque.CodDeBarra.ToString("D10") };
                                    rows.Add(row2);

                                    foreach (string[] item in rows)
                                    {
                                        dgvEstoque.Rows.Add(item);
                                    }
                                    lblbarra.Text = "";
                                    lblDestino.Text = "";

                                    FeitaABuscaEstoque = true;

                                    if (contmbox_EssaEtiquetaJaTeveSaldoFaturado == 1)
                                    {
                                        DialogResult OpcaoDoUsuario = new DialogResult();
                                        OpcaoDoUsuario = MessageBox.Show("Essa Etiqueta Já Teve Saldo Faturado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        if (OpcaoDoUsuario == DialogResult.OK)
                                        {
                                            txtEstoqueCodBarra.Text = "";
                                            txtEstoqueCodItem.Text = "";
                                            txtEstoqueDescricao.Text = "";
                                            txtEstoqueCodItem.Text = "";
                                            txtEstoqueLote.Text = "";
                                            txtEstoqueQuantidade.Text = "";
                                            txtEstoqueLocal.Text = "";
                                            lblbarra.Text = "";
                                            // break;
                                        }
                                        contmbox_EssaEtiquetaJaTeveSaldoFaturado++;
                                    }
                                }
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
