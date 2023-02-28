using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalTalent
{
    public class Talents
    {
        static List<Talents> talent = new List<Talents>();
        public Talents() { }
        public Talents(int id, string name, string title, int age, string caName)
        {
            this.Id = id;
            this.Name = name;
            this.Title = title;
            this.Age = age;
            this.CaName = caName;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string CaName { get; set; }
        public int Age { get; set; }

        public static void ListarTalentos()
        {
            Console.Clear();
            Console.WriteLine("Lista de Talentos:");

            if (talent == null || !talent.Any())
            {
                Console.WriteLine("Não há talentos para listar.");
                return;
            }

            foreach (Talents talents in talent)
            {
                Console.WriteLine($"ID: {talents.Id}, " +
                    $"Nome: {talents.Name}, " +
                    $"Idade: {talents.Age}, " +
                    $"Nome do Career Advisor: {talents.CaName}, " +
                    $"Cargo Atual: {talents.Title}");
            }

            Console.WriteLine("Para voltar ao Menu, pressione ENTER");
            Console.ReadKey();
            Console.Clear();
            Menu.MenuPrincipal();
        }
        public static void AdicionarTalentos()
        {
            Talents talents = new Talents();

            Console.Clear();
            Console.WriteLine("Vamos adicionar um novo talento!");
            Console.WriteLine();
            Console.WriteLine("Registre um ID para esse Talento: ");
            talents.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o nome do Talento:");
            talents.Name = Console.ReadLine();
            Console.WriteLine("Informe o título do Talento: (EX: Full-Stack Developer)");
            talents.Title = Console.ReadLine();
            Console.WriteLine("Informe a idade do Talento:");
            talents.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o nome do Career Advisor desse Talento:");
            talents.CaName = Console.ReadLine();

            talent.Add(talents);

            Console.WriteLine("O Talento está sendo cadastrado, aguarde alguns segundos...");
            Thread.Sleep(1450);
            Console.WriteLine("Cadastrando...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Cadastrado! Redirecionando para o MENU principal...");
            Thread.Sleep(1000);
            Console.Clear();
            Menu.MenuPrincipal();
        }
        public static void AtualizarTalento()
        {
            Console.Clear();
            Console.WriteLine("Digite o ID da pessoa que deseja atualizar:");
            int id = int.Parse(Console.ReadLine());

            Talents talents = talent.Find(t => t.Id == id);

            if (talents == null)
            {
                Console.WriteLine("Pessoa não encontrada");
            }
            else
            {
                Console.WriteLine($"Pessoa encontrada - ID: {talents.Id} - Nome: {talents.Name}");

                Console.WriteLine("Informe o nome correto do Talento:");
                string newTalentName = Console.ReadLine();
                talents.Name = newTalentName;

                Console.WriteLine("Informe o título correto do Talento: (EX: Full-Stack Developer)");
                string newTitle = Console.ReadLine();
                talents.Title = newTitle;

                Console.WriteLine("Informe a idade correta do Talento:");
                int newAge = Convert.ToInt32(Console.ReadLine());
                talents.Age = newAge;
                Console.WriteLine("Informe o nome correto do Career Advisor desse Talento:");
                string newCa = Console.ReadLine();
                talents.CaName = newCa;

                Console.WriteLine("Talento atualizado com sucesso!");
            }
        }
        public static void RemoverTalento()
        {
            Console.Clear();
            Console.WriteLine("Digite o ID da pessoa que deseja remover:");
            int id = int.Parse(Console.ReadLine());

            Talents talents = talent.Find(p => p.Id == id);

            if (talents == null)
            {
                Console.WriteLine("Talento não encontrada");
            }
            else
            {
                talent.Remove(talents);
                Console.WriteLine("Talento removida com sucesso");
            }

            Console.WriteLine("Redirecionando para o Menu Principal...");
            Thread.Sleep(1450);
            Console.Clear();
            Menu.MenuPrincipal();
        }

    }
}
