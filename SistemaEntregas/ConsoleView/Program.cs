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
        } //OPÇÕES DE ESCOLHA
        private static OpcoesMenuPrincipal Menu()
        {
            Console.WriteLine("Escolha sua opcao");
            Console.WriteLine("- Clientes -");
            Console.WriteLine("1 - Cadastrar Novo");
            Console.WriteLine("2 - Pesquisar");
            Console.WriteLine("3 - Editar");
            Console.WriteLine("4 - Excluir");
            Console.WriteLine("- Geral -");
            Console.WriteLine("5 - Limpar Tela");
            Console.WriteLine("6 - Sair");

            string opcao = Console.ReadLine();
            return (OpcoesMenuPrincipal) int.Parse(opcao);
        } //MENU










        //Metodos Cliente
        private static Cliente CadastrarCliente()
        {
            Cliente cli = new Cliente();
            Console.WriteLine();
            Console.WriteLine("Nome: ");
            cli.Nome = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Cpf: ");
            cli.Cpf = Console.ReadLine();

            Console.WriteLine();

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
        } //CADASTRO - OPC 1

        private static void ExibirDadosCliente(Cliente cliente)
        {
            Console.WriteLine();
            Console.WriteLine("### CLIENTE ###");
            Console.WriteLine("ID: " + cliente.PessoaID);
            Console.WriteLine("Nome: " + cliente.Nome);
            Console.WriteLine("Cpf: " + cliente.Cpf);

            Console.WriteLine("### Endereco ###");
            Console.WriteLine("Rua: " + cliente._Endereco.Rua);
            Console.WriteLine("Numero: " + cliente._Endereco.Numero);
            Console.WriteLine("Complemento: " + cliente._Endereco.Complemento);
            Console.WriteLine();


        } //MOSTRAR DADOS APÓS CADASTRAR

        private static Cliente PesquisarCliente() //
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
