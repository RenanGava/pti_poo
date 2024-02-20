namespace PTI_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual Veiculo deseja Alugar\n[1] - Carro\n[2] - Moto");
            ConsoleKeyInfo opcao = Console.ReadKey(true);

            if (opcao.KeyChar == '1')
            {

                var carro = new Carro(50.00);
                Console.WriteLine(carro.CalcularValorTotal(10));

            }
            else if (opcao.KeyChar == '2')
            {
                var moto = new Moto(25.00);

                Console.WriteLine(moto.CalcularValorTotal(10));
            }
            else
            {
                Console.WriteLine("Opção Invalida!");
            }
        }
    }
}