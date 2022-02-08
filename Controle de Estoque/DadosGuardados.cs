using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Estoque
{
    internal static class DadosGuardados
    {
        public static int CodigoDeBarra = 0000000001;

        public static int NotaFiscalSaida = 0000000001;

        //Contador para dar entrada apenas uma vez a cada NF gerada, garantindo que seja adicionado mais de um item na mesma NF de Saida
        public static int contParaGerarNotaFiscalDeSaida = 1;

        public static List<BancoEntradaNF> listaNF = new List<BancoEntradaNF>();

        //Teste para preencher a listaNF do BancoEntradaNF apenas uma vez
        public static bool FoiInicializada = false;

        public static List<BancoSaidaNF> listaBancoSaidaNF = new List<BancoSaidaNF>();

        //Teste para Saber se o Usuario mudou de tela sem confirmar a NF de Saida
        public static bool PassouTela = false;


        #region Banco Entrada NF
        public static void PreencherBanco()
        {
            if (FoiInicializada == false)
            {
                listaNF = new List<BancoEntradaNF>()
              {
                 new BancoEntradaNF(000001,"TELHA ONDULADA FIBROCIMENTO 224 X 110 5MM","IMBRALIT","UN",100,"--",3990.90,new DateTime(2015,01,12),false,10,false,"TRÂNSITO"),
                new BancoEntradaNF(000001,"CUMEEIRA NORMAL FIBROCIMENTO 15G 110 X 5MM","IMBRALIT","UN",100,"--",2990.90,new DateTime(2015,01,12),false,11,false,"TRÂNSITO"),
                new BancoEntradaNF(000001,"ARAME GALVANIZADO BWG 14 2 11MM","GERDAU","KG",100,"--",1490.90,new DateTime(2015,01,12),false,12,false,"TRÂNSITO"),
                new BancoEntradaNF(000001,"PARAFUSO TELHEIRO COMPLETO","GERDAU","UN",100,"--",90.00,new DateTime(2015,01,12), false,13,false,"TRÂNSITO"),
                new BancoEntradaNF(000001,"PREGO C/CABEÇA 19 X 39","GERDAU","KG",100,"--",1190.90,new DateTime(2015,01,12),false,14,false,"TRÂNSITO"),
                new BancoEntradaNF(000001,"PREGO S/CABEÇA 19 X 39","GERDAU","KG",100,"--",1190.90,new DateTime(2015,01,12),false,15,false,"TRÂNSITO"),
                new BancoEntradaNF(000002,"GUIA EUCALIPTO 2.5 X 10 X 5","PINHO","UN",100,"--",1965.90,new DateTime(2015,01,12),false,16,false,"TRÂNSITO"),
                new BancoEntradaNF(000002,"TRELICA ESPACADOR BELGO BE 8CM ","BELGO","UN",100,"--",2990.90,new DateTime(2015,01,12),false,17,false,"TRÂNSITO"),
                new BancoEntradaNF(000002,"CIMENTO TODAS AS OBRAS 50KG","VOTORAN","UN",100,"--",2990.90,new DateTime(2015,01,12),false,18,false,"TRÂNSITO"),
                new BancoEntradaNF(000002,"AREIA GROSSA REGULAR ","MOLOSSI","M3",100,"--",7000.90,new DateTime(2015,01,12),false,19,false,"TRÂNSITO"),
                new BancoEntradaNF(000002,"BRITA","MOLOSSI","M3",100,"--",9000.90,new DateTime(2015,01,12),false,20,false,"TRÂNSITO"),
                new BancoEntradaNF(000003,"TELHA ONDULADA FIBROCIMENTO 224 X 110 5MM","IMBRALIT","UN",100,"--",3990.90,new DateTime(2015,01,12),false,10,false,"TRÂNSITO"),
                new BancoEntradaNF(000003,"CUMEEIRA NORMAL FIBROCIMENTO 15G 110 X 5MM","IMBRALIT","UN",100,"--",2990.90,new DateTime(2015,01,12),false,11,false,"TRÂNSITO"),
                new BancoEntradaNF(000003,"ARAME GALVANIZADO BWG 14 2 11MM","GERDAU","KG",100,"--",1490.90,new DateTime(2015,01,12),false,12,false,"TRÂNSITO"),
                new BancoEntradaNF(000003,"PARAFUSO TELHEIRO COMPLETO","GERDAU","UN",100,"--",90.00,new DateTime(2015,01,12), false,13,false,"TRÂNSITO"),
                new BancoEntradaNF(000003,"PREGO C/CABEÇA 19 X 39","GERDAU","KG",100,"--",1190.90,new DateTime(2015,01,12),false,14,false,"TRÂNSITO"),
                new BancoEntradaNF(000003,"PREGO S/CABEÇA 19 X 39","GERDAU","KG",100,"--",1190.90,new DateTime(2015,01,12),false,15,false,"TRÂNSITO"),
                new BancoEntradaNF(000004,"GUIA EUCALIPTO 2.5 X 10 X 5","PINHO","UN",100,"--",1965.65,new DateTime(2015,01,12),false,16,false,"TRÂNSITO"),
                new BancoEntradaNF(000004,"TRELICA ESPACADOR BELGO BE 8CM ","BELGO","UN",100,"--",2990.90,new DateTime(2015,01,12),false,17,false,"TRÂNSITO"),
                new BancoEntradaNF(000004,"CIMENTO TODAS AS OBRAS 50KG","VOTORAN","KG",100,"--",2990.90,new DateTime(2015,01,12),false,18,false,"TRÂNSITO"),
                new BancoEntradaNF(000004,"AREIA GROSSA REGULAR ","MOLOSSI","M3",100,"--",7000.00,new DateTime(2015,01,12),false,19,false,"TRÂNSITO"),
                new BancoEntradaNF(000004,"BRITA","MOLOSSI","M3",100,"--",9000.00,new DateTime(2015,01,12),false,20,false,"TRÂNSITO"),
                new BancoEntradaNF(000005,"TELHA ONDULADA FIBROCIMENTO 224 X 110 5MM","IMBRALIT","UN",100,"--",3990.90,new DateTime(2015,01,12),false,10,false,"TRÂNSITO"),
                new BancoEntradaNF(000005,"CUMEEIRA NORMAL FIBROCIMENTO 15G 110 X 5MM","IMBRALIT","UN",100,"--",2990.90,new DateTime(2015,01,12),false,11,false,"TRÂNSITO"),
                new BancoEntradaNF(000005,"ARAME GALVANIZADO BWG 14 2 11MM","GERDAU","KG",100,"--",1490.90,new DateTime(2015,01,12),false,12,false,"TRÂNSITO"),
                new BancoEntradaNF(000005,"PARAFUSO TELHEIRO COMPLETO","GERDAU","UN",100,"--",90.00,new DateTime(2015,01,12), false,13,false,"TRÂNSITO"),
                new BancoEntradaNF(000005,"PREGO C/CABEÇA 19 X 39","GERDAU","KG",100,"--",1190.90,new DateTime(2015,01,12),false,14,false,"TRÂNSITO"),
                new BancoEntradaNF(000005,"PREGO S/CABEÇA 19 X 39","GERDAU","KG",100,"--",1190.90,new DateTime(2015,01,12),false,15,false,"TRÂNSITO"),

                };
                FoiInicializada = true;
            }
        }
        #endregion



        #region Banco Estoque


        public static List<BancoEstoque> listaBancoEstoque = new List<BancoEstoque>();

        public static List<BancoEstoque> getListaBancoEstoque()
        {
            return listaBancoEstoque;
        }
        public static void setListaBancoEstoque(List<BancoEstoque> _listaBancoEstoque)
        {
            listaBancoEstoque = _listaBancoEstoque;
        }


        #endregion



    }
}

