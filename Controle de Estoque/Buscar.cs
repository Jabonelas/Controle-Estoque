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
    public partial class Buscar : Form
    {


        public Buscar()
        {
            InitializeComponent();
            DadosGuardados.listaBancoEstoque = DadosGuardados.getListaBancoEstoque();
        }


        #region Estoque Load


        private void Estoque_Load(object sender, EventArgs e)
        {
            if (DadosGuardados.PassouTela == true)
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("A NF Não Foi Confirmada, Deseja Salva-la?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.No)
                {
                    int contmbox_NFRemovidaComSucesso = 1;

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



        #region Botão Buscar


        private void btnBuscarCodItem_Buscar_Click(object sender, EventArgs e)
        {
            dgvBuscar.Rows.Clear();
            if (txtBuscarCodItem_NF.Text == "")
            {
                lblErroBuscar.Text = "*";
                MessageBox.Show("Os Campos Com * São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DadosGuardados.listaBancoEstoque.ForEach(itemBancoEstoque =>
                {
                    if (itemBancoEstoque.TesteParaSaberSeFoiFaturadoZerandoSaldo == false)
                    {

                        if (itemBancoEstoque.CodDoProduto.ToString() == txtBuscarCodItem_NF.Text)
                        {

                            dgvBuscar.ColumnCount = 8;

                            var rows = new List<string[]>();
                            string[] row1 = new string[] { itemBancoEstoque.NotaFiscal.ToString("D6"), itemBancoEstoque.CodDoProduto.ToString(),
                            itemBancoEstoque.Descricao, itemBancoEstoque.Quantidade.ToString (),itemBancoEstoque.UnidadeDeMedia,itemBancoEstoque.Local,itemBancoEstoque.Lote.ToShortDateString().Replace("/",""),itemBancoEstoque.CodDeBarra.ToString("D10") };
                            rows.Add(row1);

                            foreach (string[] item in rows)
                            {
                                dgvBuscar.Rows.Add(item);
                            }
                            lblErroBuscar.Text = "";
                        }
                    }
                });
            }
        }


        #endregion



        #region TextBox


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


