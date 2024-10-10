using System;
using System.Collections.Generic;

namespace SistemaEstacionamento.Models
{
    public class Estacionamento
    {

        List<string> Veiculos = new List<string>();
        private int precoInicial = 0;
        private int valordahora = 0;

        public void Opcoes()
        {
            Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
            Console.WriteLine("Digite o preço inicial");
            precoInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da hora");
            valordahora = int.Parse(Console.ReadLine());
            char op = '0';
            while (op != '4')
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção: \n" +
                    "1 - Cadastrar Veículo \n" +
                    "2 - Remover Veículo \n" +
                    "3 - Listar Veículos \n" +
                    "4 - Sair");
                op = char.Parse(Console.ReadLine());

                switch (op)
                {
                    case '1':
                        CadastrarVeiculo();
                        break;
                    case '2':
                        RemoverVeiculo();
                        break;
                    case '3':
                        ListarVeiculos();
                        break;
                    case '4':
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
            }
        }

        private void CadastrarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo: ");
            Veiculos.Add(Console.ReadLine());
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadLine();
        }

        private void RemoverVeiculo()
        {
            string placa = "";
            int qtdHoras = 0;
            int valorAPagarDoVeiculo = 0;
            Console.WriteLine("Digite a placa do veículo que deseja remover: ");
            foreach (string veiculo in Veiculos)
            {
                Console.WriteLine(veiculo);
            }
            placa = Console.ReadLine();
            Veiculos.Remove(placa);
            Console.WriteLine("Digite a quantidade de horas que o veículo ficou estacionado:");
            qtdHoras = int.Parse(Console.ReadLine());
            valorAPagarDoVeiculo = (qtdHoras * valordahora) + precoInicial;

            Console.WriteLine($"O veículo {placa} ficou estacionado por {qtdHoras} horas, o valor a pagar é de: R${valorAPagarDoVeiculo},00");
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadLine();
        }

        private void ListarVeiculos()
        {
            foreach (var item in Veiculos)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadLine();
        }
    }
}
