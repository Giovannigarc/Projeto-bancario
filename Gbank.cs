using System;
using System.Collections.Generic;

namespace g.bank
{
    class Program
    {


        static List<conta> listContas = new List<conta>();
       
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "6":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                  opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
           }

        private static void Sacar()
        {
            Console.Write("Digite o numero da Conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(valorSaque);
        }

        private static void Depositar()
        {
            Console.Write("Digite o numero da Conta ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].Depositar(valorDeposito);
        }

        private static void Transferir()
        {

            Console.Write("Digite o numero da Conta de Origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.Write("Digite o numero da conta de destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser transferido: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);
        }


        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova conta");

            Console.Write("Digite 1 para Conta fisica ou 2 para conta juridica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o Nome do Cliente: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o saldo inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o Credito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            conta novaConta = new conta(tipoConta: (TipoConta)entradaTipoConta,
                                          saldo: entradaSaldo,
                                          credito: entradaCredito,
                                          nome: entradaNome);

            listContas.Add(novaConta);
        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar Contas");
            if(listContas.Count == 0)
            {
                Console.WriteLine("Nenhuma Conta Cadastrada.");
                return;

            }

            for (int i = 0; i < listContas.Count; i++)
            {
                conta conta = listContas[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(conta);
            }

        }


        private static string ObterOpcaoUsuario()  
      {
        Console.WriteLine();
        Console.WriteLine("Gbank a seu Dispor!!");
        Console.WriteLine();

        Console.WriteLine("1 - Listar contas");
        Console.WriteLine("2 - Inserir nova conta");
        Console.WriteLine("3 - Transferir");
        Console.WriteLine("4 - Sacar");
        Console.WriteLine("5 - Depositar");
        Console.WriteLine("C - Limpar Tela");
        Console.WriteLine("X - Sair");
            Console.WriteLine();

        String opcaoUsuario = Console.ReadLine().ToUpper();
        Console.WriteLine();
            return opcaoUsuario;
        
       } 
    } 
}


        

    

