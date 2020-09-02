using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDrive.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDrive.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgendamentoView : ContentPage
    {
        public Agendamento Agendamento { get; set; }
        public Veiculo Veiculo { 
            get 
            { 
                return Agendamento.Veiculo;
            } 
            set 
            { 
                Agendamento.Veiculo = value; 
            } 
        }
        public String Nome
        {
            get
            {
                return Agendamento.Nome;
            }
            set
            {
                Agendamento.Nome = value;
            }
        }
        public String Telefone
        {
            get
            {
                return Agendamento.Telefone;
            }
            set
            {
                Agendamento.Telefone = value;
            }
        }
        public String Email
        {
            get
            {
                return Agendamento.Email;
            }
            set
            {
                Agendamento.Email = value;
            }
        }
        public DateTime Data
        {
            get
            {
                return Agendamento.Data;
            }
            set
            {
                Agendamento.Data = value;
            }
        }
        public TimeSpan Hora
        {
            get
            {
                return Agendamento.Hora;
            }
            set
            {
                Agendamento.Hora = value;
            }
        }
        public AgendamentoView(Veiculo veiculo)
        {
            InitializeComponent();
            this.Agendamento = new Agendamento();
            Agendamento.Veiculo = veiculo;
            this.BindingContext = this;
        }

        private void btnAgendar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Agendamento", string.Format(
                " Veiculo: {0} " +
                "\n Nome: {1} " +
                "\n Telefone: {2}" +
                "\n Email: {3}" +
                "\n Data agendamento: {4}" +
                "\n Hora agendamento: {5}",
                Agendamento.Veiculo.Nome, Agendamento.Nome, Agendamento.Telefone, 
                Agendamento.Email, Agendamento.Data.ToString("dd/mm/yyyy"), Agendamento.Hora),
                "Ok");
        }
    }
}