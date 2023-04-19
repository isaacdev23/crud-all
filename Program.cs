using static System.Console;


namespace projeto
{
    class MainClass
    {
        public static void printMenu(String[] options)
        {
            foreach (String option in options)
            {
                WriteLine(option);
            }
            WriteLine("Escolha sua opção");
        }
        public static void Main(String[] args)
        {
            WriteLine(">>>>>> Cadastro de pessoas <<<<<<");
            String[] options = {"1 - Cadastrar",
                               "2 - Editar",
                               "3 - Excluir",
                               "4 - Listar",
                               "5 - sair"};
            int option = 0;
            while (true)
            {
                printMenu(options);
                try
                {
                    option = Convert.ToInt32(ReadLine());
                }
                catch (System.FormatException)
                {
                    WriteLine("Por favor, digite uma opção entre 1 e " + options.Length);
                    continue;
                }
                catch (Exception)
                {
                    WriteLine("Um erro aconteceu!!");
                    continue;
                }
                switch (option)
                {
                    case 1:
                        Cadastrar();
                        break;
                    case 2:
                        //Editar();
                        break;
                    case 3:
                        //Excluir();
                        break;
                    case 4:
                        Listar();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        WriteLine("Por favor, digite uma opção entre 1 e " + options.Length);
                        break;
                }
            }
        }

        static List<string> nomes = new List<string>();
        static List<int> idades = new List<int>();

        private static void Cadastrar()
        {
            Clear();
            WriteLine(">>>>>> Cadastro de pessoa <<<<<<");
            WriteLine();
            WriteLine("Digite o nome da pessoa :");
            nomes.Add(ReadLine());
            WriteLine("Digite a idade da pessoa :");
             idades.Add(Convert.ToInt32(ReadLine()));
            WriteLine();

        }

        private static void Listar()
        {
            Clear();
            WriteLine();
            WriteLine(">>>> LISTAGEM DE PESSOAS <<<<");
            int pos = 0;
            foreach (var item in nomes)
            {
                WriteLine($"Nome: {item}, idade: {idades[pos]}");
                pos++;
            }
            WriteLine();
        }
    }
}