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
    public partial class SaidaNF : Form
    {
        public SaidaNF()
        {
            InitializeComponent();
            DadosGuardados.PreencherBanco();
        }

        private void SaidaNF_Load(object sender, EventArgs e)
        {

        }


        #region Botão Buscar Por Codigo De Barra
        private void btnSaidaNF_BuscarCodItem_Click(object sender, EventArgs e)
        {

            if (txtSaidaNF_CodItem.Text == "" || txtSaidaNF_Quantidade.Text == "")
            {
                lblSaidaNF_CodItem.Text = "*";
                lblSaidaNF_Quantidade.Text = "*";
                MessageBox.Show("Os Campos Com * São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (var itemBancoEstoque in DadosGuardados.listaBancoEstoque)
                {
                    //DadosGuardados.listaBancoEstoque.ForEach(x =>
                    //{
                    if (itemBancoEstoque.CodDoProduto.ToString() == txtSaidaNF_CodItem.Text && Convert.ToDouble(txtSaidaNF_Quantidade.Text) <= itemBancoEstoque.Quantidade)
                    {
                        txtSaidaNF_Descricao.Text = itemBancoEstoque.Descricao;
                        txtSaidaNF_Valor.Text = ("R$ " + Convert.ToString((itemBancoEstoque.Valor * Convert.ToDouble(txtSaidaNF_Quantidade.Text) / itemBancoEstoque.Quantidade).ToString("N2")));
                        txtSaidaNF_Obs.Text = itemBancoEstoque.Observacao;

                        lblSaidaNF_NFSaida.Text = "";
                        lblSaidaNF_CodItem.Text = "";
                        lblSaidaNF_Quantidade.Text = "";
                    }
                    else if (Convert.ToDouble(txtSaidaNF_Quantidade.Text) > itemBancoEstoque.Quantidade && itemBancoEstoque.Quantidade != 0)
                    {
                        MessageBox.Show($"Saldo Insuficiente!\nSaldo Restante {itemBancoEstoque.Quantidade} {itemBancoEstoque.UnidadeDeMedia}.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                }
                // });
            }
        }
        #endregion



        #region Botão Adicionar


        private void btnSaidaNF_Adicionar_Click(object sender, EventArgs e)
        {
            int contmbox_ItemNaoestaDisponivel = 1;

            if (txtSaidaNF_CodItem.Text == "" || txtSaidaNF_Quantidade.Text == "")
            {
                lblSaidaNF_CodItem.Text = "*";
                lblSaidaNF_Quantidade.Text = "*";
                MessageBox.Show("Os Campos Com * São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DadosGuardados.listaBancoEstoque.OrderBy(d => d.Lote);

                foreach (var itemBancoEstoque in DadosGuardados.listaBancoEstoque)
                {

                    //DadosGuardados.listaBancoEstoque.ForEach(x =>
                    //{

                    if (itemBancoEstoque.CodDoProduto.ToString() == txtSaidaNF_CodItem.Text && txtSaidaNF_Descricao.Text != "" && itemBancoEstoque.Local == "PRODUÇÃO" && itemBancoEstoque.Quantidade != 0)
                    {
                        if (DadosGuardados.contParaGerarNotaFiscalDeSaida == 1)
                        {
                            txtSaidaNF_SaidaNF.Text = Convert.ToString(DadosGuardados.NotaFiscalSaida);

                            DadosGuardados.contParaGerarNotaFiscalDeSaida++;
                        }
                        if (txtSaidaNF_SaidaNF.Text != "")
                        {
                            itemBancoEstoque.Quantidade = itemBancoEstoque.Quantidade - Convert.ToDouble(txtSaidaNF_Quantidade.Text);

                            DadosGuardados.listaBancoSaidaNF.Add(new BancoSaidaNF(Convert.ToInt32(txtSaidaNF_SaidaNF.Text), itemBancoEstoque.CodDoProduto, itemBancoEstoque.Descricao, Convert.ToDouble(txtSaidaNF_Quantidade.Text),
                           itemBancoEstoque.UnidadeDeMedia, txtSaidaNF_Obs.Text, itemBancoEstoque.Valor, DateTime.Today, "FATURADO", itemBancoEstoque.CodDeBarra, itemBancoEstoque.Lote, false));

                            dgvSaidaNF.Rows.Clear();
                            foreach (var itemBancoSaidaNF in DadosGuardados.listaBancoSaidaNF)
                            {
                                if (txtSaidaNF_SaidaNF.Text == itemBancoSaidaNF.NotaFiscalSaida.ToString())
                                {
                                    dgvSaidaNF.ColumnCount = 8;

                                    var rows = new List<string[]>();
                                    string[] row1 = new string[] { itemBancoSaidaNF.NotaFiscalSaida.ToString("D6"), itemBancoSaidaNF.CodDoProduto.ToString(),
                                    itemBancoSaidaNF.Descricao, itemBancoSaidaNF.Quantidade.ToString (),itemBancoSaidaNF.UnidadeDeMedia,itemBancoSaidaNF.Observacao,("R$ "+itemBancoSaidaNF.Valor.ToString("N2")),itemBancoSaidaNF.Emissao.ToShortDateString() };
                                    rows.Add(row1);

                                    foreach (string[] item in rows)
                                    {
                                        dgvSaidaNF.Rows.Add(item);
                                    }

                                    lblSaidaNF_CodItem.Text = "";
                                    lblSaidaNF_Quantidade.Text = "";

                                    itemBancoEstoque.TesteParaVerificarSeFoiSalvaNotaFiscalSaida = true;

                                    txtSaidaNF_CodItem.Text = "";
                                    txtSaidaNF_Descricao.Text = "";
                                    txtSaidaNF_Quantidade.Text = "";
                                    txtSaidaNF_Valor.Text = "";
                                    txtSaidaNF_Obs.Text = "";

                                    itemBancoEstoque.TesteParaSaberSeHouveMovimentaçãoDoSaldo = true;

                                    if (itemBancoEstoque.Local == "PRODUÇÃO" && itemBancoEstoque.Quantidade == 0)
                                    {
                                        itemBancoEstoque.TesteParaSaberSeFoiFaturadoZerandoSaldo = true;
                                        itemBancoEstoque.Local = "FATURADO";
                                    }
                                }
                                DadosGuardados.PassouTela = true;
                            }
                            break;
                        }
                    }
                    else if (itemBancoEstoque.Local != "PRODUÇÃO" && itemBancoEstoque.Quantidade > 0 && itemBancoEstoque.CodDoProduto.ToString() == txtSaidaNF_CodItem.Text)
                    {
                        if (contmbox_ItemNaoestaDisponivel == 1)
                        {
                            MessageBox.Show("Item Não esta Disponivel Em Produção!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            contmbox_ItemNaoestaDisponivel++;
                        }
                    }
                    else if (itemBancoEstoque.Local == "PRODUÇÃO" && itemBancoEstoque.Quantidade == 0)
                    {
                        itemBancoEstoque.TesteParaSaberSeFoiFaturadoZerandoSaldo = true;
                        itemBancoEstoque.Local = "FATURADO";
                    }
                    //});
                }
            }
        }


        #endregion



        #region Botão Confirmar


        private void btnSaidaNF_Confirmar_Click(object sender, EventArgs e)
        {
            if (txtSaidaNF_SaidaNF.Text != "")
            {
                MessageBox.Show("NF Confirmada com Sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvSaidaNF.Rows.Clear();
            DadosGuardados.contParaGerarNotaFiscalDeSaida = 1;
            txtSaidaNF_SaidaNF.Text = "";
            DadosGuardados.NotaFiscalSaida++;
            DadosGuardados.PassouTela = false;
        }


        #endregion



        #region Botão Cancelar


        private void btnSaidaNF_Cancelar_Click(object sender, EventArgs e)
        {
            int contmbox_NFRemovidaComSucesso = 1;

            foreach (var itemBancoEstoque in DadosGuardados.listaBancoEstoque)
            {
                if (itemBancoEstoque.TesteParaVerificarSeFoiSalvaNotaFiscalSaida == true)
                {
                    foreach (var itemBancoSaidaNF in DadosGuardados.listaBancoSaidaNF)
                    {
                        if (itemBancoSaidaNF.NotaFiscalSaida.ToString() == txtSaidaNF_SaidaNF.Text && itemBancoSaidaNF.TesteParaSaberSeFoiCanceladaSaidaNF == false)
                        {
                            itemBancoSaidaNF.TesteParaSaberSeFoiCanceladaSaidaNF = true;

                            itemBancoEstoque.Quantidade = itemBancoEstoque.Quantidade + itemBancoSaidaNF.Quantidade;

                            DadosGuardados.listaBancoSaidaNF.Remove(itemBancoSaidaNF);

                            itemBancoEstoque.Local = "PRODUÇÃO";
                            itemBancoEstoque.TesteParaSaberSeFoiFaturadoZerandoSaldo = false;
                            contmbox_NFRemovidaComSucesso++;

                            if (contmbox_NFRemovidaComSucesso == 2)
                            {
                                txtSaidaNF_CodItem.Text = "";
                                txtSaidaNF_Descricao.Text = "";
                                txtSaidaNF_Quantidade.Text = "";
                                txtSaidaNF_Valor.Text = "";
                                txtSaidaNF_Obs.Text = "";

                                DadosGuardados.contParaGerarNotaFiscalDeSaida = 1;
                                DadosGuardados.NotaFiscalSaida++;
                                DadosGuardados.PassouTela = false;

                                dgvSaidaNF.Rows.Clear();
                                MessageBox.Show("NF Removida Com Sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        break;
                    }
                }
            }
        }


        #endregion



        #region Botão Buscar Por NF


        private void btnSaidaNF_BuscarNFSaida_Click(object sender, EventArgs e)
        {
            dgvSaidaNF.Rows.Clear();
            if (txtSaidaNF_SaidaNF.Text == "")
            {
                lblSaidaNF_NFSaida.Text = "*";
                MessageBox.Show("Os Campos Com * São Obrigatorios!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DadosGuardados.listaBancoSaidaNF.ForEach(x =>
                {

                    if (x.NotaFiscalSaida.ToString() == txtSaidaNF_SaidaNF.Text)
                    {
                        txtSaidaNF_CodItem.Text = "";
                        txtSaidaNF_Descricao.Text = "";
                        txtSaidaNF_Quantidade.Text = "";
                        txtSaidaNF_Valor.Text = "";
                        txtSaidaNF_Obs.Text = "";

                        dgvSaidaNF.ColumnCount = 8;


                        var rows = new List<string[]>();
                        string[] row1 = new string[] { x.NotaFiscalSaida.ToString("D6"), x.CodDoProduto.ToString(),
                        x.Descricao, x.Quantidade.ToString (),x.UnidadeDeMedia,x.Local,x.Lote.ToShortDateString().Replace("/",""),x.CodDeBarra.ToString("D10") };
                        rows.Add(row1);

                        foreach (string[] item in rows)
                        {
                            dgvSaidaNF.Rows.Add(item);
                        }
                        lblSaidaNF_NFSaida.Text = "";
                        lblSaidaNF_CodItem.Text = "";
                        lblSaidaNF_Quantidade.Text = "";
                    }
                });
            }
        }


        #endregion



        #region TextBox


        private void txtSaidaNF_Quantidade1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtSaida_CodItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtBuscarCodItem_NF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion


    }
}
