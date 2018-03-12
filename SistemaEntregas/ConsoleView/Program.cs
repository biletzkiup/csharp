using Controller;
using Modelos;
using System;

namespace ConsoleView
{
    class Program
    {
        enum OpcoesMenuPrincipal
        {
            CadastrarCliente = 1,
            PesquisarCliente = 2,
            EditarCliente = 3,
            ExcluirCliente = 4,
            LimparTela = 5,
            Sair = 6
        }
        private static OpcoesMenuPrincipal Menu()
        {
            Console.WriteLine("Escolha sua opcao");
            Console.WriteLine();
            Console.WriteLine("- Clientes -");
            Console.WriteLine("1 - Cadastrar Novo");
            Console.WriteLine("2 - Pesquisar");
            Console.WriteLine("3 - Editar");
            Console.WriteLine("4 - Excluir");
            Console.WriteLine("- Geral -");
            Console.WriteLine("5 - Limpar Tela");
            Console.WriteLine("6 - Sair");
            Console.WriteLine();

            string opcao = Console.ReadLine();
            return (OpcoesMenuPrincipal) int.Parse(opcao);
        }

        //Metodos Cliente
        private static Cliente CadastrarCliente()
        {
            Cliente cli = new Cliente();

            Console.WriteLine("Nome: ");
            cli.Nome = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Cpf: ");
            cli.Cpf = Console.ReadLine();

            Console.WriteLine();

            //Instanciando endereço
            Endereco end = new Endereco();

            Console.WriteLine("Rua: ");
            end.Rua = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Numero: ");
            end.Numero = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Complemento: ");
            end.Complemento = Console.ReadLine();

            cli._Endereco = end;

            return cli;
        }

        private static void ExibirDadosCliente(Cliente cliente)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("- Dados Cliente -");
            Console.WriteLine("ID: " + cliente.PessoaID);
            Console.WriteLine("Nome: " + cliente.Nome);
            Console.WriteLine("Cpf: " + cliente.Cpf);
            Console.WriteLine("- Endereço - ");
            Console.WriteLine("Rua: " + cliente._Endereco.Rua);
            Console.WriteLine("Numero: " + cliente._Endereco.Numero);
            Console.WriteLine("Complemento: " + cliente._Endereco.Complemento);
            Console.WriteLine("--------------------");
            Console.WriteLine();
        }

        private static Cliente PesquisarCliente()
        {
            return new Cliente();
        }

        private static Cliente EditarCliente()
        {
            return new Cliente();
        }

        private static Cliente ExcluirCliente()
        {
            return new Cliente();
        }


        static void Main(string[] args)
        {

            OpcoesMenuPrincipal opcaoDigitada = OpcoesMenuPrincipal.Sair;
            do
            {
                opcaoDigitada = Menu();

                switch (opcaoDigitada)
                {
                    case OpcoesMenuPrincipal.CadastrarCliente:
                        Cliente c = CadastrarCliente();
                        ClienteController cc = new ClienteController();
                        cc.SalvarCliente(c);
                        ExibirDadosCliente(c);
                        break;                   
                    case OpcoesMenuPrincipal.PesquisarCliente:
                        PesquisarCliente();
                        break;
                    case OpcoesMenuPrincipal.EditarCliente:
                        EditarCliente();
                        break;
                    case OpcoesMenuPrincipal.ExcluirCliente:
                        ExcluirCliente();
                        break;
                    case OpcoesMenuPrincipal.LimparTela:
                        Console.Clear();
                        break;
                    default:
                        break;

                }
            } while (opcaoDigitada != OpcoesMenuPrincipal.Sair);

        }
    }
}
