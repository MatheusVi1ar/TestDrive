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
    public partial class ListagemView : ContentPage
    {
        public ListagemView()
        {
            InitializeComponent();
        }

        private void ListViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo)e.Item;
            //DisplayAlert(veiculo.Nome, String.Format("Você clicou no veiculo {0} que custa {1}", veiculo.Nome, veiculo.PrecoFormatado), "OK");
            Navigation.PushAsync(new DetalheView(veiculo));
        }
    }
}