using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Estoque
{
    internal class BancoEstoque
    {
        public int NotaFiscal;
        public string Descricao;
        public string Fornecedor;
        public string UnidadeDeMedia;
        public double Quantidade;
        public string Observacao;
        public double Valor;
        public DateTime Emissao;
        public DateTime Lancamento;
        public int CodDoProduto;
        public string Local;
        public int CodDeBarra;
        public DateTime Lote;
        public bool TesteParaVerificarSeFoiSalvaNotaFiscalSaida;
        public bool TesteParaSaberSeFoiFaturadoZerandoSaldo;
        public bool TesteParaSaberSeHouveMovimentaçãoDoSaldo;


        public BancoEstoque(int _notaFiscal, string _descricao, string _fornecedor, string _unidadeDeMedia,
            double _quantidade, string _observacao, double _valor, DateTime _emissao, DateTime _lancamento,
            int _codDoProduto, string _local, int _codDeBarras, DateTime _lote, bool _testeParaSeFoiFeitaMovimentaçãoNaQuant,
            bool _testeParaSaberSeFoiFaturado, bool _testeParaSaberSeHouveMovimentaçãoDoSaldo)
        {
            NotaFiscal = _notaFiscal;
            Descricao = _descricao;
            Fornecedor = _fornecedor;
            UnidadeDeMedia = _unidadeDeMedia;
            Quantidade = _quantidade;
            Observacao = _observacao;
            Valor = _valor;
            Emissao = _emissao;
            Lancamento = _lancamento;
            CodDoProduto = _codDoProduto;
            Local = _local;
            CodDeBarra = _codDeBarras;
            Lote = _lote;
            TesteParaVerificarSeFoiSalvaNotaFiscalSaida = _testeParaSeFoiFeitaMovimentaçãoNaQuant;
            TesteParaSaberSeFoiFaturadoZerandoSaldo = _testeParaSaberSeFoiFaturado;
            TesteParaSaberSeHouveMovimentaçãoDoSaldo = _testeParaSaberSeHouveMovimentaçãoDoSaldo;


        }
    }
}
