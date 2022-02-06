using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Estoque
{
    internal class BancoSaidaNF
    {
        public int NotaFiscalSaida; 
        public int CodDoProduto;
        public string Descricao;
        public double Quantidade;
        public string UnidadeDeMedia;
        public string Observacao;
        public double Valor;
        public DateTime Emissao;
        public string Local;
        public int CodDeBarra;
        public DateTime Lote;
        public bool TesteParaEntrada5;

        public BancoSaidaNF(int _notaFiscalSaida, int _codDoProduto, string _descricao, double _quantidade, string _unidadeDeMedia, string _observacao, double _valor, DateTime _emissao, string _local, int _codDeBarra, DateTime _lote, bool _testeParaEntrada5)
        {
            NotaFiscalSaida = _notaFiscalSaida;
            CodDoProduto = _codDoProduto;
            Descricao = _descricao;
            Quantidade = _quantidade;
            UnidadeDeMedia = _unidadeDeMedia;
            Observacao = _observacao;
            Valor = _valor;
            Emissao = _emissao;
            Local = _local;
            CodDeBarra = _codDeBarra;
            Lote = _lote;
            TesteParaEntrada5 = _testeParaEntrada5;
        }
    }
}
