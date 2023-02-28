using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalTalent
{
    public class Menu
    {
        public static void MenuPrincipal()
        {
            Talents talent = new Talents();

            while (true)
            {
                Console.WriteLine("Seja bem vindo ao Internal Talent!");
                Console.WriteLine("Pressione ENTER para continuar: ");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Selecione uma opção: ");
                Console.WriteLine("1 - Listar talentos disponíveis");
                Console.WriteLine("2 - Adicionar um novo Talento");
                Console.WriteLine("3 - Atualizar um Talento");
                Console.WriteLine("4 - Remover Talento");
                Console.WriteLine("5 - Sair");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        //ListarTalentos();
                        break;
                    case 2:
                        //AdicionarTalentos();
                        break;
                    case 3:
                        //AtualizarTalentos();
                        break;
                    case 4:
                        //RemoverTalento();
                        break;
                    case 5:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            }

        }
    }
}
