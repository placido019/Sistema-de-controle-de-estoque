using System.Globalization;
namespace Course
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        //Serei obrigado a informar nome, preço e quantidade
        //na hora de instânciar o produto!
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public Produto()
        {

        }
        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
        }

        public string Nome
        {
            get { return _nome; }

            set
            {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }

        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        class Programa
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Entre os dados do produto:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade no estoque: ");
                int quantidade = int.Parse(Console.ReadLine());
                Console.WriteLine();

                //Instânciei o produto com os dados inseridos ali em cima!
                Produto p = new Produto(nome, preco, quantidade);

                Produto p2 = new Produto();

                Produto p3 = new Produto
                {
                    _nome = "Tv",
                    _preco = 500.00,
                    _quantidade = 20
                };

                Console.WriteLine("Dados do produto: " + p);
                Console.WriteLine();

                Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
                int qte = int.Parse(Console.ReadLine());
                p.AdicionarProdutos(qte);
                Console.WriteLine();

                Console.WriteLine("Dados atualizados: " + p);
                Console.WriteLine();

                Console.Write("Digite o número de produtos a ser removido do estoque: ");
                qte = int.Parse(Console.ReadLine());

                p.RemoverProdutos(qte);
                Console.WriteLine();

                Console.WriteLine("Dados atualizados: " + p);

            }
        }
    }

}
