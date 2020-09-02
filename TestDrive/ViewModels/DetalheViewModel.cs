using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrive.ViewModels
{
    public class DetalheViewModel
    {
        public string FreioABS
        {
            get
            {
                return String.Format("Freio ABS - R${0}", Veiculo.freioABS);
            }
        }
        public string Piscante
        {
            get
            {
                return String.Format("Piscante irado - R${0}", Veiculo.piscante);
            }
        }
        public string RadioMP3
        {
            get
            {
                return String.Format("Radio MP3 - R${0}", Veiculo.radioMP3);
            }
        }

        public bool TemFreioABS
        {
            get
            {
                return Veiculo.TemFreioABS;
            }
            set
            {
                Veiculo.TemFreioABS = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }
        public bool TemPiscanteIrado
        {
            get
            {
                return Veiculo.TemPiscanteIrado;
            }
            set
            {
                Veiculo.TemPiscanteIrado = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public bool TemRadioMP3
        {
            get
            {
                return Veiculo.TemRadioMP3;
            }
            set
            {
                Veiculo.TemRadioMP3 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }
        public string ValorTotal
        {
            get
            {
                return Veiculo.PrecoTotalFormatado;
            }
        }
    }
}
