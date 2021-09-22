using System;
using System.Globalization; //for lots of globalization types


namespace homework5
{
    public class Program
    {
        static void Main(string[] arg)
        {
            //recieve name, value and quantity of item
            Console.WriteLine("Entre com os dados do produto;");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            // creates product data
            Produto p = new Produto(nome, preco, quantidade);
            //show product data
            Console.WriteLine("Dados do produto:" + p);
            //adds products to stock
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);
            //updates total values
            Console.WriteLine("Dados do atualizados: " + p);
            //removes products from stock
            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);
            //updates total values
            Console.WriteLine("Dados do atualizados: " + p);
        }
    }
    public class Produto
    {
        //declaration
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {

        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            _nome = nome;
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }
        //calculates total stock value, based on item price and quantity
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        //adds to the stock
        public void AdicionarProduto(int quantidade)
        {
            _quantidade += quantidade;
        }
        //removes from the stock
        public void RemoverProduto(int quantidade)
        {
            _quantidade = _quantidade - quantidade;
        }
        //overrides values
        public override string ToString()
        {
            return _nome
            + ", R$"
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + _quantidade
            + " unidades, Total: R$"
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
