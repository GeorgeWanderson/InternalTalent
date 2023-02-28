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
            int option = 0;
            while (option != 5)
            {
                Console.WriteLine("Selecione uma opção: ");
                Console.WriteLine("1 - Listar talentos disponíveis");
                Console.WriteLine("2 - Adicionar um novo Talento");
                Console.WriteLine("3 - Atualizar um Talento");
                Console.WriteLine("4 - Remover Talento");
                Console.WriteLine("5 - Sair");

                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Opção inválidadd!");
                    continue;
                }
                switch (option)
                {
                    case 1:
                        Talents.ListarTalentos();
                        break;
                    case 2:
                        Talents.AdicionarTalentos();
                        break;
                    case 3:
                        Talents.AtualizarTalento();
                        break;
                    case 4:
                        Talents.RemoverTalento();
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
