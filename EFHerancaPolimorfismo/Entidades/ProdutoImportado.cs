using System;
using System.Globalization;

namespace EFHerancaPolimorfismo.Entidades
{
    class ProdutoImportado : Produto
    {
        public double Alfandega { get; set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string nome, double preco, double alfandega) : base(nome, preco)
        {
            Alfandega = alfandega;
        }
        public double PrecoTotal()
        {
            return Preco + Alfandega;
        }

        public override string Etiqueta()
        {
            return Nome + "$ " + PrecoTotal().ToString("F2", CultureInfo.InvariantCulture) +
                "( Tarifa alfandegaria: $" + Alfandega.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
