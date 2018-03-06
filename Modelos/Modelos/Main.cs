using System;


namespace Modelos
{
    class Program
    {
        enum opcoesMenuPrincipal
        {
            CadastrarCliente,
            PesquisarCliente,
            EditarCliente,
            ExcluirCliente,
            LimparTela,
            Sair
        }

        private static opcoesMenuPrincipal Menu()
        {
            Console.WriteLine("Escolha sua opcao: ");
            Console.WriteLine("Clientes");
            Console.WriteLine("1 - Cadastrar Cliente");
            Console.WriteLine("2 - Pesquisar Cliente");
            Console.WriteLine("3 - Editar Cliente");

            Console.WriteLine("Geral");
            Console.WriteLine("4 - Limpar Tela");
            Console.WriteLine("5 - Sair");

            string opcao = Console.ReadLine();
            return (opcoesMenuPrincipal)int.Parse(opcao);
        }


        static void Main(string[] args)
        {
            opcoesMenuPrincipal opcaoDigitada = opcoesMenuPrincipal.Sair;
            do
            {
                opcaoDigitada = Menu();
                switch (opcaoDigitada)
                {
                    case opcoesMenuPrincipal.CadastrarCliente:
                        break;
                    case opcoesMenuPrincipal.PesquisarCliente:
                        break;
                    case opcoesMenuPrincipal.EditarCliente:
                        break;
                    case opcoesMenuPrincipal.ExcluirCliente:
                        break;
                    case opcoesMenuPrincipal.LimparTela:
                        break;
                    case opcoesMenuPrincipal.Sair:
                        break;
                    default:
                        break;
                }
            } while (opcaoDigitada != opcoesMenuPrincipal.Sair);
        }

        private static Cliente CadastrarCliente()
        {
            Cliente cli = new Cliente();


            Console.Write("Digite o nome: ");
            cli.nome = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Digite o CPF: ");
            cli.cpf = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Digite o endereco: ");
            cli.enderecoID = Console.Read();

            return cli;
        }

        private static Cliente PesquisarCliente()
        {
            //TODO : Fazer depois
            return new Modelos.Cliente();
        }
    }

}
