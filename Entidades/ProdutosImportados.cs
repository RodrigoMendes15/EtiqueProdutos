using System.Globalization;

namespace ListaProdutos.Entidades
{
    class ProdutosImportados : Produtos
    {
        public double TaxaImport { get; set; }

        public ProdutosImportados()
        {
        }

        public ProdutosImportados(string nome, double preco, double taxaImport) : base(nome, preco)
        {
            TaxaImport = taxaImport;
        }

        public double Total()
        {
            return Preco + TaxaImport;
        }
        public override string Etiqueta()
        {
            return Nome + " R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + " (Taxa de Importação: R$ " + TaxaImport.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
