using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrive.Model
{
    public class Agendamento
    {
        public Veiculo Veiculo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime Data = DateTime.Today;
        public TimeSpan Hora { get; set; }
    }
}
