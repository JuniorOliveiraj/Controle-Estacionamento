using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JR_Sofware
{
    internal class RegistersAll
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime saida { get; set; }
        public TimeSpan duracao { get; set; }
        public double preco { get; set; }
        public double pago { get; set; }

    }
}
