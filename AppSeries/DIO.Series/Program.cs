using System;
using DIO.Series.Classes;
using DIO.Series.Enum;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
           string opcaoUsuario = ObterOpcaoUsuario();
           while(opcaoUsuario.ToUpper() != "X")
           {
               switch(opcaoUsuario)
               {
                case "1":
                    ListarSeries();   
                    break;
                case "2" :
                    InserirSerie();
                    break;
                case "3":
                    AtualizarSerie();    
                    break;
                case "4":
                    ExcluirSerie();
                    break;
                case "5":
                     VisualizarSerie();   
                    break;
                case "C":
                    Console.Clear();
                    break;
               default:
                throw new ArgumentOutOfRangeException();
               }
               opcaoUsuario = ObterOpcaoUsuario();
           }


           Console.WriteLine("Obrigador por utilizar nossos serviços.");
           Console.WriteLine();
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Listar series");
            var lista = repositorio.Lista();
            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }
            foreach(var serie in lista){

                var excluido =serie.RetornaExcluido();
                Console.WriteLine($"# ID{serie.RetornoId()}: - {serie.RetornaTitulo()}:-{(excluido? "*Excluido*":"")}");
              //  Console.WriteLine("#ID{0}:-{1} {2}",serie.RetornoId(),serie.RetornaTitulo(),(excluido ? "*Excluido*":"") );
            }
        }
        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");
            foreach(int i in System.Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i ,System.Enum.GetName(typeof(Genero),i));
            }
           Console.Write("Digite o genero entre as opções acima: ");
           int entradaGenero = int.Parse(Console.ReadLine());

           Console.Write("Digite o titulo da serie: ");
           string entradaTitulo = Console.ReadLine();

           Console.Write("Digite o ano de inicio da serie: ");
           int entradaAno = int.Parse(Console.ReadLine());

           Console.WriteLine("Digite a Descrição da serie: ");
           string entradaDescricao = Console.ReadLine();

           Serie novaSerie = new Serie(id: repositorio.ProximoId(),
           genero: (Genero)entradaGenero,
           titulo: entradaTitulo,
           ano: entradaAno,
           descricao: entradaDescricao);
           repositorio.Insere(novaSerie);

        }
        private static void AtualizarSerie()
        {
            Console.Write("Digite o id da serie: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            foreach(int i in System.Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}",i, System.Enum.GetName(typeof(Genero),i));
            }
           Console.Write("Digite o genero entre as opções acima: ");
           int entradaGenero = int.Parse(Console.ReadLine());

           Console.Write("Digite o titulo da serie: ");
           string entradaTitulo = Console.ReadLine();

           Console.Write("Digite o ano de inicio da serie: ");
           int entradaAno = int.Parse(Console.ReadLine());

           Console.WriteLine("Digite a Descrição da serie: ");
           string entradaDescricao = Console.ReadLine();

           Serie novaSerie = new Serie(id: indiceSerie,
           genero: (Genero)entradaGenero,
           titulo: entradaTitulo,
           ano: entradaAno,
           descricao: entradaDescricao);
           repositorio.Insere(novaSerie);

        }
        private static void ExcluirSerie()
        {
            Console.Write("Digite o id da Série:  ");
            int indiceSerie = int.Parse(Console.ReadLine());
            repositorio.Exclui(indiceSerie);

        }

        private static void VisualizarSerie()
        {
            Console.Write("Digite o id da serie: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            var serie = repositorio.RetornaPorId(indiceSerie);
            Console.WriteLine(serie);
        }   
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Dio Series a seu dispor!!");
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair ");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;



        }
    }
}
