using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrive.Model
{
    public class Veiculo
    {
        public const double freioABS = 800;
        public const double piscante = 20;
        public const double radioMP3 = 400;
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string PrecoFormatado
        {
            get { return String.Format("R${0}", Preco); }
        }
        public bool TemPiscanteIrado { get; set; }
        public bool TemFreioABS { get; set; }
        public bool TemRadioMP3 { get; set; }
        public string PrecoTotalFormatado
        {
            get
            {
                return String.Format("Valor Total: R${0}", Preco 
                    + (TemFreioABS ? Veiculo.freioABS : 0)
                    + (TemPiscanteIrado ? Veiculo.piscante : 0) 
                    + (TemRadioMP3 ? Veiculo.radioMP3 : 0));
            }
        }
    }
}
