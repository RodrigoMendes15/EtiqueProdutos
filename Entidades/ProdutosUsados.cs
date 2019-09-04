using System;
using System.Globalization;

namespace ListaProdutos.Entidades
{
    class ProdutosUsados : Produtos
    {
        public DateTime Fabricacao { get; set; }

        public ProdutosUsados()
        {
        }

        public ProdutosUsados(string nome, double preco, DateTime fabricacao) : base(nome, preco)
        {
            Fabricacao = fabricacao;
        }

        public override string Etiqueta()
        {
            return Nome + " (Usado)" + " R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + " (Fabricado em: " + Fabricacao + ")";
        }
    }
}
