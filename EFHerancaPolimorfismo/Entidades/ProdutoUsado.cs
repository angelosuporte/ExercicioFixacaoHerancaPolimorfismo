using System;
using System.Globalization;

namespace EFHerancaPolimorfismo.Entidades
{
    class ProdutoUsado : Produto
    {
        public DateTime DataDeFabricacao { get; set; }

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataDeFabricação) : base (nome, preco)
        {
            DataDeFabricacao = dataDeFabricação;
        }

        public override string Etiqueta()
        {
            return Nome + "(usado) $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " (Data de fabricação: " + DataDeFabricacao.ToString("dd/MM/aaaa") + ")";
        }
    }
}
