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
        private void btnSaidaNF_BuscarCodItem_Click(object sender, EventArgs e)
        {

            if (txtSaidaNF_CodItem.Text == "" || txtSaidaNF_Quantidade.Text == "")
            {
                lblSaidaNF_CodItem.Text = "*";
                lblSaidaNF_Quantidade.Text = "*";
                MessageBox.Show("Os Campos Com * São Obrigatorios!");
            }
            else
            {
                foreach (var x in DadosGuardados.listaBancoEstoque)
                {
                    //DadosGuardados.listaBancoEstoque.ForEach(x =>
                    //{
                    if (x.CodDoProduto.ToString() == txtSaidaNF_CodItem.Text && Convert.ToDouble(txtSaidaNF_Quantidade.Text) <= x.Quantidade)
                    {
                        txtSaidaNF_Descricao.Text = x.Descricao;
                        txtSaidaNF_Valor.Text = ("R$ " + Convert.ToString((x.Valor * Convert.ToDouble(txtSaidaNF_Quantidade.Text) / x.Quantidade).ToString("N2")));
                        txtSaidaNF_Obs.Text = x.Observacao;

                        lblSaidaNF_NFSaida.Text = "";
                        lblSaidaNF_CodItem.Text = "";
                        lblSaidaNF_Quantidade.Text = "";
                    }
                    else if (Convert.ToDouble(txtSaidaNF_Quantidade.Text) > x.Quantidade && x.Quantidade != 0)
                    {
                        MessageBox.Show($"Saldo Insuficiente!\nSaldo Restante {x.Quantidade} {x.UnidadeDeMedia}.");
                        break;
                    }
                }
                // });
            }
        }
        private void btnSaidaNF_Adicionar_Click(object sender, EventArgs e)
        {
            int cont2 = 1;
            //int cont3 = 1;


            if (txtSaidaNF_CodItem.Text == "" || txtSaidaNF_Quantidade.Text == "")
            {
                lblSaidaNF_CodItem.Text = "*";
                lblSaidaNF_Quantidade.Text = "*";
                MessageBox.Show("Os Campos Com * São Obrigatorios!");
            }
            else
            {
                DadosGuardados.listaBancoEstoque.OrderBy(d => d.Lote);

                foreach (var x in DadosGuardados.listaBancoEstoque)
                {

                    //DadosGuardados.listaBancoEstoque.ForEach(x =>
                    //{

                    if (x.CodDoProduto.ToString() == txtSaidaNF_CodItem.Text && txtSaidaNF_Descricao.Text != "" && x.Local == "PRODUÇÃO" && x.Quantidade != 0)
                    {
                        if (DadosGuardados.contParaGerarNotaFiscalDeSaida == 1)
                        {
                            txtSaidaNF_SaidaNF.Text = Convert.ToString(DadosGuardados.NotaFiscalSaida);

                            DadosGuardados.contParaGerarNotaFiscalDeSaida++;
                        }

                        if (txtSaidaNF_SaidaNF.Text != "")
                        {
                            x.Quantidade = x.Quantidade - Convert.ToDouble(txtSaidaNF_Quantidade.Text);

                            DadosGuardados.listaBancoSaidaNF.Add(new BancoSaidaNF(Convert.ToInt32(txtSaidaNF_SaidaNF.Text), x.CodDoProduto, x.Descricao, Convert.ToDouble(txtSaidaNF_Quantidade.Text),
                           x.UnidadeDeMedia, txtSaidaNF_Obs.Text, x.Valor, DateTime.Today, "FATURADO", x.CodDeBarra, x.Lote, false));

                            dgvSaidaNF.Rows.Clear();
                            foreach (var c in DadosGuardados.listaBancoSaidaNF)
                            {
                                if (txtSaidaNF_SaidaNF.Text == c.NotaFiscalSaida.ToString())
                                {

                                    dgvSaidaNF.ColumnCount = 8;

                                    var rows = new List<string[]>();
                                    string[] row1 = new string[] { c.NotaFiscalSaida.ToString("D6"), c.CodDoProduto.ToString(),
                                    c.Descricao, c.Quantidade.ToString (),c.UnidadeDeMedia,c.Observacao,("R$ "+c.Valor.ToString("N2")),c.Emissao.ToShortDateString() };
                                    rows.Add(row1);

                                    foreach (string[] item in rows)
                                    {
                                        dgvSaidaNF.Rows.Add(item);
                                    }

                                    lblSaidaNF_CodItem.Text = "";
                                    lblSaidaNF_Quantidade.Text = "";

                                    x.TesteParaSeFoiFeitaMovimentaçãoNaQuant = true;


                                    txtSaidaNF_CodItem.Text = "";
                                    txtSaidaNF_Descricao.Text = "";
                                    txtSaidaNF_Quantidade.Text = "";
                                    txtSaidaNF_Valor.Text = "";
                                    txtSaidaNF_Obs.Text = "";

                                    if (x.Local == "PRODUÇÃO" && x.Quantidade == 0)
                                    {
                                        //if (cont3 == 1)
                                        // {
                                        x.TesteParaSaberSeFoiFaturadoZerandoAQuant = true;
                                        x.Local = "FATURADO";
                                        //   cont3++;
                                        // }
                                    }
                                }
                                DadosGuardados.PassarTela = false;
                            }
                            break;
                        }
                    }
                    //&& x.Quantidade != 0
                    else if (x.Local != "PRODUÇÃO" && x.Quantidade > 0 && x.CodDoProduto.ToString() == txtSaidaNF_CodItem.Text)
                    {
                        if (cont2 == 1)
                        {
                            MessageBox.Show("Item Não esta Disponivel Em Produção!");
                            cont2++;
                        }
                    }
                    else if (x.Local == "PRODUÇÃO" && x.Quantidade == 0)
                    {
                        //if (cont3 == 1)
                        // {
                        x.TesteParaSaberSeFoiFaturadoZerandoAQuant = true;
                        x.Local = "FATURADO";
                        //   cont3++;
                        // }
                    }



                    //});
                }
            }
        }

        private void btnSaidaNF_Confirmar_Click(object sender, EventArgs e)
        {
            dgvSaidaNF.Rows.Clear();
            DadosGuardados.contParaGerarNotaFiscalDeSaida = 1;
            txtSaidaNF_SaidaNF.Text = "";
            DadosGuardados.NotaFiscalSaida++;

            DadosGuardados.PassarTela = true;

         
        }
        private void btnSaidaNF_Cancelar_Click(object sender, EventArgs e)
        {
            int contMessageBox_NFRemovidaComSucesso = 1;

            foreach (var itemBancoEstoque in DadosGuardados.listaBancoEstoque)
            {
                if (itemBancoEstoque.TesteParaSeFoiFeitaMovimentaçãoNaQuant == true )
                {
                    foreach (var itemBancoSaidaNF in DadosGuardados.listaBancoSaidaNF)
                    {
                        if (itemBancoSaidaNF.NotaFiscalSaida.ToString() == txtSaidaNF_SaidaNF.Text && itemBancoSaidaNF.TesteParaSaberSeFoiCanceladaSaidaNF == false)
                        {
                            itemBancoSaidaNF.TesteParaSaberSeFoiCanceladaSaidaNF = true;

                            itemBancoEstoque.Quantidade = itemBancoEstoque.Quantidade + itemBancoSaidaNF.Quantidade;

                            DadosGuardados.listaBancoSaidaNF.Remove(itemBancoSaidaNF);

                            itemBancoEstoque.Local = "PRODUÇÃO";
                            itemBancoEstoque.TesteParaSaberSeFoiFaturadoZerandoAQuant = false;
                            contMessageBox_NFRemovidaComSucesso++;

                            if (contMessageBox_NFRemovidaComSucesso == 2)
                            {
                                txtSaidaNF_CodItem.Text = "";
                                txtSaidaNF_Descricao.Text = "";
                                txtSaidaNF_Quantidade.Text = "";
                                txtSaidaNF_Valor.Text = "";
                                txtSaidaNF_Obs.Text = "";

                               // DadosGuardados.contParaGerarNotaFiscalDeSaida = 1;
                                DadosGuardados.NotaFiscalSaida++;
                                DadosGuardados.PassarTela = true;

                                dgvSaidaNF.Rows.Clear();
                                MessageBox.Show("NF Removida Com Sucesso!");
                            }
                        }
                        break;
                    }
                }
            }
        }

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

        private void btnSaidaNF_BuscarNFSaida_Click(object sender, EventArgs e)
        {
            dgvSaidaNF.Rows.Clear();
            if (txtSaidaNF_SaidaNF.Text == "")
            {
                lblSaidaNF_NFSaida.Text = "*";
                MessageBox.Show("Os Campos Com * São Obrigatorios!");
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

        private void txtBuscarCodItem_NF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
