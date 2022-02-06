using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Estoque
{
    internal class BancoEntradaNF
    {
        public int NotaFiscalEntrada;
        public string Descricao;
        public string Fornecedor;
        public string UnidadeDeMedia;
        public double Quantidade;
        public string Observavao;
        public double Valor;
        public DateTime Emissao;
        public bool TesteParaEntrada1;
        public int CodDoProduto;
        public bool TesteParaEntrada2;
        public string Local;


        public BancoEntradaNF(int _notaFiscal, string _descricao, string _fornecedor, string _unidadeDeMedia,
            double _quantidade, string _observavao, double _valor, DateTime _emissao, bool _testeParaEntrada1, 
            int _codDoProduto, bool _testeParaEntrada2, string _local)
        {
            NotaFiscalEntrada = _notaFiscal;
            Descricao = _descricao;
            Fornecedor = _fornecedor;
            UnidadeDeMedia = _unidadeDeMedia;
            Quantidade = _quantidade;
            Observavao = _observavao;
            Valor = _valor;
            Emissao = _emissao;
            TesteParaEntrada1 = _testeParaEntrada1;
            CodDoProduto = _codDoProduto;
            TesteParaEntrada2 = _testeParaEntrada2;
            Local = _local;
        }

    }
}
