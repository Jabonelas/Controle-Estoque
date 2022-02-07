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
            DadosGuardados.PreencherBanco1();
        }



        private void Estoque_Load(object sender, EventArgs e)
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

        private void btnBuscarCodItem_Buscar_Click(object sender, EventArgs e)
        {
                    dgvBuscar.Rows.Clear();
            if (txtBuscarCodItem_NF.Text == "")
            {
                lblErroBuscar.Text = "*";
                MessageBox.Show("Os Campos Com * São Obrigatorios!");
            }
            else
            {
                DadosGuardados.listaBancoEstoque.ForEach(x =>
                {

                    if (x.CodDoProduto.ToString() == txtBuscarCodItem_NF.Text)
                    {

                        dgvBuscar.ColumnCount = 8;
                        //dgvEstoque.Columns[0].Name = "Nota Fiscal";
                        //dgvEstoque.Columns[0].Width = 120;
                        //dgvEstoque.Columns[1].Name = "Codigo do item";
                        //dgvEstoque.Columns[1].Width = 180;
                        //dgvEstoque.Columns[2].Name = "Descricção do item";
                        //dgvEstoque.Columns[2].Width = 380;
                        //dgvEstoque.Columns[3].Name = "Quantidade";
                        //dgvEstoque.Columns[3].Width = 110;
                        //dgvEstoque.Columns[4].Name = "Unidade";
                        //dgvEstoque.Columns[4].Width = 80;
                        //dgvEstoque.Columns[4].Name = "Local";
                        //dgvEstoque.Columns[5].Width = 80;
                        //dgvEstoque.Columns[5].Name = "Codigo de Barras";
                        //dgvEstoque.Columns[6].Width = 180;

                        var rows = new List<string[]>();
                        string[] row1 = new string[] { x.NotaFiscal.ToString("D6"), x.CodDoProduto.ToString(),
                        x.Descricao, x.Quantidade.ToString (),x.UnidadeDeMedia,x.Local,x.Lote.ToShortDateString().Replace("/",""),x.CodDeBarra.ToString("D10") };
                        rows.Add(row1);

                        foreach (string[] item in rows)
                        {
                            dgvBuscar.Rows.Add(item);
                        }
                        lblErroBuscar.Text = "";
                    }
                });
            }
        }

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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


