


namespace Course
{
    class Product
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString("F2") + ", Quantidade em estoque: " + Quantidade
            + " Total: $ " + ValorTotalEmEstoque().ToString("F2");
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
    }
}