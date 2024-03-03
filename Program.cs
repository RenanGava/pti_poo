﻿namespace PTI_POO
{
  class Program
  {
    static void Main(string[] args)
    {
      while (true)
      {
        Console.WriteLine("Qual Veiculo deseja Alugar\n[1] - Carro\n[2] - Moto");
        Console.WriteLine("Pressione [ESC] Para Sair");
        ConsoleKeyInfo opcao = Console.ReadKey(true);

        if (opcao.KeyChar == '1')
        {

          var carro = new Carro(50.00);
          carro.CalcularValorTotal(10);
          var valorTotal = carro.CalcularValorTotal(10);
          Console.WriteLine("Valor total das diarias do Carro: " + valorTotal);

        }
        else if (opcao.KeyChar == '2')
        {
          var moto = new Moto(25.00);
          var valorTotal = moto.CalcularValorTotal(10);

          Console.WriteLine("Valor total das diarias da Moto: " + valorTotal);
        }
        else if (opcao.Key == ConsoleKey.Escape)
        {
          Console.WriteLine("Saindo do Sistema...");
          break;
        }
        else
        {
          Console.WriteLine("Opção Invalida!");
        }
      }
    }
  }
}