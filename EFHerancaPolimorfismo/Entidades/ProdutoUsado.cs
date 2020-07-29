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

        public ProdutoUsado(string nome, double preco, DateTime dataDeFabricacao) : base (nome, preco)
        {
            DataDeFabricacao = dataDeFabricacao;
        }

        public override string Etiqueta()
        {
            return Nome + "(usado) $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " (Data de fabricação: " + DataDeFabricacao.ToString("dd/MM/aaaa") + ")";
        }
    }
}
