using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeEventos.Models
{
    public class Evento
    {
        public string NomeEvento { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string LocalEvento { get; set; }
        public decimal ParticipanteCusto { get; set; }


        public TimeSpan DuracaoEvento => DataTermino - DataInicio;

        public decimal CustoEvento => NumeroParticipantes * ParticipanteCusto;
    }
}
