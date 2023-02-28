using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalTalent
{
    public class Talents
    {
        public Talents() { }
        public Talents(int id, string name, string title, string tc, int age, string state, string technologyPreference, string caName)
        {
            this.Id = id;
            this.Name = name;
            this.Title = title;
            this.TC = tc;
            this.Age = age;
            this.State = state;
            this.TechnologyPreference = technologyPreference;
            this.CaName = caName;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string TC { get; set; }
        public int Age { get; set; }
        public string State { get; set; }
        public string TechnologyPreference { get; set; }
        public string CaName { get; set; }


        private static void ListarTalentos()
        {
            throw new NotImplementedException();
        }

        private static void AdicionarTalentos()
        {
            throw new NotImplementedException();
        }
        private static void AtualizarTalento()
        {
            throw new NotImplementedException();
        }
        private static void RemoverTalento()
        {
            throw new NotImplementedException();
        }

    }
}
