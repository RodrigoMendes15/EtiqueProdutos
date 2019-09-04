using System.Globalization;

namespace ListaProdutos.Entidades
{
    class Produtos
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produtos()
        {
        }

        public Produtos(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public virtual string Etiqueta()
        {
            return Nome + " R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
